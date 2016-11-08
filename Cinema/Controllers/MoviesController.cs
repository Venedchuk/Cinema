﻿using Cinema.Models;
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


             return View(movie);
            // return Content("Hello World");
            // return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home",new { age=1, sortBy="name"});
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
        public ActionResult ByReleaseDate(int year,int month)
        {

            return Content(year+ "/"+ month);
        }
    }
}