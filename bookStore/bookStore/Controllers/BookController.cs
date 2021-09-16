using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookStore.Models;
using bookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bookStore.Controllers
{
    public class bookController : Controller
    {
        private readonly BookRepository _bookRepository=null;
            public bookController()
        {
            _bookRepository = new BookRepository();

        }
       public ViewResult GetAllBooks(){
           var data= _bookRepository.GetAllBooks();
            return View(data);
        }
        [
            Route("bookdetails/{id}")]
        public ViewResult GetBook(int id, string NameBook)
        {
            var data = _bookRepository.GeBookBYId(id);
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookname, string autherName)
        {
            return _bookRepository.SearchBook(bookname, autherName);
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddBook(BookModel bookmodel)
        {
            return View();
        }
    }
}
