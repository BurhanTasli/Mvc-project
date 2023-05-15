using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanzHow.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            //veri tabanından bütün blog bilgileri al ve view üzerine gönder.
            //kendisine gelen blog bilgilerini dinamik içerik üreten View yapısı bunu static Html'e cevirir. 
            
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}