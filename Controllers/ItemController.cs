using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> obj = _db.Items;
            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            var obj = _db.Items.Find(id);

            if (obj==null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Update(Item obj)
        {
            if (obj==null)
            {
                return NotFound();
            }
            _db.Items.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            var obj = _db.Items.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Delete(Item obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            _db.Items.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
