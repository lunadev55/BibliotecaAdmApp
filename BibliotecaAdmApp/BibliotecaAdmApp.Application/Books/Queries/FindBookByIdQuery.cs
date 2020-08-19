using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using BibliotecaAdmApp.Application.Books.Dto;

namespace BibliotecaAdmApp.Application.Books.Queries
{
    public class FindBookByIdQuery : IRequest<BookDto>
    {
        public int Id { get; set; }
    }
}
