using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Social.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            string newDir = Server.MapPath("~/Docs") + "/Andre";
            string path;

            if(!Directory.Exists(newDir))
                Directory.CreateDirectory(newDir);
                
            path = Path.Combine(newDir,
                                       Path.GetFileName(file.FileName));

            
            file.SaveAs(path); 
            return View();
        }
    }
}