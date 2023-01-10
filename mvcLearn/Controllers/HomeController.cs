using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcLearn.Models;
using mvcLearn.Services;
using mvcLearn.ViewModels;

namespace mvcLearn.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            //var model = _restaurantData.GetAll();
            var model = new HomeIndexViewModel();
            model.Restaurent = _restaurantData.GetAll();
            model.CurrentMessage = "FOOD GHOR";
            return View(model);
        }


        public string NotFound()
        {
            return "Page Not Found !";
        }

    }
}

