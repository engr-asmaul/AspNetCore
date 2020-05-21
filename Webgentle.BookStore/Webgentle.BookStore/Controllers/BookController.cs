using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepositoty _bookRepositoty = null;
        public BookController()
        {
            _bookRepositoty = new BookRepositoty();
        }




        public List<BookModel> GetAllBooks()
        {
            return _bookRepositoty.GetAllBooks();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepositoty.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepositoty.SearchBook(bookName, authorName);
        }
    }
}