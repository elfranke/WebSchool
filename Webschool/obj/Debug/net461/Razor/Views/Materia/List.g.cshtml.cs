#pragma checksum "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02fa7bb3c71671e7ceaca65a68807faf615ccf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Materia_List), @"mvc.1.0.view", @"/Views/Materia/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Materia/List.cshtml", typeof(AspNetCore.Views_Materia_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02fa7bb3c71671e7ceaca65a68807faf615ccf9", @"/Views/Materia/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b334e8bb33f0b6bd1b2a012482d9e8692c2d64", @"/Views/_ViewImports.cshtml")]
    public class Views_Materia_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webschool.Models.Materias>>
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(89, 28, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(117, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ebde75b4e3461abf706ff4eeaf6586", async() => {
                BeginContext(140, 10, true);
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
            BeginContext(154, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(247, 45, false);
#line 16 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 43, false);
#line 19 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(391, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(447, 41, false);
#line 22 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(488, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(606, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(655, 44, false);
#line 31 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(699, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(755, 42, false);
#line 34 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(853, 40, false);
#line 37 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(893, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(949, 65, false);
#line 40 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1035, 71, false);
#line 41 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1127, 69, false);
#line 42 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Materia\List.cshtml"
}

#line default
#line hidden
            BeginContext(1235, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Webschool.Models.Materias>> Html { get; private set; }
    }
}
#pragma warning restore 1591
