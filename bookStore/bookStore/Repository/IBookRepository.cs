using bookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bookStore.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<BookModel> GeBookBYId(int id);
        Task<List<BookModel>> GetAllBooks();
        Task<List<BookModel>> GetTopBooksAsync(int count);
        List<BookModel> SearchBook(string title, string autherName);
    }
}