using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace FirstAppProject1.Controllers
{
   public class ProductController:Controller
    {
        //public ContentResult GetInfo()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Product Info";
        //    return result;
        //}


        public JsonResult GetInfo()
        {
            //JsonResult result = new JsonResult(new { Name = "Iphone", Price = 2500 });
            //return result;
            return Json(new { Name = "Iphone", Price = 2500 });
        }

        public ViewResult Detail()
        {
            //ViewResult result = new ViewResult();
            //result.ViewName = "detail";
            //return result;

            return View(); 
        }


        //public ContentResult GetInfo(string brand,int bolum)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Kurtlar Vadisi- brand: " +brand + "bolum: "+bolum;
        //        return result;
        //}


        public JsonResult GetInfo(string brand,string category,decimal price)
        {
            //JsonResult result = new JsonResult(new { brand = brand, category = category, Saleprice = price });
            //return result;
            return Json(new { brand = brand, category = category, Saleprice = price });
        }
    }
}
 