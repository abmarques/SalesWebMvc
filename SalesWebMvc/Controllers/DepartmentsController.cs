using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index() {

            List<DepartmentMdl> list = new List<DepartmentMdl>();
            list.Add(new DepartmentMdl { Id = 1, Name = "Eletronics" });
            list.Add(new DepartmentMdl { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}