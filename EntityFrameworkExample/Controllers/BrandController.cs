using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand/index
        public ActionResult Index()
        {
            EFDBFirstDatabseEntities db = new EFDBFirstDatabseEntities();
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
    }
}