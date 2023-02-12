using BuiNgocTien_CNTT3K61_BT1_201207598.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuiNgocTien_CNTT3K61_BT1_201207598.Controllers
{
    public class HomeController : Controller
    {
        QLBanVaLiDbContext db = new QLBanVaLiDbContext();
        public ActionResult Index()
        {
            List<tDanhMucSP> p = db.tDanhMucSPs.ToList();
            List<tQuocGia> q = db.tQuocGias.ToList();
            ProductAndNation vm = new ProductAndNation
            {
                listProduct = p,
                listNation = q
            };

            return View(vm);
        }

        public ActionResult Details(string id)
        {
            var product = db.tDanhMucSPs.Find(id.Trim());
            return View(product);
        }

        public ActionResult Delete(string id)
        {
            var product = db.tDanhMucSPs.Find(id.Trim());
            if(product== null)
            {
                return HttpNotFound();
            }
            db.tDanhMucSPs.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ShowProductByCountry(string id)
        {
            List<tDanhMucSP> p = db.tDanhMucSPs.Where(product => product.MaNuocSX.Trim() == id.Trim()).ToList();
            List<tQuocGia> q = db.tQuocGias.ToList();
            ProductAndNation vm = new ProductAndNation
            {
                listProduct = p,
                listNation = q
            };
            return View(vm);
        }
    }
}