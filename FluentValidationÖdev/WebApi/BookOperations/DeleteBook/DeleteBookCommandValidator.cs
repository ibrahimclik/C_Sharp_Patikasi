using System;
using FluentValidation;

namespace WebApi.BookOperations.DeleteBook 
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand> 
    
    {
    public DeleteBookCommandValidator () 
    {
    RuleFor(command=>command.Bookid).GreaterThan(0);
    RuleFor(command=>command.Bookid).NotEmpty();
    }

    }
}