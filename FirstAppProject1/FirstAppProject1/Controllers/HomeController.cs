using Microsoft.AspNetCore.Mvc;

namespace FirstAppProject1.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            //ViewResult html = new ViewResult();
            //html.ViewName = "Index";
            //return html;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }
    }
}
