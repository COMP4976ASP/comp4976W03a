using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP4976_Lab02.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            return View(files);
        }

        public ActionResult MyContent(string id)
        {
            string fileContent = "";
            try
            {
                fileContent = System.IO.File.ReadAllText(Server.MapPath("~/TextFiles/" + id + ".txt"));
            }
            catch
            {
                Console.WriteLine("Cannot open file");
            }
            return View((object)fileContent);
        }
    }
}