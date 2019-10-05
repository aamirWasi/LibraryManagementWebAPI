using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementWebAPI
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        

            builder.Entity<IssueBook>()
                .HasKey(ib => new { ib.StudentId, ib.bookId });

            builder.Entity<IssueBook>()
                .HasOne(ib => ib.Student)
                .WithMany(i => i.BookIssues)
                .HasForeignKey(ib => ib.StudentId);

            builder.Entity<ReturnBook>()
                .HasKey(rb => new { rb.StudentId, rb.BookId });

            builder.Entity<ReturnBook>()
                .HasOne(rb => rb.Student)
                .WithMany(rb => rb.BookReturns);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<IssueBook> IssueBook { get; set; }
        public DbSet<ReturnBook> ReturnBooks { get; set; }
    }
}
