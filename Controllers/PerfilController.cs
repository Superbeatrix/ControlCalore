using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TCC.Controllers
{
    public class PerfilController : Controller
    {
        private DAL.Usuario _usuario;

        public PerfilController()
        {
            _usuario = new DAL.Usuario();
        }

        public IActionResult Index()
        {
            long usuarioId = long.Parse(HttpContext.Session.GetString("usuarioId"));

            try
            {
                Models.InputModel.Usuario usuario = _usuario.BuscarPerfilUsuario(usuarioId);
                return View(usuario);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IActionResult AtualizaDadosUsuario(Models.InputModel.Usuario usuario)
        {
            usuario.UsuarioId = long.Parse(HttpContext.Session.GetString("usuarioId"));
            Models.Util.Retorno retorno = new Models.Util.Retorno();

            try
            {
                bool sucesso = _usuario.AtualizaDadosUsuario(usuario);

                if (sucesso)
                {
                    retorno.Sucesso = true;
                    retorno.StringRetorno = "Dados atualizados com sucesso.";
                    return Ok(retorno);
                }
                else
                {
                    retorno.StringRetorno = "Erro ao atualizar usuario";
                    return NotFound();
                }
            }
            catch
            {
                retorno.StringRetorno = "Erro ao atualizar usuario";
                return BadRequest();
            }
        }

        public IActionResult BuscaNomeUsuario()
        {
            Models.Util.Retorno retorno = new Models.Util.Retorno();

            try
            {
                long usuarioId = long.Parse(HttpContext.Session.GetString("usuarioId"));
                string nomeUsuario = _usuario.GetNomeUsuario(usuarioId);

                if (usuarioId > 0)
                {
                    ViewBag.Title = nomeUsuario;
                    return Ok(retorno);
                }
                else
                {
                    retorno.StringRetorno = "Erro usuario";
                    return NotFound();
                }
            }
            catch
            {
                retorno.StringRetorno = "Erro usuario";
                return BadRequest();
            }
        }
    }
}
