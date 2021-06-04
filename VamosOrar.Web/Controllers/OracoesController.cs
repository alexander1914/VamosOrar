using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VamosOrar.Data.Models;
using VamosOrar.Data.Services;

namespace VamosOrar.Web.Controllers
{
    public class OracoesController : Controller
    {
        private readonly IPedidosOracoesData db;

        public OracoesController(IPedidosOracoesData db)
        {
            this.db = db;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.GetById(id);
            return View(model); 
        }

        [HttpGet]
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidosOracoes pedidosOracoes)
        {            
            if (ModelState.IsValid)
            {
                db.Add(pedidosOracoes);
                //TempData["Message"] = "Seu pedido de oração foi salvo com sucesso";                
                return RedirectToAction("Index");
            }            
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.GetById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PedidosOracoes pedidosOracoes)
        {
            
            if (ModelState.IsValid)
            {
                db.Update(pedidosOracoes);
                return RedirectToAction("Index");
                //TempData["Message"] = "Seu pedido de oração alterado com sucesso";
            }
            return View(pedidosOracoes);
            
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.GetById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection formCollection)
        {
            db.Delete(id);
            return RedirectToAction("Index");
            //TempData["Message"] = "Seu pedido de oração foi apagado com sucesso";
        }
    }
}