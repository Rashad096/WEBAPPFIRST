using Microsoft.AspNetCore.Mvc;

namespace FirstAppProject1.Controllers
{
    public class UserController : Controller
    {
        public ViewResult Profile()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Profile";
            return view;
        }


        public ActionResult GetId(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = "User: " + id;
            //return result;
           
            return View(); 

        }


    }
}