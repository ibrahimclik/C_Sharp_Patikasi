using FluentValidation;

namespace WebApi.Applications.AuthorOperations.Queries.GetAuthors 
{
   public class GetAuthorDetailQuaryValidator:AbstractValidator<GetAuthorDetailQuery> 
   {
   
    public GetAuthorDetailQuaryValidator() 
    {

    RuleFor(command => command.AuthorId).NotNull().GreaterThan(0);

    }

   }
}