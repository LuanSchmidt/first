﻿using Model;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TccFirst.Controllers
{
    [Route("tituloPagar/")]
    public class TituloPagarController : BaseController
    {
        private TituloPagarRepository repository;

        public TituloPagarController()
        {
            repository = new TituloPagarRepository();
        }

        #region Verificações Login
        private bool VerificaLogado()
        {
            if (Session["usuarioLogadoTipoFuncionario"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private ActionResult VerificaPermisssao()
        {
            if (VerificaLogado() == false)
            {
                return Redirect("/login");
            }

            if ((Session["usuarioLogadoTipoFuncionario"].ToString() == "Funcionario") || (Session["usuarioLogadoTipoFuncionario"].ToString() == "Gerente"))
            {
                return Redirect("/login/sempermissao");
            }
            else
            {
                return View();
            }
        }

        #endregion

        [HttpGet, Route("obterTodos")]
        public JsonResult ObterTodos()
        {
            var titulosPagar = repository.ObterTodos();
            var resultado = new { data = titulosPagar };
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpPost, Route("cadastro")]
        public ActionResult Cadastro(TituloPagar tituloPagar)
        {
            int id = repository.Inserir(tituloPagar);
            return RedirectToAction("Editar", new { id = id });
        }

        [HttpPost, Route("editar")]
        public JsonResult Editar(TituloPagar tituloPagar)
        {
            var alterou = repository.Alterar(tituloPagar);
            var resultado = new { status = alterou };
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpGet, Route("apagar")]
        public JsonResult Apagar(int id)
        {
            var apagou = repository.Apagar(id);
            var resultado = new { status = apagou };
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpGet, Route("tituloPagar")]
        public JsonResult ObterPeloId(int id)
        {
            return Json(repository.ObterPeloId(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {

            var tituloPagars = repository.ObterTodos();

            List<object> tituloPagarSelect2 =
                new List<object>();
            foreach (TituloPagar tituloPagar in tituloPagars)
            {
                tituloPagarSelect2.Add(new
                {
                    id = tituloPagar.Id,
                    descricao = tituloPagar.Descricao,
                    formaPagamento = tituloPagar.FormaPagamento,
                    caixa = tituloPagar.Caixa,
                    valorTotal = tituloPagar.ValorTotal,
                    status = tituloPagar.Status,
                    dataLancamento = tituloPagar.DataLancamento,
                    dataRecebimento = tituloPagar.DataRecebimento,
                    dataVencimento = tituloPagar.DataVencimento,
                    complemento = tituloPagar.Complemento,
                    quantidadeParcela = tituloPagar.QuantidadeParcela,
                    idFornecedores = tituloPagar.IdFornecedor,
                    idCategoriaDespesa = tituloPagar.IdCategoriaDespesa
                });
            }
            var resultado = new
            {
                results = tituloPagarSelect2
            };
            return Json(resultado,
                JsonRequestBehavior.AllowGet);
        }

        public ActionResult Cadastro()
        {
            return View();
        }



    }
}
