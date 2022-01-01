using System;
using FluentValidation;

namespace WebApi.Applications.AuthorOperations.Commands.CreateAuthorCommand 
{

    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand> 
    {
    
       public void CreateAuthorValidator() 
       { 

       RuleFor(command => command.Model.Name).NotNull().MinimumLength(2);
       RuleFor(command => command.Model.BirthdayDate).NotNull().LessThan(DateTime.Now.Date);
       RuleFor(command => command.Model.LastName).NotNull().MinimumLength(2);
      
       }
    }
}