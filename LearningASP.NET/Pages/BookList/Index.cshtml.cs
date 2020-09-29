using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LearningASP.NET.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}
