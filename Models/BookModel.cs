using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EditedBookList.Models
{

    public class BookModel
    {
        [Key]
        public int Id { get; set; }

        [Required] [StringLength(maximumLength:100)]
        public string Name { get; set; }

        public string Author { get; set; }
    }
}