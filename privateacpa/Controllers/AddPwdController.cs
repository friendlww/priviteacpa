using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using privateacpa.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace privateacpa.Controllers
{
    public class AddPwdController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public void AddPwdInfo(SqliteContext context)
        {
            context.DBUser.Add(
              new DBUser()
              {
                  name = "tttt"
              }
            );
            context.SaveChanges();
        }
    }
}
