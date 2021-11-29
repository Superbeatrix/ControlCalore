using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TCC.Controllers
{
    public class LoginController : Controller
    {

        private DAL.Usuario _usuarioDAO;

        public LoginController()
        {
            _usuarioDAO = new DAL.Usuario();
        }

        public IActionResult Index()
        {
            try
            {
                string usuarioId = HttpContext.Session.GetString("usuarioId");

                if (!string.IsNullOrEmpty(usuarioId))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                    return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Login(string email, string senha)
        {
            var retorno = new Models.Util.Retorno();

            try
            {
                Models.InputModel.Usuario usuario = _usuarioDAO.ValidarUsuario(email, senha);

                if (usuario != null && usuario.UsuarioId > 0)
                {
                    HttpContext.Session.SetString("usuarioId", usuario.UsuarioId.ToString());
                    Models.Util.Usuario.Nome = usuario.Nome;

                    retorno.Sucesso = true;
                    retorno.StringRetorno = Url.Action("Index", "Home");
                    
                    return Ok(retorno); 
                }

                retorno.StringRetorno = "Usuario e/ou senha invalidos";
                return NotFound(retorno);
            }
            catch
            {
                retorno.StringRetorno = "Ocorreu um erro ao realizar o login";
                return BadRequest(retorno); 
            }
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult CadastrarUsuario(Models.InputModel.Usuario usuario)
        {
            var retorno = new Models.Util.Retorno();

            try
            {
                usuario.UsuarioId = _usuarioDAO.Cadastrar(usuario);

                if (usuario.UsuarioId > 0)
                {
                    HttpContext.Session.SetString("usuarioId", usuario.UsuarioId.ToString());
                    Models.Util.Usuario.Nome = usuario.Nome;

                    retorno.Sucesso = true;
                    retorno.StringRetorno = Url.Action("Index", "Home");

                    return Ok(retorno);
                }
                else
                {
                    retorno.StringRetorno = "Erro ao cadastrar usuario";
                    return NotFound(retorno);
                }
            }
            catch (Exception)
            {
                retorno.StringRetorno = "Erro ao cadastrar usuario";
                return BadRequest(retorno);
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("usuarioId", "");
            Models.Util.Usuario.Nome = null;

            var retorno = new Models.Util.Retorno();

            try
            {
                retorno.Sucesso = true;
                retorno.StringRetorno = Url.Action("Index", "Login");

                return Ok(retorno);
            }
            catch (Exception)
            {
                retorno.StringRetorno = "Ocorreu um erro ao realizar o login";
                return BadRequest(retorno);
            }
        }
    }
}
