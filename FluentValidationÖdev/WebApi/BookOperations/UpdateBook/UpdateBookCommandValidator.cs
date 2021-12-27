using FluentValidation;

namespace WebApi.BookOperations.UpdateBook 
{

  public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>  //Bu sınıfı validation sınıfı yapmak için bu kalıtım işlemini yapmamız gerekir.
  {
      public UpdateBookCommandValidator() 
      {
          RuleFor(command=>command.ModelOne.GenreId).GreaterThan(0);
          RuleFor(command=>command.ModelOne.Title).NotEmpty().MinimumLength(4);
      }
   
  }

}