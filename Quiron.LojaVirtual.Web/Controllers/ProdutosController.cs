﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            ProdutosRepositorio _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(10);
            
            return View(produtos);
        }
    }
}