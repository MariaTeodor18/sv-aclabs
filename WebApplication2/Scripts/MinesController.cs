﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Scripts
{
    [Authorize]
    public class MinesController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Mines
        public ActionResult Index()
        {
            var userId = this.User.Identity.GetUserId();
            var user = dbContext.Users.Find(userId);
            var city = user.Cities.First();

            return View(city);
        }

        public ActionResult Details(int mineId)
        {
            //iei mina, pasezi la view si afisezi informatii : tipul mine, imagine, descriere a minei, prod curenta, productia pt level urmator
            var mine = dbContext.Mines.Find(mineId);
           
            return View(mine);
        }
    }
}