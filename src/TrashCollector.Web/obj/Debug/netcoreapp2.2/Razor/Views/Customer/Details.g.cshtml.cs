#pragma checksum "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "730faa408a94f3dc065f20ede19dbdd8ac37fc0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/_ViewImports.cshtml"
using TrashCollector.Web;

#line default
#line hidden
#line 2 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/_ViewImports.cshtml"
using TrashCollector.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730faa408a94f3dc065f20ede19dbdd8ac37fc0f", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe6be125b9b3e3bad0acb65e66ccbf67f14c9f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrashCollector.Web.Models.DCustomer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 110, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Details</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(200, 45, false);
#line 12 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(245, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(308, 41, false);
#line 15 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(349, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(412, 44, false);
#line 18 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(456, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(519, 40, false);
#line 21 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(559, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(622, 45, false);
#line 24 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PickUpDay));

#line default
#line hidden
            EndContext();
            BeginContext(667, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(730, 41, false);
#line 27 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.PickUpDay));

#line default
#line hidden
            EndContext();
            BeginContext(771, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(834, 53, false);
#line 30 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OneTimePickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(887, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(950, 49, false);
#line 33 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.OneTimePickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(999, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(1062, 55, false);
#line 36 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SuspendPickupsStart));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(1180, 51, false);
#line 39 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.SuspendPickupsStart));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(1294, 53, false);
#line 42 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SuspendPickupsEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(1410, 49, false);
#line 45 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
       Write(Html.DisplayFor(model => model.SuspendPickupsEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 228, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div id=\"map\" class=\"shadow\" style=\"width:500px; height: 320px;\"></div>\r\n<script>\r\nfunction searchAddress(){\r\n    var geocoder = new google.maps.Geocoder;\r\n    geocoder.geocode( { \'address\': \'");
            EndContext();
            BeginContext(1688, 15, false);
#line 53 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
                               Write(ViewBag.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1703, 784, true);
            WriteLiteral(@"'}, function(results, status) {
      if (status == 'OK') {
        var map = new google.maps.Map(document.getElementById('map'), {zoom: 15});
        map.setCenter(results[0].geometry.location);
        var marker = new google.maps.Marker({
            map: map,
            position: results[0].geometry.location
        });
      } else {
        document.querySelector(""#map"").innerHTML = ""<span style='color:red;'>Address not found.</span>"";
      }
    });
}
</script>
<!--Load the API from the specified URL
* The async attribute allows the browser to render the page while the API loads
* The key parameter will contain your own API key (which is not needed for this tutorial)
* The callback parameter executes the initMap() function
-->
<script async defer");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2487, "\"", 2584, 3);
            WriteAttributeValue("", 2493, "https://maps.googleapis.com/maps/api/js?key=", 2493, 44, true);
#line 72 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
WriteAttributeValue("", 2537, Startup.GoogleMapApiKey, 2537, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 2561, "&callback=searchAddress", 2561, 23, true);
            EndWriteAttribute();
            BeginContext(2585, 31, true);
            WriteLiteral(">\r\n</script>\r\n<br>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2616, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730faa408a94f3dc065f20ede19dbdd8ac37fc0f11769", async() => {
                BeginContext(2670, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Details.cshtml"
                           WriteLiteral(Model.CustomerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2678, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2686, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730faa408a94f3dc065f20ede19dbdd8ac37fc0f14100", async() => {
                BeginContext(2708, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2724, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrashCollector.Web.Models.DCustomer> Html { get; private set; }
    }
}
#pragma warning restore 1591
