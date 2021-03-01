using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieInfo.AppDbContext;
using MovieInfo.Helpers;
using MovieInfo.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting.Internal;
using cloudscribe.Pagination.Models;
using Microsoft.EntityFrameworkCore;
using MovieInfo.Controllers.Resources;

namespace MovieInfo.Controllers
{
    [Authorize(Roles = Roles.Admin + "," + Roles.Executive)]
    public class MovieController : Controller
    {
        private readonly MovieDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;

        public MovieController(MovieDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
        }
        [AllowAnonymous]
        public IActionResult Index(string searchString, string sortOrder, int pageNumber = 1, int pageSize = 3)
        {
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentFilter = searchString;
            ViewBag.YearSortParam = String.IsNullOrEmpty(sortOrder) ? "year_desc" : "";
            int ExcludeRecords = (pageSize * pageNumber) - pageSize;
            var Movies = from b in _db.Movies
                         select b;
            var MovieCount = Movies.Count();
            if (!String.IsNullOrEmpty(searchString))
            {
                Movies = Movies.Where(b => b.Title.Contains(searchString));
                MovieCount = Movies.Count();
            }

            //Sorting Logic
            switch (sortOrder)
            {
                case "year_desc":
                    Movies = Movies.OrderByDescending(b => b.Year);
                    break;
                default:
                    Movies = Movies.OrderBy(b => b.Year);
                    break;
            }

            Movies = Movies
            .Skip(ExcludeRecords)
            .Take(pageSize);

            var result = new PagedResult<Movie>
            {
                Data = Movies.AsNoTracking().ToList(),
                TotalItems = MovieCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return View(result);
        }
        //Http Get Method
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Add(movie);
                _db.SaveChanges();
                var MovieId = movie.Id;
                string wwrootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                var SavedMovie = _db.Movies.Find(MovieId);
                if (files.Count != 0)
                {
                    var ImagePath = @"images\";
                    var Extension = Path.GetExtension(files[0].FileName);
                    var RelativeImagePath = ImagePath + MovieId + Extension;
                    var AbsImagePath = Path.Combine(wwrootPath, RelativeImagePath);
                    using (var fileStream = new FileStream(AbsImagePath, FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    SavedMovie.ImagePath = RelativeImagePath;
                    _db.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // Post Method
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            _db.Movies.Remove(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Update(movie);
                _db.SaveChanges();
                var MovieId = movie.Id;
                string wwrootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                var SavedMovie = _db.Movies.Find(MovieId);
                if (files.Count != 0)
                {
                    var ImagePath = @"images\";
                    var Extension = Path.GetExtension(files[0].FileName);
                    var RelativeImagePath = ImagePath + MovieId + Extension;
                    var AbsImagePath = Path.Combine(wwrootPath, RelativeImagePath);
                    using (var fileStream = new FileStream(AbsImagePath, FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    SavedMovie.ImagePath = RelativeImagePath;
                    _db.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult View(int id)
        {
            var movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [AllowAnonymous]
        [HttpGet("api/movies")]
        public IEnumerable<MovieResources> Movies()
        {
            var movies = _db.Movies.ToList();
            var movieResources = movies
                .Select(m => new MovieResources
                {
                    Id = m.Id,
                    Title = m.Title,

                }).ToList();
            return movieResources;
        }
    }
}