using System;
using FluentValidation;

namespace WebApi.BookOperations.CreateBook 
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand> 
    
    {
    
        public CreateBookCommandValidator ()
        
        { 

        RuleFor(command => command.Model.GenreId).GreaterThan(0);    //Bu komut sayesinde ben genre.id'yi korumuş olurum bu sayede genreid sıfırdan küçük ya da eşit olamaz.
        RuleFor(command => command.Model.PageCount).GreaterThan(0);  //Yine bir üstte bulunan ile aynı mantıkla olup sayfa sayısının sıfırdan küçük olmasını engeller.
        RuleFor(command => command.Model.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);  //Saat hem bugünden önce olmalıdır hem de boş olmamalıdır.
        RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(4);  //Saat hem bugünden önce olmalıdır hem de boş olmamalıdır.
        
        }

    }

}