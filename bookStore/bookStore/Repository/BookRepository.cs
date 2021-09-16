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
                new BookModel() { Id = 1, Title = "Mvc", Auther = "nathan",Description="what is going on in mvc",Language="english",Category="development",TotalPage=123 },
                new BookModel() { Id = 2, Title = "java", Auther = "Abebe" ,Description="java programing is one of the most used programing language",Language="english",Category="development",TotalPage=123 },
                new BookModel() { Id = 3, Title = "dot net", Auther = "Kebede",Description="dot net frame work is good and best frame work of the C# programing languages",Language="english",Category="development",TotalPage=123  },
                new BookModel() { Id = 4, Title = "oop", Auther = "Chala",Description="object orented programing is best for programers to manage every thing and to build abig programs by small group called objects",Language="english",Category="development",TotalPage=123  },
                new BookModel() { Id = 5, Title = "Mvc", Auther = "kebde",Description="model view contrlloer",Language="english",Category="development",TotalPage=123  },
                new BookModel() { Id = 6, Title = "C#", Auther = "samuel",Description="c# is derived for c languge and also can be used in machine languages",Language="english",Category="development",TotalPage=123  }
            };
        }
    }
    }
