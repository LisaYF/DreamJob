using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        //--------------------------
        [AcceptVerbs(HttpVerbs.Post)]
        public ContentResult Import(HttpPostedFileBase FileData, string folder)
        {
            int ret = 0;
            string result = "";
            if (null != FileData)
            {
                try
                {
                    result = Path.GetFileName(FileData.FileName);//获得文件名
                    string ext = Path.GetExtension(FileData.FileName);//获得文件扩展名
                    string saveName = result;//实际保存文件名
                    saveFile(FileData, folder, saveName);//保存文件
                    ret = 1;
                }
                catch
                {
                    ret = 0;
                }
            }
            return Content(ret.ToString());
        }

        [NonAction]
        private void saveFile(HttpPostedFileBase postedFile, string filepath, string saveName)
        {
            string phyPath = Request.MapPath("~" + filepath + "/");
            if (!Directory.Exists(phyPath))
            {
                Directory.CreateDirectory(phyPath);
            }
            try
            {
                postedFile.SaveAs(phyPath + saveName);
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);

            }
        }
        //----------------------------------
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
        private Tcontext db = new Tcontext();
        [Authorize]
        public ActionResult JAVA()
        {
            ViewBag.Message = "Your contact page.";
            var teachers = db.Teachers.Where(p => p.Tsubject == "Java").Select(p=>p.Tname).ToList();
            ViewBag.Teachers = teachers;
            return View();
        }
       
        [Authorize]
        public ActionResult NET()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }
    }
}