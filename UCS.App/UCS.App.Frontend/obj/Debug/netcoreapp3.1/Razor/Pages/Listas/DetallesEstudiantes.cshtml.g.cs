#pragma checksum "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c823307b2374985297a151f22235aafe1560ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UCS.App.Frontend.Pages.Listas.Pages_Listas_DetallesEstudiantes), @"mvc.1.0.razor-page", @"/Pages/Listas/DetallesEstudiantes.cshtml")]
namespace UCS.App.Frontend.Pages.Listas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\_ViewImports.cshtml"
using UCS.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c823307b2374985297a151f22235aafe1560ddf", @"/Pages/Listas/DetallesEstudiantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80c648aa65a011f36a118bf2bcc9d747325a648a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_DetallesEstudiantes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Personas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<h1>Detalles Estudiantes</h1>\r\n<table class=\"table\">\r\n\r\n    <tr><td>Nombre:</td><td>");
#nullable restore
#line 8 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml"
                       Write(Model.Estudiante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    <tr><td>Apellido:</td> <td>");
#nullable restore
#line 9 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml"
                          Write(Model.Estudiante.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    <tr><td>Identificación:</td> <td>");
#nullable restore
#line 10 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml"
                                Write(Model.Estudiante.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    <tr><td>Edad:</td> <td>");
#nullable restore
#line 11 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml"
                      Write(Model.Estudiante.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><tr></tr>\r\n    <tr><td>Estado Covid:</td> <td>");
#nullable restore
#line 12 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml"
                              Write(Model.Estudiante.EstadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    <tr><td>Carrera:</td> <td>");
#nullable restore
#line 13 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml"
                         Write(Model.Estudiante.carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    <tr><td>Semestre:</td> <td>");
#nullable restore
#line 14 "C:\Users\docentes\Documents\misionTIC\ciclo 3\desarrollo software\semana 5\ProyectoSalonesSegundoSprint\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesEstudiantes.cshtml"
                          Write(Model.Estudiante.Semestre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c823307b2374985297a151f22235aafe1560ddf6611", async() => {
                WriteLiteral("\r\n                            Lista Personas\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UCS.App.Frontend.Pages.DetallesEstudiantesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.DetallesEstudiantesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.DetallesEstudiantesModel>)PageContext?.ViewData;
        public UCS.App.Frontend.Pages.DetallesEstudiantesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
