﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class productController : Controller
    {
        // GET: product
        private NeptunoEntities db = new NeptunoEntities();
        public ActionResult Index()
        {
            return View(db.productos.ToList());
        }

        // GET: clientes/Producto
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idProducto,nombreProducto,cantidadPorUnidad,precioUnidad,unidadesEnExistencia,unidadesEnPedido,nivelNuevoPedido")] productos productos)
        {
            if (ModelState.IsValid)
            {
                db.productos.Add(productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productos);
        }
    }


}