using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using bookStore.Helpers;
using Microsoft.AspNetCore.Http;

namespace bookStore.Models
{
    public class BookModel
    {
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Enter your Email")]
        public string MyField { get; set; }
        public int Id { get; set; }

        [StringLength(100, MinimumLength =5)]
        [Required (ErrorMessage ="Please enter the Book Title")]
        //[MyCustomValidation]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the Auther")]
        [StringLength(100, MinimumLength = 5)]
        public string Auther { get; set; }
        [Required(ErrorMessage = "Please enter Description")]
        [StringLength(300, MinimumLength = 10)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please select the on of the Language")]
        public int LanguageId { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter the the proper value for the Total Page")]
        [Display (Name ="Total Page of The Book")]
        public int? TotalPage { get; set; }
        [Display(Name = "Choose the Cover Photo")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }
        [Display(Name = "Choose the  Photos")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }
        public List<GalleryModel> Gallery { get; set; }
        [Display(Name = "Choose Book in PDF format")]
        [Required]
        public IFormFile BookPdf { get; set; }
        public string BookUrl { get; set; }

    }
}
