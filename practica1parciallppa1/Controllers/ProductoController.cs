using practica1parciallppa1.Business;
using practica1parciallppa1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practica1parciallppa1.Controllers
{
    public class ProductoController : Controller
    {
        ProductoBiz productoBiz = new ProductoBiz();

        // GET: Producto
        public ActionResult Index()
        {
            var lista = productoBiz.Listar();
           
            return View(lista);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Producto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            productoBiz.Agregar(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var producto = productoBiz.Get(id);
            if(producto == null)
            {
                return View();
            }

            return View(producto);
        }
        [HttpPost]
        public ActionResult Edit(Producto model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }

            productoBiz.Update(model);

            return RedirectToAction("Index");
        }
        //por defecto es GET
        public ActionResult Delete(int id)
        {
            var producto = productoBiz.Get(id);
            if (producto == null)
            {
                return View();
            }

            return View(producto);
        }

        [HttpPost]
        public ActionResult Delete(Producto model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }

            productoBiz.Eliminar(model);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var producto = productoBiz.Get(id);
            if(producto == null)
            {
                return View();
            }

            return View(producto);
        }
    }
}