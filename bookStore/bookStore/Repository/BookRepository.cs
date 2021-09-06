using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookStore.Models;

namespace bookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();

        }
        public BookModel GeBookBYId( int id)
        {
            return DataSource().Where(x=>x.Id==id).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string title, string autherName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Auther.Contains(autherName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "Mvc", Auther = "nathan" },
                new BookModel() { Id = 2, Title = "java", Auther = "Abebe" },
                new BookModel() { Id = 3, Title = "dot net", Auther = "Kebede" },
                new BookModel() { Id = 4, Title = "oop", Auther = "Chala" },
                new BookModel() { Id = 5, Title = "Mvc", Auther = "kebde" },
                new BookModel() { Id = 6, Title = "C#", Auther = "samuel" }
            };
        }
    }
    }
