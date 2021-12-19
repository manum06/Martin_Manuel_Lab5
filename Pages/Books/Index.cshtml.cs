using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Martin_Manuel_Lab5.Data;
using Martin_Manuel_Lab5.Models;

namespace Martin_Manuel_Lab5.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Martin_Manuel_Lab5.Data.Martin_Manuel_Lab5Context _context;

        public IndexModel(Martin_Manuel_Lab5.Data.Martin_Manuel_Lab5Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
                Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
            }
    }
}
