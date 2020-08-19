using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using BibliotecaAdmApp.Core.Enums;

namespace BibliotecaAdmApp.Application.Books.Commands
{
    public class CreateBookCmd : IRequest<int>
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public BookStatus Status { get; set; }
        
    }
}
