#pragma checksum "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9847542c7da24fc0696c000451a80013d1f35a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Cadastrar), @"mvc.1.0.view", @"/Views/Palavra/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Cadastrar.cshtml", typeof(AspNetCore.Views_Palavra_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9847542c7da24fc0696c000451a80013d1f35a", @"/Views/Palavra/Cadastrar.cshtml")]
    public class Views_Palavra_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Cadastrar.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(28, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(55, 344, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cac4b48baead4f9ea63edcc70bd849e4", async() => {
                BeginContext(61, 331, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0 />"" />
    <title>Cadastrar</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU"" crossorigin=""anonymous"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(399, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(401, 825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28bdc36f23244e2981636c66004d4988", async() => {
                BeginContext(407, 294, true);
                WriteLiteral(@"
    <div class=""container"">
        <form method=""post"">
            <div class=""mb-4"">
                <label for=""nome"" class=""form-label"">Nome</label>
                <input type=""text"" name=""nome"" value="""" class=""form-control"" id=""nome"" placeholder=""Digite um nome"">
                ");
                EndContext();
                BeginContext(702, 30, false);
#line 19 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Cadastrar.cshtml"
           Write(Html.ValidationMessage("name"));

#line default
#line hidden
                EndContext();
                BeginContext(732, 296, true);
                WriteLiteral(@"
            </div>
            <div class=""mb-4"">
                <label for=""nivel"" class=""form-label"">Nivel</label>
                <input type=""text"" name=""nivel"" value="""" class=""form-control"" id=""nivel"" placeholder=""Digite o Nivel  1 - Facil, 2 - media, 3 - Dificil"">

                ");
                EndContext();
                BeginContext(1029, 31, false);
#line 25 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Cadastrar.cshtml"
           Write(Html.ValidationMessage("nivel"));

#line default
#line hidden
                EndContext();
                BeginContext(1060, 128, true);
                WriteLiteral("\r\n            </div>\r\n\r\n\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n        </form>\r\n        ");
                EndContext();
                BeginContext(1189, 16, false);
#line 32 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Palavra\Cadastrar.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(1205, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1226, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
