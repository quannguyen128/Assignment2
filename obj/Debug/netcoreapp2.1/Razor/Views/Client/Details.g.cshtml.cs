#pragma checksum "C:\CapIT\Assignment2\Views\Client\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3bc914262a643089df1284ea8bfb4ac0bd0a9d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Details), @"mvc.1.0.view", @"/Views/Client/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Details.cshtml", typeof(AspNetCore.Views_Client_Details))]
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
#line 1 "C:\CapIT\Assignment2\Views\_ViewImports.cshtml"
using Assignment2;

#line default
#line hidden
#line 2 "C:\CapIT\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3bc914262a643089df1284ea8bfb4ac0bd0a9d9", @"/Views/Client/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2f008bb030c689fdd92cf0ac6c09ff2675aa17", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment2.Models.Client>
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Client</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 47, false);
#line 14 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 43, false);
#line 17 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(334, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(378, 45, false);
#line 20 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 41, false);
#line 23 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(552, 44, false);
#line 26 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(596, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(640, 40, false);
#line 29 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(680, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(724, 41, false);
#line 32 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 37, false);
#line 35 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(846, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(890, 41, false);
#line 38 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(931, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(975, 37, false);
#line 41 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1059, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0463df2cedf94cc58b0cc8e7184010d9", async() => {
                BeginContext(1105, 4, true);
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
#line 46 "C:\CapIT\Assignment2\Views\Client\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(1113, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1121, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f755bb30a55b40808b01f03c7485907d", async() => {
                BeginContext(1143, 12, true);
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
            BeginContext(1159, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment2.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
