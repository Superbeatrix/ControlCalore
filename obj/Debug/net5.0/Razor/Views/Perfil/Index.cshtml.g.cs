#pragma checksum "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a982c6d3c1c66ef26b248977efcec86e1638be39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a982c6d3c1c66ef26b248977efcec86e1638be39", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a825c10329dbec4e5fb3ac68985bdf6a4adf8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCC.Models.InputModel.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main class=""content"">
    <div class=""container-fluid p-0"">
        <div class=""row"">
            <div class=""col-md-4 col-xl-3"">
                <div class=""card mb-3"">
                    <div class=""card-header"">
                        <h5 class=""card-title mb-0"">Detalhes do perfil</h5>
                    </div>
                    <div class=""card-body text-center"">
                        <img src=""img/avatars/avatar.png"" alt=""Christina Mason"" class=""img-fluid rounded-circle mb-2"" width=""128"" height=""128"">
                        <h5 class=""card-title mb-0"">");
#nullable restore
#line 17 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
                                               Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <div class=\"text-muted mb-2\">Aniversário: ");
#nullable restore
#line 18 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
                                                             Write(Model.DataNascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div>

            <div class=""col-md-8 col-xl-9"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h5 class=""card-title mb-0"">Activities</h5>
                    </div>
                    <div class=""card-body h-100"">
                        <div class=""d-flex align-items-start"">
                            <div class=""input-group"">
                                <span class=""input-group-text"" id=""basic-addon1"">Email</span>
                                <input type=""text"" class=""form-control"" id=""email"" placeholder=""Email"" aria-label=""Email"" aria-describedby=""basic-addon1""");
            BeginWriteAttribute("value", " value=\"", 1519, "\"", 1539, 1);
#nullable restore
#line 32 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 1527, Model.Email, 1527, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div style=""width:100px;""></div>
                            <div class=""input-group"">
                                <span class=""input-group-text"" id=""basic-addon2"">Senha</span>
                                <input type=""text"" class=""form-control"" id=""senha"" placeholder=""Senha"" aria-label=""Senha"" aria-describedby=""basic-addon2""");
            BeginWriteAttribute("value", " value=\"", 1944, "\"", 1964, 1);
#nullable restore
#line 37 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 1952, Model.Senha, 1952, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>

                    <div class=""card-body h-100"">
                        <div class=""d-flex align-items-start"">
                            <div class=""input-group"">
                                <span class=""input-group-text"" id=""limiteDiarioSpan"">Diario</span>
                                <input type=""text"" class=""form-control"" id=""limiteDiario"" placeholder=""Definir Limite de calorias Diarias..."" aria-label=""Email"" aria-describedby=""limiteDiarioSpan""");
            BeginWriteAttribute("value", " value=\"", 2532, "\"", 2565, 1);
#nullable restore
#line 46 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 2540, Model.QtdCaloriasDiarias, 2540, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div style=""width:100px;""></div>
                            <div class=""input-group"">
                                <span class=""input-group-text"" id=""limiteSemanalSpan"">Semanal</span>
                                <input type=""text"" class=""form-control"" id=""limiteSemanal"" placeholder=""Definir Limite de calorias Semanal..."" aria-label=""Senha"" aria-describedby=""limiteSemanalSpan""");
            BeginWriteAttribute("value", " value=\"", 3022, "\"", 3056, 1);
#nullable restore
#line 51 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
WriteAttributeValue("", 3030, Model.QtdCaloriasSemanais, 3030, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""d-flex justify-content-end"" onclick=""salvarDadosPerfil()"">
                    <button class=""btn btn-primary"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-save align-middle me-2""><path d=""M19 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h11l5 5v11a2 2 0 0 1-2 2z""></path><polyline points=""17 21 17 13 7 13 7 21""></polyline><polyline points=""7 3 7 8 15 8""></polyline></svg>
                        Salvar
                    </button>
                </div>

            </div>
        </div>
    </div>
</main>

<script>
    function salvarDadosPerfil() {

        let email = $('#email').val();
        let senha = $('#senha').val();

        if (email == """" || email == null ||");
            WriteLiteral(@" email == undefined) {
            mostrarAlerta(""Atenção"", ""Digite o email"", ""warning"");
        }
        else if (senha == """" || senha == null || senha == undefined) {
            mostrarAlerta(""Atenção"", ""Digite a senha"", ""warning"");
        }
        else {
            $.ajax({
                url: """);
#nullable restore
#line 83 "C:\Users\bea\Documents\ControlCalore\TCC\TCC\Views\Perfil\Index.cshtml"
                 Write(Url.Action("AtualizaDadosUsuario", "Perfil"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                //type: 'post',
                data: {
                    email: $('#email').val(),
                    senha: $('#senha').val(),
                    qtdCaloriasDiarias: $('#limiteDiario').val(),
                    qtdCaloriasSemanais: $('#limiteSemanal').val(),
                },
                beforeSend: function () {

                },
                success: function (data) {
                    mostrarAlerta(""Sucesso"", data.stringRetorno, ""success"");
                },
                error: function (error) {
                    mostrarAlerta(""Erro"", ""Ocorreu um erro"", ""error"");
                    console.log(error)
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCC.Models.InputModel.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591