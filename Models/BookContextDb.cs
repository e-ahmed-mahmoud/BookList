using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditedBookList.Models
{
    public class BookContextDb : DbContext
    {
        public BookContextDb(DbContextOptions<BookContextDb> options) : base(options)
        {

        }

        public DbSet<BookModel> TbBook { get; set; }

    }
}
