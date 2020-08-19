using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using BibliotecaAdmApp.Application.Books.Validators;
using BibliotecaAdmApp.Application.Books.Commands;

namespace BibliotecaAdmApp.Application.Books.Validators
{
    public class UpdateBookCmdValidator : AbstractValidator<UpdateBookCmd>
    {
        public UpdateBookCmdValidator()
        {
            RuleFor(b => b.Category).NotNull();
            RuleFor(b => b.Name).NotNull();
            RuleFor(b => b.Author).NotNull();
            RuleFor(b => b.Pages).NotNull();
            RuleFor(b => b.Status).NotNull();
        }
    }
}
