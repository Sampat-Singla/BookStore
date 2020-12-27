using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return bookModels();
        }

        public BookModel GetBookbyId(int id)
        {
            return bookModels().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return bookModels().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
       

        private List<BookModel> bookModels()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Author= "Sampat Singla" , Title ="MVC"},
                new BookModel() { Id =2, Author = "Sampat" , Title = "Core MVC"},
                new BookModel() { Id =2, Author = "Singla" , Title = "ASP.NET"}
            };
        }
    }
}
