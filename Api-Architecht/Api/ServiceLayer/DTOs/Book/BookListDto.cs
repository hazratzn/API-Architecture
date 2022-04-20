using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Book
{
    public class BookListDto
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Page { get; set; }
        public float Price { get; set; }
    }
}
