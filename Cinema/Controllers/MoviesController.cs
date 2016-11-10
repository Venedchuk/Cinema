using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name= "Shrek"  };

            ViewData["Movie"] = movie;

            ViewBag.RandomMovie = movie;

            var viewResult = new ViewResult();
            movie.Name = "GGwrong";
            //viewResult.ViewData.Model = movie;

             return View(movie);

        }
        public ActionResult Edit(int id)
        {
            return Content("Id="+ id);
        }
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));



        }

        [Route("movies/reseased/{year:regex(2015|2016)}/{month:regex(1[0-2]|0[1-9]|[1-9])}")]
        public ActionResult ByReleaseDate(int year,int month)
        {

            return Content(year+ "/"+ month);
        }
    }
}