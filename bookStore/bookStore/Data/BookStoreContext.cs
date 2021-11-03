using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStore.Data
{
    public class BookStoreContext: DbContext 
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Books> BookGallery { get; set; }
        public DbSet<Language> Languages { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlite("Server=.;Databas=BookStore;Integrated Security=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
