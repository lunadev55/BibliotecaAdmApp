using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using BibliotecaAdmApp.Application.Books.Dto;

namespace BibliotecaAdmApp.Application.Books.Queries
{
    public class FindAllBooksQuery : IRequest<List<BookDto>>
    {
    }
}
