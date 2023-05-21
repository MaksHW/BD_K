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
using Microsoft.Extensions.Logging;

namespace BD_Kyrsach.Controllers
{
    public class ConstructController : Controller
    {
        private FurnitureContext db;
        private UserFurContext dbf;
        private UserContext dbu;
        public ConstructController(FurnitureContext context, UserContext contextu, UserFurContext contextf)
        {
            db = context;
            dbf = contextf;
            dbu = contextu;
        }

        [HttpGet]
        public IActionResult Construct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Construct(ConstructModel model)
        {
            if (ModelState.IsValid)
            {
                var emeil = User.Identity.Name;
                User usid = await dbu.User.FirstOrDefaultAsync(u => u.Email == emeil);
                Furniture furniture = await db.Furniture.FirstOrDefaultAsync(u => u.Name == model.Name);
                if (furniture == null)
                {
                    db.Furniture.Add(new Furniture { FamilyId = model.FamilyId, TypeofId = model.TypeofId, Name = model.Name, Price = model.Price });
                    await db.SaveChangesAsync();
                    Furniture name = await db.Furniture.FirstOrDefaultAsync(u => u.Name == model.Name);
                    dbf.UserFur.Add(new UserFur { UserId = usid.UserId, FurnitureId = name.FurnitureId });
                    await dbf.SaveChangesAsync();
                    return RedirectToAction("My_furniture", "Home");
                }
                else
                    ModelState.AddModelError("", "Wrong");
            }
            return View(model);
        }

        
        
        
    }
}
