using FluentValidation;

namespace WebApi.Applications.AuthorOperations.Queries.GetAuthors 
{
   public class GetAuthorsQueryValidator : AbstractValidator<GetAuthorsQuery>
   {
     public GetAuthorsQueryValidator() 
     {

     RuleFor(command => command.Model.Name).NotNull().MinimumLength(2);
     RuleFor(command => command.Model.LastName).NotNull().MinimumLength(2);
     RuleFor(command => command.Model.BirthdayDate).NotNull(); 
     }    
   }
}