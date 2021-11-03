using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookStore.Models;
using bookStore.Data;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Auther = model.Auther,
                Category = model.Category,
                Description = model.Description,
                LanguageId = model.LanguageId,

                Title = model.Title,
                //Language=model.Language,
                TotalPage = model.TotalPage.HasValue ? model.TotalPage.Value : 0,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
                CoverImageUrl = model.CoverImageUrl,
                BookUrl = model.BookUrl

            };
            //var gallery = new List<BookGallery>();
            newBook.bookGalleries = new List<BookGallery>();
            //adding galleries
            foreach (var file in model.Gallery)
            {
                newBook.bookGalleries.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {

            return await _context.Books.Select(book => new BookModel()
            {
                Auther = book.Auther,
                Category = book.Category,
                Description = book.Description,
                Title = book.Title,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                TotalPage = book.TotalPage,
                CoverImageUrl = book.CoverImageUrl
            }
            ).ToListAsync();

        }

        public async Task<List<BookModel>> GetTopBooksAsync(int count)
        {

            return await _context.Books.Select(book => new BookModel()
            {
                Auther = book.Auther,
                Category = book.Category,
                Description = book.Description,
                Title = book.Title,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                TotalPage = book.TotalPage,
                CoverImageUrl = book.CoverImageUrl
            }
            ).Take(count).ToListAsync();

        }
        public async Task<BookModel> GeBookBYId(int id)
        {

            return await _context.Books.Where(x => x.Id == id).Select(book => new BookModel()
            {
                Auther = book.Auther,
                Category = book.Category,
                Description = book.Description,
                Title = book.Title,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                TotalPage = book.TotalPage,
                CoverImageUrl = book.CoverImageUrl,
                Gallery = book.bookGalleries.Select(gallery => new GalleryModel
                {
                    Id = gallery.Id,
                    URL = gallery.URL,
                    Name = gallery.Name
                }).ToList(),
                BookUrl = book.BookUrl


            }).FirstOrDefaultAsync();





        }
        public List<BookModel> SearchBook(string title, string autherName)
        {
            return null;
        }

    }
}
