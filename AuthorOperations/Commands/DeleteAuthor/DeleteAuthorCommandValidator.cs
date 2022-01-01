using FluentValidation;

namespace WebApi.Applications.AuthorOperations.Commands.DeleteAuthorCommand
{

   public class DeleteAuthorCommandValidator : AbstractValidator<DeleteAuthorCommand> 
   {

      public void DeleteAuthorValidator () 
      {
      
      RuleFor(command => command.AuthorId).NotNull().GreaterThan(0);

      } 

   }

} 