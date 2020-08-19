using BibliotecaAdmApp.Application.Interfaces;
using BibliotecaAdmApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAdmApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IBookRepository bookRepository)
        {
            Books = bookRepository;
        }
        public IBookRepository Books { get; set;  }
    }
}
