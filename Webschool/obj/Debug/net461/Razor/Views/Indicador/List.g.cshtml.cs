#pragma checksum "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "652c70d34db37a6bff72f6a957d010c55d483c17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Indicador_List), @"mvc.1.0.view", @"/Views/Indicador/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Indicador/List.cshtml", typeof(AspNetCore.Views_Indicador_List))]
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
#line 1 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\_ViewImports.cshtml"
using Webschool;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\_ViewImports.cshtml"
using Webschool.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"652c70d34db37a6bff72f6a957d010c55d483c17", @"/Views/Indicador/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b334e8bb33f0b6bd1b2a012482d9e8692c2d64", @"/Views/_ViewImports.cshtml")]
    public class Views_Indicador_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webschool.Models.Indicadores>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(92, 28, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(120, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e803790457543109a36a6597ac3fa83", async() => {
                BeginContext(143, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 47, false);
#line 16 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdIndicador));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 45, false);
#line 19 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Indicador));

#line default
#line hidden
            EndContext();
            BeginContext(398, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(454, 41, false);
#line 22 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 45, false);
#line 25 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(596, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(714, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(763, 46, false);
#line 34 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdIndicador));

#line default
#line hidden
            EndContext();
            BeginContext(809, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 44, false);
#line 37 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Indicador));

#line default
#line hidden
            EndContext();
            BeginContext(909, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(965, 40, false);
#line 40 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1061, 44, false);
#line 43 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1161, 65, false);
#line 46 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1247, 71, false);
#line 47 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1339, 69, false);
#line 48 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Indicador\List.cshtml"
}

#line default
#line hidden
            BeginContext(1447, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Webschool.Models.Indicadores>> Html { get; private set; }
    }
}
#pragma warning restore 1591
