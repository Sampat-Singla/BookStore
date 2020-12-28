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
                
                new BookModel(){Id =1, Title="MVC", Author = "Nitish", Description="This is the description for MVC book" },
                new BookModel(){Id =2, Title="Dot Net Core", Author = "Nitish", Description="This is the description for Dot Net Core book" },
                new BookModel(){Id =3, Title="C#", Author = "Monika", Description="This is the description for C# book" },
                new BookModel(){Id =4, Title="Java", Author = "Webgentle", Description="This is the description for Java book" },
                new BookModel(){Id =5, Title="Php", Author = "Webgentle", Description="This is the description for Php book" },
                new BookModel(){Id =6, Title="Azure DevOps", Author = "Nitish", Description="This is the description for Azure Devops book" },
            };
        }
    }
}
