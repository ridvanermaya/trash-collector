## How to Create Identity WebApp

1. First of all we need to create our solution so let's write this command to our terminal.

```
dotnet new sln --name <SolutionName>
```

2. After we create our solution, now we need to create our project. Writing this command will create a web app with Identity.

##### Note: This is an identity webapp project.

```
dotnet new webapp --name <ProjectName> -o <OutputName/FileName>
```

##### Note: To Create and MVC project run this command

~~~
dotnet new mvc --name <ProjectName> --auth Individual -o <OutputName/FileName>
~~~

3. Now we have our solution and project. It is time to scaffold Identity.

##### Note: This part is important since anything you want to add or change for user Login/LogOut/Register we are going to be using this.

#### -- To do this we need to install a tool to generate our code

#### -- Install the tool write this command to your terminal

```
dotnet tool install -g dotnet-aspnet-codegenerator
```

##### Note: When you install the tool once, you won't need to install this tool again.

### After installing the tool now we need to add a package to our project as well.

```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

### And run identity scaffolder

```
dotnet aspnet-codegenerator identity -dc <FilePathForApplicationDbContext> --files "Account.Register;Account.Login;Account.Logout"
```

#### This last command creates the files in Areas/Identity/Pages/Account

4. If you are going to be using roles now we need to add roles lets add this code to our Startup.cs

```Csharp
public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                // TO ADD ROLES ADD THIS LINE TO YOUR CONFIGURE SERVICES
                .AddRoles<IdentityRole>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
```

5. Now we told our program that we will be using roles. So let's add the option to choose a role upon registration.

In our Register.cshtml.cs File which is our Register Model, we need to add "Role Manager"

Let's add this as our member variable,

```
private readonly RoleManager<IdentityRole> _roleManager;
```

6. Now add this paramater to your constructor and inside assign the value in the constructor

```csharp
RoleManager<IdentityRole> roleManager;

_roleManager = roleManager;
```

#### Your Code should look like this...

```csharp
[AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }
```

7. Now we are going to add the field to our ~InputModel~

```csharp
[Required(ErrorMessage = "You must choose a role to register."]
[Display(Name = "Choose Role")]
public string Role { get; set; }
```

8. Now it is time to add the visual part! So go to your Register.cshtml

#### This part is mainly up to you, whatever the field you want to add you can customize it the way you want it. But for me since I am asking to choose a role, I will be asking to choose a role. 

##### Note: Make sure that "asp-for" is for the property name you have in your Register.cshtml.cs file. It is in our Input Model we are starting with "Input.<PropertyName>

```html
<div class="form-group">
    <label asp-for="Input.Role"></label>
    <select asp-for="Input.Role" class="form-control">
        <option value="Customer">Customer</option>
        <option value="Employee">Employee</option>
    </select>
    <span asp-validation-for="Input.Role" class="text-danger"></span>
</div>
```

9. Wow! Now we have our visual content and property. Now it is time to bind these and if necessary create roles upon registration.

#### But first, let's create a method to check existing roles and if the role doesn't exist we need to create it.

~~~csharp
public async Task CheckRoles()
{
    // We getting all the existing roles to a list and to our 'roles' variable
    var roles = _roleManager.Roles.ToList();
    // Here we are checking if the roles contain 'Customer' role
    if(!roles.Any(x => x.Name.Equals("Customer"))
    {
        // If it doesn't contain it then create new IdentityRole with the name of 'Customer'
        await _roleManager.CreateAsync(new IdentityRole() { Name = "Customer"});
    }
    // Here we are checking again if we have the role 'Employee' since we have only two roles
    if(!roles.Any(x => x.Name.Equals("Employee")))
    {
        // Again if our role doesn't exist, it creates a new IdentityRole with the name of 'Employee'
        await _roleManager.CreateAsync(new IdentityRole() { Name = "Employee"});
    }
}
~~~

#### Now we are going to run our CheckRoles method and bind it to the User

#### Our OnPostAsync should look like this

~~~csharp
public async Task<IActionResult> OnPostAsync(string returnUrl = null)
{
    returnUrl = returnUrl ?? Url.Content("~/");
    if (ModelState.IsValid)
    {
        var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
        var result = await _userManager.CreateAsync(user, Input.Password);
        if (result.Succeeded)
        {
            // if succeeded let's call our method here
            await CheckRoles();

            // Then we are going to check what the user chose...
            if(Input.Role.Equals("Customer"))
            {
                // the user chooses 'Customer' role we are binding it to the user
                await _userManager.AddToRoleAsync(user, "Customer");
            }
            else
            {
                // the user chooses 'Employee' role we are binding it to the user
                await _userManager.AddToRoleAsync(user, "Employee");
            }
            
            _logger.LogInformation("User created a new account with password.");

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = user.Id, code = code },
                protocol: Request.Scheme);

            await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            await _signInManager.SignInAsync(user, isPersistent: false);
            return LocalRedirect(returnUrl);
        }
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
    }

    // If we got this far, something failed, redisplay form
    return Page();
}
~~~

10. Now you can go ahead and check if you're able to Register with the Role!

Getting RazerPage / WebApp

~~~
dotnet aspnet-codegenerator razorpage -m DAddress -dc ApplicationDbContext --relativeFolderPath Pages/Address --useDefaultLayout --referenceScriptLibraries
~~~

Getting Controller / MVC

~~~
dotnet aspnet-codegenerator controller -name <ControllerName> -m <ModelName> -dc <FilePathForTheApplicationDb> --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
~~~

Setting Defuault Connection String

~~~
DefaultConnection = "Server=localhost;Database=<DatabaseName>;User Id=<UserId>;Password=<Password>"
~~~