using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningASP.NET.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }

        public void OnGet()
        {
        }
    }
}
