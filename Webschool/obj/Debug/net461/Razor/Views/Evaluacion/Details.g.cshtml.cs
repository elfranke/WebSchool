#pragma checksum "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421763e6ce28250c8934a27970d9cbbd9ade1861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluacion_Details), @"mvc.1.0.view", @"/Views/Evaluacion/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evaluacion/Details.cshtml", typeof(AspNetCore.Views_Evaluacion_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421763e6ce28250c8934a27970d9cbbd9ade1861", @"/Views/Evaluacion/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b334e8bb33f0b6bd1b2a012482d9e8692c2d64", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluacion_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Webschool.Models.Evaluaciones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Evaluaciones</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(210, 48, false);
#line 14 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEvaluacion));

#line default
#line hidden
            EndContext();
            BeginContext(258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(302, 44, false);
#line 17 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEvaluacion));

#line default
#line hidden
            EndContext();
            BeginContext(346, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(390, 48, false);
#line 20 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstudiante));

#line default
#line hidden
            EndContext();
            BeginContext(438, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(482, 44, false);
#line 23 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEstudiante));

#line default
#line hidden
            EndContext();
            BeginContext(526, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(570, 46, false);
#line 26 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estudiante));

#line default
#line hidden
            EndContext();
            BeginContext(616, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(660, 42, false);
#line 29 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estudiante));

#line default
#line hidden
            EndContext();
            BeginContext(702, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(746, 45, false);
#line 32 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdSeccion));

#line default
#line hidden
            EndContext();
            BeginContext(791, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(835, 41, false);
#line 35 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdSeccion));

#line default
#line hidden
            EndContext();
            BeginContext(876, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(920, 47, false);
#line 38 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdIndicador));

#line default
#line hidden
            EndContext();
            BeginContext(967, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1011, 43, false);
#line 41 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdIndicador));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1098, 45, false);
#line 44 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Indicador));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1187, 41, false);
#line 47 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Indicador));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1272, 45, false);
#line 50 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1361, 41, false);
#line 53 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdMateria));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1446, 43, false);
#line 56 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1533, 39, false);
#line 59 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Materia));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1616, 45, false);
#line 62 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdPeriodo));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1705, 41, false);
#line 65 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdPeriodo));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1790, 43, false);
#line 68 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1877, 39, false);
#line 71 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1960, 41, false);
#line 74 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2045, 37, false);
#line 77 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Grado));

#line default
#line hidden
            EndContext();
            BeginContext(2082, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2126, 47, false);
#line 80 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2217, 43, false);
#line 83 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2304, 41, false);
#line 86 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2389, 37, false);
#line 89 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(2426, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2474, 68, false);
#line 94 "C:\Users\LENOVO\source\repos\Webschool\Webschool\Views\Evaluacion\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2542, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2550, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b526d481e0e4709b0ed9d1ccf0d1611", async() => {
                BeginContext(2572, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2588, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webschool.Models.Evaluaciones> Html { get; private set; }
    }
}
#pragma warning restore 1591
