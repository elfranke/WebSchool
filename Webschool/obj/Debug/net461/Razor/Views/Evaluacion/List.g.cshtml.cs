#pragma checksum "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e280ee29984afde68e37501473ab2ca7de6a2efc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluacion_List), @"mvc.1.0.view", @"/Views/Evaluacion/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evaluacion/List.cshtml", typeof(AspNetCore.Views_Evaluacion_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e280ee29984afde68e37501473ab2ca7de6a2efc", @"/Views/Evaluacion/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b334e8bb33f0b6bd1b2a012482d9e8692c2d64", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluacion_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webschool.Models.Evaluaciones>>
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(93, 28, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126ad1a702c5479cb845224df5a18982", async() => {
                BeginContext(144, 10, true);
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
            BeginContext(158, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 48, false);
#line 16 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEvaluacion));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 48, false);
#line 19 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstudiante));

#line default
#line hidden
            EndContext();
            BeginContext(403, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(459, 46, false);
#line 22 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Estudiante));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 45, false);
#line 25 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdSeccion));

#line default
#line hidden
            EndContext();
            BeginContext(606, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(662, 47, false);
#line 28 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdIndicador));

#line default
#line hidden
            EndContext();
            BeginContext(709, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(765, 45, false);
#line 31 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Indicador));

#line default
#line hidden
            EndContext();
            BeginContext(810, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(866, 45, false);
#line 34 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(911, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(967, 43, false);
#line 37 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1066, 45, false);
#line 40 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPeriodo));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1167, 43, false);
#line 43 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1266, 41, false);
#line 46 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1363, 47, false);
#line 49 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1466, 41, false);
#line 52 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 58 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1625, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1674, 47, false);
#line 61 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEvaluacion));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1777, 47, false);
#line 64 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstudiante));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1880, 45, false);
#line 67 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estudiante));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1981, 44, false);
#line 70 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdSeccion));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2081, 46, false);
#line 73 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdIndicador));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2183, 44, false);
#line 76 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Indicador));

#line default
#line hidden
            EndContext();
            BeginContext(2227, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2283, 44, false);
#line 79 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2383, 42, false);
#line 82 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2481, 44, false);
#line 85 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdPeriodo));

#line default
#line hidden
            EndContext();
            BeginContext(2525, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2581, 42, false);
#line 88 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(2623, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2679, 40, false);
#line 91 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(2719, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2775, 46, false);
#line 94 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2877, 40, false);
#line 97 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(2917, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2973, 65, false);
#line 100 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3038, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3059, 71, false);
#line 101 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3130, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3151, 69, false);
#line 102 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3220, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 105 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\List.cshtml"
}

#line default
#line hidden
            BeginContext(3259, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Webschool.Models.Evaluaciones>> Html { get; private set; }
    }
}
#pragma warning restore 1591