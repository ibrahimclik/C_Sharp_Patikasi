using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetBooks
{
     
     
    public class GetBooksQuery {

        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetBooksQuery(BookStoreDbContext dbContext, IMapper mapper)
        {

            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<BooksViewModel> Handle() {
       
       
       var bookList = _dbContext.Books.OrderBy(x=> x.Id).ToList<Book>();
       List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(bookList);  //Buraya yeni bir liste tanımladım.
       //foreach (var book in bookList)
       //{
       //    vm.Add(new BooksViewModel(){
       //
       //    Title = book.Title,
       //    Genre = ((GenreEnum)book.GenreId).ToString(),  
       //    PublishDate = book.PublishDate.Date.ToString("dd/MM/yyy"),
       //    PageCount = book.PageCount
       //    
       //               });
       //}
       return vm; 

       }       //Burada UI'a döneceğim verisetini viewmodel ile kontrol etmek istiyorum.

       public class BooksViewModel {   //Burada bu sınıfa işleve dışarıdan erişilmesini ancak bunun kontrollü yapılması sağlamam gerekiyor.

       public string Title {get; set;}   

       public int PageCount { get; set; }

       public string PublishDate {get; set;}

       public string  Genre { get; set; }  //Viewmodelde Genre GenreId'ye göre daha kullanışlı olacağı için onu tanımladık.


       }

    }

}