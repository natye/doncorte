using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStore.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ref { get; set; }
        public string Auther { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public string Category { get; set; }
        public int TotalPage { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        //rellation ship for language table one to one
        public Language Language { get; set; }
        //rellation ship for galleary one to many
        public ICollection<BookGallery> bookGalleries { get; set; }
        public string BookUrl { get; set; }




    }
   
}
