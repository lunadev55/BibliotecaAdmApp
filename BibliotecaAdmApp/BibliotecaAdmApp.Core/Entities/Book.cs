using BibliotecaAdmApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAdmApp.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Category { get; set;  }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public BookStatus Status { get; set; }
    }
}
