using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Context context = new Context();
            var adminInfo = context.Admins.FirstOrDefault(x=>x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);
            if (adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminInfo.AdminUserName, false);
                Session["AdminUserName"] = adminInfo.AdminUserName;
                return RedirectToAction("Index","Heading");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}