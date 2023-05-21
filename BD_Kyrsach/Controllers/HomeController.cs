using BD_Kyrsach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using static BD_Kyrsach.Models.DB;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace BD_Kyrsach.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Button(int value)
        {
            if (value == 6)
            {
                var model5 = DB.GetTypeofNames(Connection);
                return View(model5);
            }
            if (value == 7)
            {
                var model6 = DB.GetFamilyNames(Connection);
                return View(model6);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            var model3 = DB.GetFurnitureNames(Connection);
            foreach (var item in model3)
            {
                item.Name = item.Name + " Family: " + GetFamilyName(Connection, item.FamilyId)[0].Name;
                item.Name = item.Name + " Type: " + GetTypeofName(Connection, item.TypeofId)[0].Title;
            }
            return View(model3);
        }
        [Authorize]
        public IActionResult My_furniture()
        {
            var emeil = User.Identity.Name;
            var id = DB.GetMyId(Connection, emeil);
            var idf = DB.GetMyUserFurNames(Connection, id[0].UserId);
            var model4 = DB.GetMyFurnitureNames(Connection, idf);

            foreach (var item in model4)
            {
                item.Name = item.Name + " Family: " + GetFamilyName(Connection, item.FamilyId)[0].Name;
                item.Name = item.Name + " Type: " + GetTypeofName(Connection, item.TypeofId)[0].Title;
            }

            return View(model4);
        }

        public IActionResult Order()
        {
            var test = DB.GetOrderUserfurnitureId(Connection);
            return View(test);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
