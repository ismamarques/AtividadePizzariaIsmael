#pragma checksum "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb8fe19a62035cf8e47d0ea576d55431e3a1526a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tamanhos_Detalhes), @"mvc.1.0.view", @"/Views/Tamanhos/Detalhes.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\_ViewImports.cshtml"
using AtividadePizzariaIsmael;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\_ViewImports.cshtml"
using AtividadePizzariaIsmael.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb8fe19a62035cf8e47d0ea576d55431e3a1526a", @"/Views/Tamanhos/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"984b02c3f13204efb30569f416708b18d7fd228b", @"/Views/_ViewImports.cshtml")]
    public class Views_Tamanhos_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tamanho>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pizzas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Filmes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"row align-items-center\">\n<div class=\"col-md-8 offset-md-4\">   \n    <div class=\"col-md-6\">\n        <h1>");
#nullable restore
#line 6 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
       Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    </div>\n\n\n");
#nullable restore
#line 10 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
 if (@Model.Pizzas.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row \">\n        <div id=\"carouselExampleControls\" class=\"carousel slide col-md-6\" data-ride=\"carousel\">\n            <div class=\"carousel-inner\">\n");
#nullable restore
#line 15 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
                 foreach (var pizzas in @Model.Pizzas)
                {
                    if (pizzas == @Model.Pizzas.First())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8fe19a62035cf8e47d0ea576d55431e3a1526a6873", async() => {
                WriteLiteral("\n                                <img");
                BeginWriteAttribute("src", " src=\"", 703, "\"", 724, 1);
#nullable restore
#line 21 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
WriteAttributeValue("", 709, pizzas.FotoURL, 709, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-block w-100\">\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
                                                                               WriteLiteral(pizzas.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 24 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8fe19a62035cf8e47d0ea576d55431e3a1526a10271", async() => {
                WriteLiteral("\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1074, "\"", 1095, 1);
#nullable restore
#line 29 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
WriteAttributeValue("", 1080, pizzas.FotoURL, 1080, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-block w-100\">\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
                                                                               WriteLiteral(pizzas.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 32 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <button class=""carousel-control-prev"" type=""button"" data-target=""#carouselExampleControls"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-target=""#carouselExampleControls"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </button>
        </div>

    </div>
    <br />
    <div class=""col-md-3"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8fe19a62035cf8e47d0ea576d55431e3a1526a14241", async() => {
                WriteLiteral("Listar Tamanhos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 50 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Sem Tamanhos cadastrados para ");
#nullable restore
#line 53 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"
                                 Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8fe19a62035cf8e47d0ea576d55431e3a1526a16106", async() => {
                WriteLiteral("\n        <i class=\"fa-solid fa-pen-to-square\"></i>\n        Editar\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 58 "C:\Users\ismael.hmarques\Desktop\AtividadePizzariaIsmael\AtividadePizzariaIsmael\AtividadePizzariaIsmael\Views\Tamanhos\Detalhes.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tamanho> Html { get; private set; }
    }
}
#pragma warning restore 1591
