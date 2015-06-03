using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using PagedList;
using PagedList.Mvc;
using System.Data.Entity.Infrastructure;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index(int page = 1)
        {
            return View(db.Posts.OrderByDescending(v => v.post_Id).ToPagedList(page, 3));
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Include(s => s.Images).SingleOrDefault(s => s.post_Id == id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}