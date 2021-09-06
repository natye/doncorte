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
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GeBookBYId(id);
        }
        public List<BookModel> SearchBooks(string bookname, string autherName)
        {
            return _bookRepository.SearchBook(bookname, autherName);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
