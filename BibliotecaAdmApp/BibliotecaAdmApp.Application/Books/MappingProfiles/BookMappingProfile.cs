using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BibliotecaAdmApp.Application.Books.Commands;
using BibliotecaAdmApp.Application.Books.Dto;
using BibliotecaAdmApp.Core.Entities;

namespace BibliotecaAdmApp.Application.Books.MappingProfiles
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateBookCmd, Book>();
            CreateMap<UpdateBookCmd, Book>();            
        }
    }
}
