using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BibliotecaAdmApp.Application.Interfaces;
using BibliotecaAdmApp.Application.Books.Dto;
using BibliotecaAdmApp.Application.Books.Queries;

namespace BibliotecaAdmApp.Application.Books.Handlers
{
    public class FindAllBooksQueryHandler : IRequestHandler<FindAllBooksQuery, List<BookDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;        

        public FindAllBooksQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;           
        }

        public async Task<List<BookDto>> Handle(FindAllBooksQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Books.FindAll();
            return _mapper.Map<List<BookDto>>(result.ToList());            
        }
    }
}
