using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestePartialView.Models;

namespace TestePartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestPartialView(int id)
        {
            List<Teste> list = new List<Teste>();

            Teste teste = new Teste();
            teste.Id = 1;
            teste.Name = "BLÁ BLÁ BLÁ";
            teste.SurName = "PARTIAL VIEW TEST";

            list.Add(teste);

            teste = new Teste();
            teste.Id = 2;
            teste.Name = "FULANO";
            teste.SurName = "DA SILVA";

            list.Add(teste);

            var resultado = list.Where(i => i.Id == id).FirstOrDefault();

            return PartialView("_Teste", resultado);
        }
    }
}