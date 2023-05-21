using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BD_Kyrsach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace BD_Kyrsach.Models
{
    public class DB : Microsoft.EntityFrameworkCore.DbContext
    {
        
        public static List<User> GetUserNames(IDbConnection Connection)
        {
            var result = Connection.Query<User>("SELECT * FROM [User]").ToList();
            return result;
        }

        public class UserContext : Microsoft.EntityFrameworkCore.DbContext
        {
            public Microsoft.EntityFrameworkCore.DbSet<User> User { get; set; }
            public UserContext(DbContextOptions<UserContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }

        public class FurnitureContext : Microsoft.EntityFrameworkCore.DbContext
        {
            public Microsoft.EntityFrameworkCore.DbSet<Furniture> Furniture { get; set; }
            public FurnitureContext(DbContextOptions<FurnitureContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }

        public class UserFurContext : Microsoft.EntityFrameworkCore.DbContext
        {
            public Microsoft.EntityFrameworkCore.DbSet<UserFur> UserFur { get; set; }
            public UserFurContext(DbContextOptions<UserFurContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }

        public class OrderContext : Microsoft.EntityFrameworkCore.DbContext
        {
            public Microsoft.EntityFrameworkCore.DbSet<Order> Order { get; set; }
            public OrderContext(DbContextOptions<OrderContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }

        public static List<UserFur> GetUserFurNames(IDbConnection Connection)
        {
            var result = Connection.Query<UserFur>("SELECT * FROM [UserFur]").ToList();
            return result;
        }

        public static List<UserFur> GetMyUserFurNames(IDbConnection Connection, int id)
        {
            var result = Connection.Query<UserFur>($"SELECT * FROM [UserFur] WHERE [Userid] =('{id}')").ToList();
            return result;
        }

        public static List<User> GetMyId(IDbConnection Connection, string emeil)
        {
            var result = Connection.Query<User>($"SELECT [Userid] FROM [User] WHERE [Email] =('{emeil}')").ToList();
            return result;
        }

        public static List<Furniture> GetMyFurnitureNames(IDbConnection Connection, List<UserFur> id)
        {
            var result = Connection.Query<Furniture>($"SELECT * FROM [Furniture] WHERE [FurnitureId] =('{-1}')").ToList();
            foreach (var item in id)
            {
                var iiii = Connection.Query<Furniture>($"SELECT * FROM [Furniture] WHERE [FurnitureId] =('{item.FurnitureId}')").ToList();
                result.Add(iiii[0]);
            }
            return result;
        }

        public static List<Order> GetMyOrderNames(IDbConnection Connection, int id)
        {
            var result = Connection.Query<Order>($"SELECT * FROM [Order] WHERE [Userid] =('{id}')").ToList();
            return result;
        }

        public static List<Order> GetOrderNames(IDbConnection Connection)
        {
            var result = Connection.Query<Order>("SELECT * FROM [Order]").ToList();
            return result;
        }

        public static List<Furniture> GetFurnitureNames(IDbConnection Connection)
        {
            var result = Connection.Query<Furniture>($"SELECT * FROM [Furniture]").ToList();
            return result;
        }

        public static List<Furniture> GetFurnitureName(IDbConnection Connection, int id)
        {
            var result = Connection.Query<Furniture>($"SELECT * FROM [Furniture] WHERE [FurnitureId]=('{id}')").ToList();
            return result;
        }

        public static List<Family> GetFamilyName(IDbConnection Connection, int id)
        {
            var result = Connection.Query<Family>($"SELECT [Name] FROM [Family] WHERE [Familyid]=('{id}')").ToList();
            return result;
        }

        public static List<Typeof> GetTypeofName(IDbConnection Connection, int id)
        {
            var result = Connection.Query<Typeof>($"SELECT [Title] FROM [Typeof] WHERE [Typeofid]=('{id}')").ToList();
            return result;
        }

        public static List<Family> GetFamilyNames(IDbConnection Connection)
        {
            var result = Connection.Query<Family>("SELECT * FROM [Family]").ToList();
            return result;
        }

        public static List<Typeof> GetTypeofNames(IDbConnection Connection)
        {
            var result = Connection.Query<Typeof>("SELECT * FROM [Typeof]").ToList();
            return result;
        }


        public static List<Order> GetOrderUserfurnitureId(IDbConnection Connection)
        {
            var result = Connection.Query<Order>("SELECT [UserfurnitureId] FROM [Order]").ToList();
            return result;
        }

        public static void DeletOrder(IDbConnection Connection, int OrderId)
        {
            Connection.Query<Order>($"DELETE FROM [Order] WHERE [OrderId]=('{OrderId}')");
        }

        public class User
        {
            public int UserId { get; set; }

            public int Age { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public int Balance { get; set; }

            public string Password { get; set; }
        }

        public class UserFur
        {
            public int UserFurId { get; set; }

            public int UserId { get; set; }

            public int FurnitureId { get; set; }
        }

        public class Order
        {
            public int OrderId { get; set; }

            public int UserId { get; set; }

            public int FurnitureId { get; set; }

            public DateTime Date { get; set; }
        }

        public class Furniture
        {
            public int FurnitureId { get; set; }

            public int FamilyId { get; set; }

            public int TypeofId { get; set; }

            public string Name { get; set; }

            public int Price { get; set; }
        }

        public class Family
        {
            public int FamilyId { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }
        }

        public class Typeof
        {
            public int TypeofId { get; set; }

            public string Title { get; set; }
        }
    }
}
