#pragma checksum "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8296ec99835d4a442cf912bc67326535bf40f55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Index), @"mvc.1.0.view", @"/Views/Palavra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Index.cshtml", typeof(AspNetCore.Views_Palavra_Index))]
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
#line 2 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8296ec99835d4a442cf912bc67326535bf40f55", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<sistemadebancodepalavras.Models.Palavra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(123, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
  
    //Layout  = "_Layout";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
  
    ViewBag.Title = "Palavra - Listagem";

#line default
#line hidden
            BeginContext(237, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(280, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(341, 20, false);
#line 18 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(361, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
}

#line default
#line hidden
            BeginContext(378, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(384, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "626cfe81f9254ecf95a756be8bd75626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(453, 101, true);
            WriteLiteral("\r\n<a href=\"/palavra/cadastrar\" class=\"btn btn-dark\">Cadastrar</a>\r\n<span><b>Total de registros: </b> ");
            EndContext();
            BeginContext(555, 20, false);
#line 26 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
                             Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(575, 285, true);
            WriteLiteral(@"</span>
<br />
<table class=""table"">
    <thead class=""table-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Palavra</th>
            <th scope=""col"">Nivel</th>
            <th scope=""col"">A????o</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 38 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
         foreach (var palavra in Model)
        {



#line default
#line hidden
            BeginContext(916, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(967, 10, false);
#line 43 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
                           Write(palavra.Id);

#line default
#line hidden
            EndContext();
            BeginContext(977, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(1005, 12, false);
#line 44 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
               Write(palavra.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1045, 13, false);
#line 45 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
               Write(palavra.Nivel);

#line default
#line hidden
            EndContext();
            BeginContext(1058, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1109, "\"", 1146, 2);
            WriteAttributeValue("", 1116, "/palavra/atualizar/", 1116, 19, true);
#line 47 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1135, palavra.Id, 1135, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1147, 47, true);
            WriteLiteral(" class=\"btn\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1229, 2);
            WriteAttributeValue("", 1201, "/palavra/excluir/", 1201, 17, true);
#line 48 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1218, palavra.Id, 1218, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1230, 70, true);
            WriteLiteral(" class=\"btn\">Excluir</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1311, 28, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1340, 81, false);
#line 57 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<sistemadebancodepalavras.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
