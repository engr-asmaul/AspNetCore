using PracBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }



        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id =1, Title = "MVC", Author = "Asmaul"},
                new BookModel(){Id = 2, Title = "PHP", Author = "WebGentle"}
            };
        }
    }
}
