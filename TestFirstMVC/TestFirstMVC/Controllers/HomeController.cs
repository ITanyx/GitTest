using log4net;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TestFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private ILog log = LogManager.GetLogger(typeof(HomeController).FullName);

        public ContentResult LogWrite()
        {
            log.Info("这是日志信息记录");
            log.Error("这是错误信息");

            return Content("success");
        }

        public ContentResult NinjectShow()
        {
            

            return Content("success");
        }

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

        private static Dictionary<string, string> fileDictionary = new Dictionary<string, string>();
        public ActionResult Md5File(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string folder= AppDomain.CurrentDomain.BaseDirectory + "/Upload/";
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                string md5 = GetMD5HashFromFile(file.InputStream);
                if (fileDictionary.ContainsKey(md5))
                {
                    return View();
                }

                string extension = Path.GetExtension(file.FileName);
                string fileName = folder + Guid.NewGuid().ToString() + extension;
                file.SaveAs(fileName);
                fileDictionary.Add(md5, fileName);
                return null;
            }

            return View();
        }

        private static string GetMD5HashFromFile(Stream fileStream)
        {
            try
            {
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(fileStream);
                fileStream.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail, error:" +ex.Message);
            }
        }
    }
}