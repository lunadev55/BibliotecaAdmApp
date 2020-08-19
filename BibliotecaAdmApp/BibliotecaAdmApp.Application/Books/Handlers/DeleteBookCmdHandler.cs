using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BibliotecaAdmApp.Application.Interfaces;
using BibliotecaAdmApp.Application.Books.Commands;

namespace BibliotecaAdmApp.Application.Books.Handlers
{
    public class DeleteBookCmdHandler : IRequestHandler<DeleteBookCmd, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public DeleteBookCmdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<int> Handle(DeleteBookCmd request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Books.Delete(request.Id);
        }
    }
}
