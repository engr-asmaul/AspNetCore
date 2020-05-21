using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracBookStore.Models;
using PracBookStore.Repository;

namespace PracBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }




        public List<BookModel> GetAllbooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}