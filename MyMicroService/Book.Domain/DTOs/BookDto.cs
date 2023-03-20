using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Domain.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string? BookName { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int PageCount { get; set; }
    }
}
