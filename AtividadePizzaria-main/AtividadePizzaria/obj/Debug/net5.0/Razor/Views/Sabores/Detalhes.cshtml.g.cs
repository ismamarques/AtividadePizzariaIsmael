#pragma checksum "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef95f1a7780bec1aef1db9404cf5efaf3bfb2f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sabores_Detalhes), @"mvc.1.0.view", @"/Views/Sabores/Detalhes.cshtml")]
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
#line 1 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\_ViewImports.cshtml"
using AtividadePizzariaIsmael;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\_ViewImports.cshtml"
using AtividadePizzariaIsmael.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef95f1a7780bec1aef1db9404cf5efaf3bfb2f2", @"/Views/Sabores/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"984b02c3f13204efb30569f416708b18d7fd228b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sabores_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sabor>
    #nullable disable
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
            WriteLiteral("\n<div class=\"row align-items-center\">\n<div class=\"col-md-8 offset-md-4\">\n    <div class=\"col-md-6\">\n        <h1>");
#nullable restore
#line 6 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
       Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    </div>\n    <div class=\"col-md-6\">\n        <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 214, "\"", 234, 1);
#nullable restore
#line 9 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
WriteAttributeValue("", 220, Model.FotoURL, 220, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div>\n    \n\n<br />\n    <h3>Pizzas Relacionadas</h3>\n    \n\n");
#nullable restore
#line 17 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
 if (@Model.PizzasSabores.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div id=\"carouselExampleControls\" class=\"carousel slide col-md-6 \" data-ride=\"carousel\">\n            <div class=\"carousel-inner\">\n");
#nullable restore
#line 22 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
                 foreach (var saborPizza in @Model.PizzasSabores)
                {
                    if (saborPizza == @Model.PizzasSabores.First())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef95f1a7780bec1aef1db9404cf5efaf3bfb2f27436", async() => {
                WriteLiteral("\n                                <img");
                BeginWriteAttribute("src", " src=\"", 883, "\"", 914, 1);
#nullable restore
#line 28 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
WriteAttributeValue("", 889, saborPizza.Pizza.FotoURL, 889, 25, false);

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
#line 27 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
                                                                               WriteLiteral(saborPizza.PizzaId);

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
#line 31 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef95f1a7780bec1aef1db9404cf5efaf3bfb2f210829", async() => {
                WriteLiteral("\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1273, "\"", 1304, 1);
#nullable restore
#line 36 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
WriteAttributeValue("", 1279, saborPizza.Pizza.FotoURL, 1279, 25, false);

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
#line 35 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
                                                                               WriteLiteral(saborPizza.PizzaId);

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
#line 39 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
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
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef95f1a7780bec1aef1db9404cf5efaf3bfb2f214765", async() => {
                WriteLiteral("Listar Sabores");
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
            WriteLiteral("\n");
#nullable restore
#line 55 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Sem Sabores cadastrados para ");
#nullable restore
#line 58 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"
                                Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef95f1a7780bec1aef1db9404cf5efaf3bfb2f216599", async() => {
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
#line 63 "C:\Users\ismae\OneDrive\Área de Trabalho\ProjetoPizzaria\AtividadePizzaria-main\AtividadePizzaria\Views\Sabores\Detalhes.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sabor> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591