using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieInfo.Models;
using MovieInfo.AppDbContext;
using Microsoft.AspNetCore.Authorization;
using MovieInfo.Helpers;

namespace MovieInfo.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class TitleController : Controller
    {
        private readonly MovieDbContext _db;

        public TitleController(MovieDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Titles.ToList());
        }
        //Http Get Method
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Title title)
        {
            if (ModelState.IsValid)
            {
                _db.Add(title);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(title);
        }
        // Post Method
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var title = _db.Titles.Find(id);
            if (title == null)
            {
                return NotFound();
            }
            _db.Titles.Remove(title);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int id)
        {
            var title = _db.Titles.Find(id);
            if (title == null)
            {
                return NotFound();
            }
            return View(title);
        }

        [HttpPost]
        public IActionResult Edit(Title title)
        {
            if (ModelState.IsValid)
            {
                _db.Update(title);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(title);
        }
    }
}
