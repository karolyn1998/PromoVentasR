using  PromoVentas.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PromoVentasR.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var ProductosBL = new ProductosBL();
            var listadeProductos = ProductosBL.ObtenerProductos();


            return View(listadeProductos);
        }
    }
}