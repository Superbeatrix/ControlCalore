using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TCC.Controllers
{
    public class HomeController : Controller
    {
        private DAL.UsuarioAlimento _usuarioAlimento;
        private DAL.Alimento _alimento;

        public HomeController()
        {
            _usuarioAlimento = new DAL.UsuarioAlimento();
            _alimento = new DAL.Alimento();
        }

        public IActionResult Index()
        {
            string usuarioId = HttpContext.Session.GetString("usuarioId");
            //usuarioId = "1";

            if (!string.IsNullOrEmpty(usuarioId))
            {
                return View();
            }
            
            return RedirectToAction("Index", "Login");
        }

        public IActionResult BuscaDadosHome()
        {
            long usuarioId = long.Parse(HttpContext.Session.GetString("usuarioId"));

            try
            {
                Models.ViewModel.UsuarioHome retorno = new Models.ViewModel.UsuarioHome();

                retorno.LimiteDiario = _usuarioAlimento.GetCaloriasDiarias(usuarioId);
                retorno.LimiteSemanal = _usuarioAlimento.GetCaloriasSemanais(usuarioId);
                retorno.CaloriasHoje = _usuarioAlimento.GetCaloriasHoje(usuarioId);
                retorno.CaloriasOntem = _usuarioAlimento.GetCaloriasOntem(usuarioId);
                retorno.AlimentosConsumidosHoje = _usuarioAlimento.GetAlimentosConsumidosHoje(usuarioId);

                return Json(retorno);
            }
            catch
            {
                return BadRequest();
            }
        }

        //Buscar Alimentos para cadastrar
        public IActionResult BuscaAlimento(string nomeAlimento)
        {
            try
            {
                List<Models.InputModel.Alimento> retorno = _alimento.BuscarAlimentosPorNome(nomeAlimento);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest();
            }
        }

        //Cadastrar um alimento
        public IActionResult CadastrarAlimentoUsuario(long alimentoId, int quantidade, string observacao)
        {
            long usuarioId = long.Parse(HttpContext.Session.GetString("usuarioId"));
            Models.Util.Retorno retorno = new Models.Util.Retorno();
            
            try
            {
                long alimentoUsuarioId = _usuarioAlimento.CadastrarAlimentoUsuario(usuarioId, alimentoId, quantidade, observacao);
                
                if (alimentoUsuarioId > 0)
                {
                    retorno.Sucesso = true;
                    retorno.StringRetorno = "Alimento consumido cadastrado";

                    return Ok(retorno);
                }
                else
                {
                    retorno.StringRetorno = "Ocorreu um erro ao cadastrar";
                    return NotFound(retorno);
                }
            }
            catch
            {
                retorno.StringRetorno = "Ocorreu um erro ao cadastrar";
                return BadRequest(retorno);
            }
        }

        public IActionResult ExcluirAlimentoUsuario(long alimentoUsuarioId)
        {
            long usuarioId = long.Parse(HttpContext.Session.GetString("usuarioId"));
            Models.Util.Retorno retorno = new Models.Util.Retorno();

            try
            {
                bool sucesso = _usuarioAlimento.ExcluirAlimentoUsuario(alimentoUsuarioId);
                if (sucesso)
                {
                    retorno.Sucesso = true;
                    retorno.StringRetorno = "Alimento excluido com sucesso";
                    return Ok(retorno);
                }
                else
                {
                    retorno.StringRetorno = "Erro ao excluir alimento";
                    return NotFound(retorno);
                }
            }
            catch
            {
                retorno.StringRetorno = "Erro ao excluir alimento";
                return BadRequest(retorno);
            }
        }
    }
}
