using System;
using FluentValidation;

namespace WebApi.BookOperations.GetById 
{
    public class GetByIdValidator : AbstractValidator<GetById> 
    
    {
        public GetByIdValidator() 
        {
        
        RuleFor(command=>command.BookId).NotNull().GreaterThan(0);
       
        }
    }
}