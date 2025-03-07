﻿using Microsoft.AspNetCore.Mvc;
using ProjectReview.Models;
using ProjectReview.Repositories;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectReview.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILocationRepository _locationRepository;
        public HomeController(ILocationRepository locationRepository)
        {

            _locationRepository = locationRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Location> list = _locationRepository.GetAll();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View();
        }
    }
}