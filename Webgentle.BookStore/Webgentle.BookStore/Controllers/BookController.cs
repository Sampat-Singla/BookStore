using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            return View(_bookRepository.GetAllBooks());

        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookbyId(id);
        }

        public List<BookModel> Searchbook(string bookname, string authorname)
        {
            return _bookRepository.SearchBook(bookname, authorname);
        }
    }

}
