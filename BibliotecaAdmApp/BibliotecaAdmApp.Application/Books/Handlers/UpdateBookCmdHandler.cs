using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BibliotecaAdmApp.Application.Interfaces;
using BibliotecaAdmApp.Application.Books.Commands;

namespace BibliotecaAdmApp.Application.Books.Handlers
{
    public class UpdateBookCmdHandler : IRequestHandler<UpdateBookCmd, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateBookCmdHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {            
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(UpdateBookCmd request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Books.Update(_mapper.Map<BibliotecaAdmApp.Core.Entities.Book>(request));
            return result;
        }
    }
}
