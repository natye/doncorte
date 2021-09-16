using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using bookStore.Models;

namespace bookStore.Controllers
{
    public class HomeController : Controller
    {
       [ViewData]
       public string Customproperty { get; set; }
        [ViewData]
        public string Title { get; set; }
        [ViewData]
        public BookModel Book { get; set; }
        public ViewResult Index()
        {
            Title = "Home";
            Customproperty = "Custom Value";
            Book = new BookModel() { Id=1,Auther="ajdls" , Title="asdfa",Description="adljfalj adf"};
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            Title = "Contact Us from c";
            return View();
        }
    }
}
