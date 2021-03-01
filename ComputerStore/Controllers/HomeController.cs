using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
namespace Lab5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext _context;
        public HomeController(ProductContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ForUs() 
        { 
            return View(); 
        }
        [HttpGet]
        public IActionResult Contacts()
        {
            ViewBag.Title = "Контакти";
            var model = new Contact();
            ViewData["Subject"] = new SelectList(model.Subjects);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contacts(Contact login)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Subject"] = new SelectList(login.Subjects);
                return View(login);
            }
            _context.Add(login);
            await _context.SaveChangesAsync();
            TempData["message"] =
            "Здравейте, " + login.FirstName + " " + login.FamilyName +
            "!\r\nДобре дошли в нашия сайт!\r\nВашият електронен адрес " +
            login.Email + " е добавен успешно.";
            return RedirectToAction("OK", "Home");
        }
        public IActionResult OK()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult Orders()
        {
            ViewBag.Title = "Поръчки";
            var model = new Order();
            ViewData["Product"] = new SelectList(model.Products);
            ViewData["Deliever"] = new SelectList(model.Delievers);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Orders(Order login)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Product"] = new SelectList(login.Products);
                ViewData["Deliever"] = new SelectList(login.Delievers);
                return View(login);
            }
            _context.Add(login);
            await _context.SaveChangesAsync();
            TempData["message"] =
            "Здравейте, " + login.FirstName + " " + login.FamilyName +
            "!\r\nБлагодарим за вашата поръчка!\r\nВашата поръчка" +
             " е направена успешно!";
            return RedirectToAction("OK", "Home");
        }
    }
}