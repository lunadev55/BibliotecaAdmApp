using System;
using System.Collections.Generic;
using System.Text;
using BibliotecaAdmApp.Core.Enums;

namespace BibliotecaAdmApp.Application.Books.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public BookStatus Status { get; set; }
    }
}
