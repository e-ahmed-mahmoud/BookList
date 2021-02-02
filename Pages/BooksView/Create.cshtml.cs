using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EditedBookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EditedBookList.Pages.BooksView
{
    public class CreateModel : PageModel
    {
        private BookContextDb _context;

        [BindProperty]
        public BookModel Book { get; set; }

        public CreateModel(BookContextDb context)
        {
            _context = context;
        }
        
        
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage();
            }
            if (Book == null)
            {
            }
            _context.TbBook.Add(Book);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
