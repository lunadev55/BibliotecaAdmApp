using BibliotecaAdmApp.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAdmApp.Application.Books.Commands
{
    public class UpdateBookCmd : IRequest<int>
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public BookStatus Status { get; set; }
        
    }
}
