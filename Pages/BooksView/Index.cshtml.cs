using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EditedBookList.Models;
using Microsoft.EntityFrameworkCore;

namespace EditedBookList.Pages.BooksView
{
    public class IndexModel : PageModel
    {
        private BookContextDb _context;

        public IEnumerable<BookModel> Books { get; set; }

        public IndexModel( BookContextDb context )
        {
            _context = context;
        }

        public async Task OnGet()
        {
            Books = await _context.TbBook.ToListAsync();    
        }

        public async Task<IActionResult> OnGetDelete (int id)
        {
            var obj = await _context.TbBook.FindAsync(id);
            _context.TbBook.Remove(obj);
            await _context.SaveChangesAsync();
            return RedirectToPage();

        }

    }
}
