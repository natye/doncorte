using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using bookStore.Models;
using bookStore.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace bookStore.Controllers
{
    [Route("[controller]/[action]")]
    public class bookController : Controller
    {
        private readonly IBookRepository _bookRepository=null;
        private readonly ILanguageRepository _languageRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;
        public bookController(IBookRepository bookRepository, ILanguageRepository languageRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
            _webHostEnvironment = webHostEnvironment;

        }
        [Route("~/all-books ")]
       public async Task<ViewResult> GetAllBooks(){
           var data= await _bookRepository.GetAllBooks();
            return View(data);
        }
        [
            Route("~/bookdetails/{id:int:min(1)}",Name ="bookDetailsRoute")]
        public async Task<ViewResult>  GetBook(int id, string NameBook)
        {
            var data = await _bookRepository.GeBookBYId(id);
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
        public async Task<ViewResult> AddBook(bool isSccess=false, int bookId=0)
         {
            ViewBag.isSccess = isSccess;
            ViewBag.bookId = bookId;
            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(BookModel bookmodel)
        {
            if (bookmodel.CoverPhoto != null)
            {
                string folder = "books/cover/";
                bookmodel.CoverImageUrl = await UploadImage(folder, bookmodel.CoverPhoto);
              // bookmodel.CoverImageUrl=
                
            }
            if (bookmodel.GalleryFiles != null)
            {
                string folder = "books/gallery/";
                bookmodel.Gallery = new List<GalleryModel>();
                  foreach(var file in bookmodel.GalleryFiles){
                    var gallery = new GalleryModel()
                    { URL = await UploadImage(folder, file),
                        Name=file.FileName};
                   
                    bookmodel.Gallery.Add(gallery);
                }
              

            }
            if (bookmodel.BookPdf != null)
            {
                string folder = "books/pdf/";
                bookmodel.BookUrl = await UploadImage(folder, bookmodel.BookPdf);
                // bookmodel.CoverImageUrl=

            }
            int id= await _bookRepository.AddNewBook(bookmodel);
            if (ModelState.IsValid) {
                if (id > 0)
            {

                return RedirectToAction(nameof(AddBook),new { isSccess =true, bookId = id }); 
                
            }}

            ViewBag.Language =new SelectList( await _languageRepository.GetLanguages(),"Id","Name");
            return View();
        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
            
            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            //bookmodel.CoverImageUrl = "/" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }
       
    }
}
