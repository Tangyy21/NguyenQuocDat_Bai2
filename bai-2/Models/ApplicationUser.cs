using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace bai_2.Models
{
    public class ApplicationUser : IndetityUser
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
