#pragma checksum "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesPersonalAseo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b477c8079207c8ba6b3fd2faf993ed03b1903b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UCS.App.Frontend.Pages.Listas.Pages_Listas_DetallesPersonalAseo), @"mvc.1.0.razor-page", @"/Pages/Listas/DetallesPersonalAseo.cshtml")]
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
#line 1 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\_ViewImports.cshtml"
using UCS.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b477c8079207c8ba6b3fd2faf993ed03b1903b2e", @"/Pages/Listas/DetallesPersonalAseo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8c5fd5d3f68e1b134cc931c292312641165c7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_DetallesPersonalAseo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h1>Detalles PersonalAseo</h1>\n<table class=\"table\">\n\n    <tr><td>Nombre:</td><td>");
#nullable restore
#line 8 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesPersonalAseo.cshtml"
                       Write(Model.PersonalAseo.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Apellido:</td> <td>");
#nullable restore
#line 9 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesPersonalAseo.cshtml"
                          Write(Model.PersonalAseo.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Identificación:</td> <td>");
#nullable restore
#line 10 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesPersonalAseo.cshtml"
                                Write(Model.PersonalAseo.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Edad:</td> <td>");
#nullable restore
#line 11 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesPersonalAseo.cshtml"
                      Write(Model.PersonalAseo.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><tr></tr>\n    <tr><td>Estado Covid:</td> <td>");
#nullable restore
#line 12 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesPersonalAseo.cshtml"
                              Write(Model.PersonalAseo.EstadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Turno</td> <td>");
#nullable restore
#line 13 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\DetallesPersonalAseo.cshtml"
                      Write(Model.PersonalAseo.turnoServicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n\n</table>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b477c8079207c8ba6b3fd2faf993ed03b1903b2e6024", async() => {
                WriteLiteral("\n                            Lista Personas\n                        ");
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
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UCS.App.Frontend.Pages.DetallesPersonalAseoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.DetallesPersonalAseoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.DetallesPersonalAseoModel>)PageContext?.ViewData;
        public UCS.App.Frontend.Pages.DetallesPersonalAseoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591