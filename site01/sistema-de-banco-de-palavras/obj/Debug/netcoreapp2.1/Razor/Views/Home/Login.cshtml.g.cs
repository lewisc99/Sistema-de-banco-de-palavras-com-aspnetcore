#pragma checksum "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf5a5b7ecdccf0d2205f8b9b98a0862b1a97ee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf5a5b7ecdccf0d2205f8b9b98a0862b1a97ee7", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<sistemadebancodepalavras.Models.Palavra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Home\Login.cshtml"
   //Layou = "_la
    Layout = "_Layout";

#line default
#line hidden
#line 6 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
            BeginContext(140, 251, true);
            WriteLiteral("\r\n<form method=\"post\" action=\"/home/login\">\r\n    <div class=\"mb-4\">\r\n        <label for=\"email\" class=\"form-label\">Email</label>\r\n        <input type=\"text\" name=\"email\" value=\"\" class=\"form-control\" id=\"email\" placeholder=\"Digite seu emal\">\r\n        ");
            EndContext();
            BeginContext(392, 31, false);
#line 14 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Home\Login.cshtml"
   Write(Html.ValidationMessage("email"));

#line default
#line hidden
            EndContext();
            BeginContext(423, 223, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"mb-4\">\r\n        <label for=\"senha\" class=\"form-label\">Senha</label>\r\n        <input type=\"text\" name=\"senha\" value=\"\" class=\"form-control\" id=\"senha\" placeholder=\"Digite sua senha\">\r\n\r\n        ");
            EndContext();
            BeginContext(647, 31, false);
#line 20 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Home\Login.cshtml"
   Write(Html.ValidationMessage("senha"));

#line default
#line hidden
            EndContext();
            BeginContext(678, 96, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n</form>\r\n");
            EndContext();
            BeginContext(775, 16, false);
#line 27 "C:\Users\Pichau\Desktop\Asp\site01\sistema-de-banco-de-palavras\Views\Home\Login.cshtml"
Write(ViewBag.Mensagem);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<sistemadebancodepalavras.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
