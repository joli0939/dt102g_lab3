using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboration3.Models;
using Microsoft.AspNetCore.Http;

namespace Laboration3.Controllers
{
    public class MovieController : Controller
    {

        [HttpPost]
        public IActionResult InsertMovieTest(IFormCollection col)
        {
            MovieDetail md = new MovieDetail();
            MovieMethods mm = new MovieMethods();
            int i = 0;
            string error = "";

            md.Name = col["Name"];
            md.Genre = col["Genre"];
            md.Playtime = Convert.ToInt32(col["Playtime"]);
            md.Year = Convert.ToInt32(col["Year"]);
            md.IMDBScore = double.Parse(col["IMDBScore"], System.Globalization.CultureInfo.InvariantCulture);
            md.Director = col["Director"];

            i = mm.InsertMovie(md, out error);

            ViewBag.error = error;
            ViewBag.antal = i;

            return RedirectToAction("ListMovies");
        }

        [HttpGet]
        public IActionResult InsertMovieForm()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListMovies(string sort)
        {
            List<MovieDetail> MovieList = new List<MovieDetail>();
            MovieMethods mm = new MovieMethods();
            string error = "";         

            if (sort == null)
            {
                MovieList = mm.GetMovieList(out error);
                sort = "abyss";
                var sortValue = new CookieOptions();
                sortValue.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Append("SortValue", sort, sortValue);
            }
            else
            {

                if (sort == Request.Cookies["SortValue"])
                {
                    MovieList = mm.GetMovieListSortedDescending(out error, sort);

                    sort = "abyss";
                    var sortValue = new CookieOptions();
                    sortValue.Expires = DateTime.Now.AddMinutes(10);
                    Response.Cookies.Append("SortValue", sort, sortValue);
                }
                else
                {
                    MovieList = mm.GetMovieListSorted(out error, sort);

                    var sortValue = new CookieOptions();
                    sortValue.Expires = DateTime.Now.AddMinutes(10);
                    Response.Cookies.Append("SortValue", sort, sortValue);
                }
                               
            }

            ViewBag.error = error;
            ViewBag.editError = HttpContext.Session.GetString("errorEdit");
            ViewBag.deleteError = HttpContext.Session.GetString("errorDelete");

            return View(MovieList);
            
        }
        
        [HttpGet]
        public IActionResult SearchMovie()
        {
            List<MovieDetail> MovieList = new List<MovieDetail>();
            return View(MovieList);
        }

        [HttpPost]
        public IActionResult SearchMovie(string Query)
        {
            MovieMethods mm = new MovieMethods();
            List<MovieDetail> MovieList = new List<MovieDetail>();
            string error = "";

            ViewBag.HaveSearched = "Yes";

            MovieList = mm.SearchMovie(out error, Query);

            ViewBag.error = error;

            return View("ListMovies", MovieList);
        }

        [HttpGet]
        public IActionResult EditMovie(int movieId)
        {
            MovieMethods mm = new MovieMethods();
            MovieDetail md = new MovieDetail();
            string error = "";

            md = mm.GetMovie(out error, movieId);

            ViewBag.error = error;
            ViewBag.test = movieId.ToString();

            return View(md);

        }

        [HttpPost]
        public IActionResult SendEdit(IFormCollection col)
        {
            MovieDetail md = new MovieDetail();
            MovieMethods mm = new MovieMethods();
            int i = 0;
            string error = "";

            md.Name = col["Name"];
            md.Genre = col["Genre"];
            md.Playtime = Convert.ToInt32(col["Playtime"]);
            md.Year = Convert.ToInt32(col["Year"]);
            md.IMDBScore = Convert.ToDouble(col["IMDBScore"]);
            md.Director = col["Director"];
            md.Id = Convert.ToInt32(col["Id"]);

            i = mm.UpdateMovie(md, out error);

            HttpContext.Session.SetString("errorEdit", error);

            return RedirectToAction("ListMovies");
        }

        [HttpPost]
        public IActionResult DeleteMovie(IFormCollection col)
        {
            int i = 0;
            int deleteId = Convert.ToInt32(col["movieId"]);
            string error = "";

            MovieMethods mm = new MovieMethods();

            i = mm.DeleteMovie(deleteId, out error);

            HttpContext.Session.SetString("errorDelete", error);

            return RedirectToAction("ListMovies");
        }

    }
}