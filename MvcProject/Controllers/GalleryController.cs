using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager imageManager = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var values = imageManager.GetList();
            return View(values);
        }
    }
}