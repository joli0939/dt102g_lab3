using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboration3.Models;
using Microsoft.AspNetCore.Http;

namespace Laboration3.Controllers
{
    public class ActorController : Controller
    {
        [HttpGet]
        public IActionResult ListActors()
        {
            List<ActorDetail> ActorList = new List<ActorDetail>();
            ActorMethods am = new ActorMethods();
            string error = "";

            ActorList = am.GetActorList(out error);

            ViewBag.error = error;
            ViewBag.editError = HttpContext.Session.GetString("errorEdit");
            ViewBag.deleteError = HttpContext.Session.GetString("errorDelete");
            return View(ActorList);
        }


        [HttpPost]
        public IActionResult InsertActorTest(IFormCollection col)
        {
            ActorDetail ad = new ActorDetail();
            ActorMethods am = new ActorMethods();
            int i = 0;
            string error = "";

            ad.Forename = col["Forename"];
            ad.Surname = col["Surname"];
            ad.DateOfBirth = Convert.ToDateTime(col["DateOfBirth"]);

            i = am.InsertActor(ad, out error);

            ViewBag.error = error;
            ViewBag.antal = i;

            return RedirectToAction("ListActors");
        }


        [HttpGet]
        public IActionResult InsertActorForm()
        {
            return View();
        }


        [HttpGet]
        public IActionResult FilterActor()
        {
            ActorMethods am = new ActorMethods();;

            ViewModelAM myModel = new ViewModelAM()
            {
                ActorMovieList = am.GetActorMovieList(out string errormsg),
                ActorList = am.GetActorList(out string errormsg2)
            };

            ViewBag.error = "1: " + errormsg + "2: " + errormsg2;

            return View(myModel);
        }


        [HttpPost]
        public IActionResult FilterActor(string Actor)
        {
            int i = Convert.ToInt32(Actor);
            ViewData["SortValue"] = i;

            ActorMethods am = new ActorMethods(); ;

            ViewModelAM myModel = new ViewModelAM()
            {
                ActorMovieList = am.GetActorMovieList(out string errormsg, i),
                ActorList = am.GetActorList(out string errormsg2)
            };

            ViewBag.connect = HttpContext.Session.GetString("errorConnect");

            ViewBag.deleteConnect = HttpContext.Session.GetString("errorDeleteConnect");

            ViewBag.error = "1: " + errormsg + "2: " + errormsg2;

            return View(myModel);
        }


        [HttpGet]
        public IActionResult EditActor(int actorId)
        {
            ActorMethods am = new ActorMethods();
            ActorDetail ad = new ActorDetail();
            string error = "";

            ad = am.GetActor(out error, actorId);

            ViewBag.error = error;
            ViewBag.test = actorId.ToString();

            return View(ad);

        }

        [HttpPost]
        public IActionResult SendEdit(IFormCollection col)
        {
            ActorDetail ad = new ActorDetail();
            ActorMethods am = new ActorMethods();
            int i = 0;
            string error = "";

            ad.Forename = col["Forename"];
            ad.Surname = col["Surname"];
            ad.DateOfBirth = Convert.ToDateTime(col["DateOfBirth"]);
            ad.Id = Convert.ToInt32(col["Id"]);

            i = am.UpdateActor(ad, out error);

            HttpContext.Session.SetString("errorEdit", error);

            return RedirectToAction("ListActors");
        }

        [HttpPost]
        public IActionResult DeleteActor(IFormCollection col)
        {
            int i = 0;
            int deleteId = Convert.ToInt32(col["actorId"]);
            string error = "";

            ActorMethods am = new ActorMethods();

            i = am.DeleteActor(deleteId, out error);

            HttpContext.Session.SetString("errorDelete", error);

            return RedirectToAction("ListActors");
        }

        [HttpGet]
        public IActionResult ConnectActorMovie()
        {
            ActorMethods am = new ActorMethods();
            MovieMethods mm = new MovieMethods();

            string error = "";
            string error2 = "";

            ViewModelConnectActorMovie myModel = new ViewModelConnectActorMovie()
            {
                MovieList = mm.GetMovieList(out error),
                ActorList = am.GetActorList(out error2)
            };

            ViewBag.error = "1: " + error + "2: " + error2;

            return View(myModel);
        }

        [HttpPost]
        public IActionResult SendConnectActorMovie(IFormCollection col)
        {
            ConnectActorMovieDetail camd = new ConnectActorMovieDetail();
            ActorMethods am = new ActorMethods();

            string error = "";

            camd.ActorId = Convert.ToInt32(col["Actor"]);
            camd.MovieId = Convert.ToInt32(col["Movie"]);

            am.ConnectActorMovie(camd, out error);

            HttpContext.Session.SetString("errorConnect", error);

            return RedirectToAction("FilterActor");
        }

        [HttpPost]
        public IActionResult DeleteConnection(IFormCollection col)
        {
            int deleteConnectionId = Convert.ToInt32(col["actorId"]);
            string error = "";
            ActorMethods am = new ActorMethods();

            int i = am.DeleteConnection(deleteConnectionId, out error);

            HttpContext.Session.SetString("errorDeleteConnect", error);

            return RedirectToAction("FilterActor");
        }
    }
}