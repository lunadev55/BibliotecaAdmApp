using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MediatR;
using System.Threading.Tasks;
using BibliotecaAdmApp.Application.Interfaces;
using BibliotecaAdmApp.Application.Books.Commands;
using System.Threading;

namespace BibliotecaAdmApp.Application.Books.Handlers
{
    public class CreateBookCmdHandler : IRequestHandler<CreateBookCmd, int>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;   

        public CreateBookCmdHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;            
        }

        public async Task<int> Handle(CreateBookCmd request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Books.Add(_mapper.Map<BibliotecaAdmApp.Core.Entities.Book>(request));
        }
    }
}
