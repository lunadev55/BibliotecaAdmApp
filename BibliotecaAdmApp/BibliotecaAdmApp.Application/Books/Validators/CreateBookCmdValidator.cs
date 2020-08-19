using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using BibliotecaAdmApp.Application.Books.Commands;

namespace BibliotecaAdmApp.Application.Books.Validators
{
    public class CreateBookCmdValidator : AbstractValidator<CreateBookCmd>
    {
        public CreateBookCmdValidator()
        {
            RuleFor(b => b.Category).NotNull();
            RuleFor(b => b.Name).NotNull();
            RuleFor(b => b.Author).NotNull();
            RuleFor(b => b.Pages).NotNull();
            RuleFor(b => b.Status).NotNull();
            

        }
    }
}
