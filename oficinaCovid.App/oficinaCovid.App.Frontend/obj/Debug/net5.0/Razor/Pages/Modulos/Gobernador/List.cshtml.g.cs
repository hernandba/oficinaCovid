#pragma checksum "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf32174a3919a7adf59127a40bd9fb4a8798acd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(oficinaCovid.App.Frontend.Pages.Modulos.Gobernador.Pages_Modulos_Gobernador_List), @"mvc.1.0.razor-page", @"/Pages/Modulos/Gobernador/List.cshtml")]
namespace oficinaCovid.App.Frontend.Pages.Modulos.Gobernador
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
#line 1 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\_ViewImports.cshtml"
using oficinaCovid.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf32174a3919a7adf59127a40bd9fb4a8798acd9", @"/Pages/Modulos/Gobernador/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5085377276a247f3e8d37622e5515e91745a2595", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modulos_Gobernador_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Diagnostico/DiagnosticoList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Gobernador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
  
    ViewData["Title"] = "Gobernadores y asesores";
    var gobernacionid = Model.gobernacion.id;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 class=\"mb-2\">");
#nullable restore
#line 7 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
            Write(Model.gobernacion.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<div class=""table-responsive"">
    <table class=""table table-sm table-hover"">
        <thead>
            <th>Identificaci??n</th>
            <th>Nombre</th>
            <th>Rol</th>
            <th>Editar</th>
            <th>Eliminar</th>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
             foreach (var gobernador in Model.gobernadores)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                   Write(gobernador.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf32174a3919a7adf59127a40bd9fb4a8798acd96822", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                       Write(gobernador.nombres);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                                           Write(gobernador.apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-personaid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                                                                              WriteLiteral(gobernador.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personaid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-personaid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personaid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                   Write(gobernador.rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf32174a3919a7adf59127a40bd9fb4a8798acd910214", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-edit\" aria-hidden=\"true\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gobernacionid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                                                                WriteLiteral(gobernacionid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernacionid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gobernacionid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernacionid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                                                                                                        WriteLiteral(gobernador.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernadorid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gobernadorid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernadorid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf32174a3919a7adf59127a40bd9fb4a8798acd913629", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-trash-alt\" aria-hidden=\"true\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gobernacionid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                                                              WriteLiteral(gobernacionid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernacionid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gobernacionid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernacionid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                                                                                                      WriteLiteral(gobernador.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernadorid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gobernadorid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernadorid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf32174a3919a7adf59127a40bd9fb4a8798acd917334", async() => {
                WriteLiteral("Registrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gobernacionid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\herna\Desktop\MisionTIC\Ciclo3\DSoftware\oficinaCovid\oficinaCovid.App\oficinaCovid.App.Frontend\Pages\Modulos\Gobernador\List.cshtml"
                                                                     WriteLiteral(gobernacionid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernacionid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gobernacionid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gobernacionid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<oficinaCovid.App.Frontend.Pages.GobernadoresListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<oficinaCovid.App.Frontend.Pages.GobernadoresListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<oficinaCovid.App.Frontend.Pages.GobernadoresListModel>)PageContext?.ViewData;
        public oficinaCovid.App.Frontend.Pages.GobernadoresListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
