using BD_Kyrsach.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using static BD_Kyrsach.Models.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace BD_Kyrsach.Controllers
{
    public class OrderController : Controller
    {

        public readonly IConfiguration _config;

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        [HttpGet]
        public IActionResult Order(int value)
        {
            OrderModel model = new OrderModel
            {
                UserId = DB.GetMyId(Connection, User.Identity.Name)[0].UserId,
                FurnitureId = value,
                Date = DateTime.Now
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Order(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                Order Order = await db.Order.FirstOrDefaultAsync(u => u.Date == model.Date);
                if (Order == null)
                {
                    int Useridd = DB.GetMyId(Connection, User.Identity.Name)[0].UserId;
                    db.Order.Add(new Order { Date = model.Date, FurnitureId = model.FurnitureId, UserId = Useridd });
                    await db.SaveChangesAsync();

                    return RedirectToAction("Catalog", "Home");
                }
                else
                    ModelState.AddModelError("", "Wrong");
            }
            return View(model);
        }

        [Authorize]
        public IActionResult My_order()
        {
            var emeil = User.Identity.Name;
            var id = DB.GetMyId(Connection, emeil);
            var model4 = DB.GetMyOrderNames(Connection, id[0].UserId);
            List<Furniture> model5 = new List<Furniture>();
            foreach (var item in model4)
            {
                model5.Add(GetFurnitureName(Connection, item.FurnitureId)[0]);
            }
            var model4s = (model4, model5);
            return View(model4s);
        }

        
        public IActionResult Delete_order(int value)
        {
            DB.DeletOrder(Connection, value);
            return RedirectToAction("My_order", "Order");
        }

        private OrderContext db;
        public OrderController(OrderContext context, IConfiguration config)
        {
            db = context;
            _config = config;
        }



    }
}
