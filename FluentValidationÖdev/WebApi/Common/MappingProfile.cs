using AutoMapper;
using static WebApi.BookOperations.CreateBook.CreateBookCommand;
using static WebApi.BookOperations.GetBooks.GetBooksQuery;

namespace WebApi.Common 
{

   public class MappingProfile : Profile
   {
        public MappingProfile() {  //Bu kurucu metotta configleri,neyin neye dönüşeceğini vereceğim.
        
        CreateMap <CreateBookModel ,Book>();    //Burada ilk kısım kaynak(source) ikinci kısım hedef(source).
        CreateMap <Book, BooksViewModel>().ForMember(dest => dest.Genre, opt=>opt.MapFrom(src=>((GenreEnum)src.GenreId).ToString()));
        CreateMap <Book, BooksViewModel>().ForMember(dest => dest.Genre, opt=>opt.MapFrom(src=>((GenreEnum)src.GenreId).ToString()));

        }
   }
}