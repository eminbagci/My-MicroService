using Book.Domain.DTOs;
using Book.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Infrastructure.Services
{
    public class BookService : IBookService
    {
        public BookDto GetBookById(int id)
        {
            var book = new BookDto
            {
                Author = "J.R.R Tolkien",
                Id = id,
                PageCount = 1012,
                BookName = "Yüzüklerin Efendisi",
                Title = "Yüzüklerin Efendisi Tek Cilt Özel Basım"
            };
            return book;
        }
    }
}
