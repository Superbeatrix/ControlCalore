#pragma checksum "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237acae605dc1e98d94fcb2ef4289103ebaf1ca9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\_ViewImports.cshtml"
using TCC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\_ViewImports.cshtml"
using TCC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237acae605dc1e98d94fcb2ef4289103ebaf1ca9", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a825c10329dbec4e5fb3ac68985bdf6a4adf8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "_LayoutLogin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""d-flex w-100"">
    <div class=""container d-flex flex-column"">
        <div class=""row vh-100"">
            <div class=""col-sm-10 col-md-8 col-lg-6 mx-auto d-table h-100"">
                <div class=""d-table-cell align-middle"">

                    <div class=""text-center mt-4"">
                        <h1 class=""h2"">Entrar</h1>
                        <p class=""lead"">
                            Faça login em sua conta para continuar
                        </p>
                    </div>

                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""m-sm-4"">
");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "237acae605dc1e98d94fcb2ef4289103ebaf1ca94137", async() => {
                WriteLiteral(@"
                                    <div class=""mb-3"">
                                        <label class=""form-label"">Email</label>
                                        <input class=""form-control form-control-lg"" id=""email"" type=""email"" name=""email"" placeholder=""Digite Seu Email email"" />
                                    </div>
                                    <div class=""mb-3"">
                                        <label class=""form-label"">Senha</label>
                                        <input class=""form-control form-control-lg"" id=""senha"" type=""password"" name=""password"" placeholder=""Digite sua senha"" />
");
                WriteLiteral("                                    </div>\r\n");
                WriteLiteral("                                    <div class=\"text-center mt-3\">\r\n");
                WriteLiteral(@"                                        <button type=""button"" class=""btn btn-lg btn-primary"" onclick=""login()"">Login</button>
                                        <br />
                                        <br />
                                        <a href=""Login/Registrar"">Registre-se</a>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</main>

<script>
    function login() {
        let email = $('#email').val();
        let senha = $('#senha').val();

        if (email == """" || email == null || email == undefined) {
            mostrarAlerta(""Atenção"", ""Preencha o email"", ""warning"");
        }
        else if (senha == """" || senha == null || senha == undefined) {
            mostrarAlerta(""Atenção"", ""Preencha a senha"", ""warning"");
        }
        else {
            $.ajax({
            url: """);
#nullable restore
#line 76 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Login\Index.cshtml"
             Write(Url.Action("Login", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            type: 'post',
            data: {
                email: $('#email').val(),
                senha: $('#senha').val()
            },
            beforeSend: function () {

            },
            success: function (data) {
                window.location.href = data.stringRetorno;
            }
        })
        }
    }
</script>");
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