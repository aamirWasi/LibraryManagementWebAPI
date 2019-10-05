using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebAPI.Model
{
    public class ReturnBook
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string BookBarCode { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
