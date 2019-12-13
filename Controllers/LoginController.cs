using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using users.Models;
using SzyftGetSet;
namespace users.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=192.168.0.50; Database = prodcat_pl; user = praktykant; password = praktykant; ";
        }

        [HttpPost]
        public ActionResult Verify(User acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;

            com.CommandText = "select * from Users where u_Code='" + acc.u_Code + "' and u_Pwd='" + Szyfr.Szyfruj(acc.u_Pwd) + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("UserPanel");
            }
            else
            {
                con.Close();
                return View("Error");
            }
        }

    }
}