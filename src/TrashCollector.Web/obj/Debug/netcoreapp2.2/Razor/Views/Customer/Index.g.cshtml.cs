#pragma checksum "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf9f35eb1112453e8b8e4ba064d8f351d8859e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf9f35eb1112453e8b8e4ba064d8f351d8859e3", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe6be125b9b3e3bad0acb65e66ccbf67f14c9f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TrashCollector.Web.Models.DCustomer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 106, true);
            WriteLiteral("\r\n<h4>Profile</h4>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(207, 45, false);
#line 13 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(252, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(308, 44, false);
#line 16 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(352, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 45, false);
#line 19 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PickUpDay));

#line default
#line hidden
            EndContext();
            BeginContext(453, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(509, 53, false);
#line 22 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OneTimePickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(562, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(618, 55, false);
#line 25 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SuspendPickupsStart));

#line default
#line hidden
            EndContext();
            BeginContext(673, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(729, 53, false);
#line 28 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SuspendPickupsEnd));

#line default
#line hidden
            EndContext();
            BeginContext(782, 172, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-weight-bold\">\r\n                Action\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(986, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1035, 44, false);
#line 40 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1135, 43, false);
#line 43 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1234, 44, false);
#line 46 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PickUpDay));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1334, 52, false);
#line 49 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OneTimePickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1442, 54, false);
#line 52 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SuspendPickupsStart));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1552, 52, false);
#line 55 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SuspendPickupsEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1659, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf9f35eb1112453e8b8e4ba064d8f351d8859e310153", async() => {
                BeginContext(1712, 4, true);
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
#line 58 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
                                       WriteLiteral(item.CustomerId);

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
            BeginContext(1720, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1740, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf9f35eb1112453e8b8e4ba064d8f351d8859e312506", async() => {
                BeginContext(1796, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
                                          WriteLiteral(item.CustomerId);

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
            BeginContext(1807, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 62 "/Users/redone/git/DevCodeCamp/Week_08/Projects/trash-collector/src/TrashCollector.Web/Views/Customer/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1846, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TrashCollector.Web.Models.DCustomer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
