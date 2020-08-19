using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BibliotecaAdmApp.Application.Interfaces;
using BibliotecaAdmApp.Application.Books.Dto;
using BibliotecaAdmApp.Application.Books.Queries;

namespace BibliotecaAdmApp.Application.Books.Handlers
{
    public class FindBookByIdQueryHandler : IRequestHandler<FindBookByIdQuery, BookDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FindBookByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {           
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<BookDto> Handle(FindBookByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Books.Get(request.Id);
            return _mapper.Map<BookDto>(result);
        }
    }
}
