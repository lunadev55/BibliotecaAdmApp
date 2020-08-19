using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAdmApp.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IBookRepository Books { get;  }
    }
}
