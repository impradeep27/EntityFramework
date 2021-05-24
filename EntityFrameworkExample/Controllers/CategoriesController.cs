using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories/Index
        public ActionResult Index()
        {
            EFDBFirstDatabseEntities db = new EFDBFirstDatabseEntities();
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }
    }
}