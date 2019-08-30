﻿using Model;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TccFirst.Controllers
{
    public class CategoriaReceitaController : Controller
    {
        private CategoriaReceitaRepository repository;

        public CategoriaReceitaController()
        {
            repository = new CategoriaReceitaRepository
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Inserir(CategoriaReceita categoriaReceita)
        {
            categoriaReceita.RegistroAtivo = true;
            var id = repository.Inserir(categoriaReceita);
            var resultado = new { id = id };
            return Json(resultado);
        }

        [HttpGet]
        public JsonResult ObterTodos()
        {
            var categorias = repository.ObterTodos();
            var resultado = new { data = categorias };
            return Json(resultado, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public JsonResult Apagar(int id)
        {
            var apagou = repository.Apagar(id);
            var resultado = new { status = apagou };
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Update (CategoriaReceita categoriaReceita)
        {
            var alterou = repository.Alterar(categoriaReceita);
            var resultado = new { status = alterou };
            return Json(resultado);
        }
    }
}