using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace BibliotecaAdmApp.Application.Books.Commands
{
    public class DeleteBookCmd : IRequest<int>
    {
        public int Id { get; set; }
    }
}
