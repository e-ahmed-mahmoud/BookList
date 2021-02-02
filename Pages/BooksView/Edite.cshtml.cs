using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EditedBookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EditedBookList.Pages.BooksView
{
    public class EditeModel : PageModel
    {
        BookContextDb _context;
        
        [BindProperty]
        public BookModel Book { get; set; }

        public EditeModel(BookContextDb context)
        {
            _context = context;
        }

        public async Task OnGet (int id)
        {
            Book = await _context.TbBook.FindAsync(id);
        }

        public async Task <IActionResult> OnPost()
        {
            var obj = await _context.TbBook.FindAsync(Book.Id);
            if (obj == null)
            {
               return BadRequest();
            }
            obj.Name = Book.Name;
            obj.Author = Book.Author;
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");

        }
    }
}
