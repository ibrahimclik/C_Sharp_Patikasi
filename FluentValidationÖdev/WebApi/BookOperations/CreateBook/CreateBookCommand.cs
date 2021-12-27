using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.BookOperations.GetBooks;
using WebApi.DBOperations;

namespace WebApi.BookOperations.CreateBook
{
       public class CreateBookCommand {   //Yapacağımız işlem adıyla sınıf oluşturduk.

         public CreateBookModel Model {get; set;}  
         private readonly BookStoreDbContext _dbContext;
         private readonly IMapper _mapper;
        public CreateBookCommand(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Handle() {
         
         var book =_dbContext.Books.SingleOrDefault(x=> x.Title ==Model.Title);

        if (book is not null) {   //Burası sayesinde listemde olan kitap varsa kitap vardır diye hata fırlattım.
        throw new InvalidOperationException("Kitap zaten mevcut");
        } 
        
        book=_mapper.Map<Book>(Model);   //Model ile gelen veriyi book objesine convert et demek bu kod.         //new Book();          //Yeni bir book nesnesi oluşturduk.
       // book.Title=Model.Title;
       // book.GenreId=Model.GenreId;
       // book.PageCount=Model.PageCount;
       // book.PublishDate=Model.PublishDate;
       
        _dbContext.Books.Add(book);
        _dbContext.SaveChanges();

        }  

         public class CreateBookModel {

         public string Title { get; set; } 
         public int GenreId { get; set; }
         public int PageCount { get; set; }

         public DateTime PublishDate { get; set; } 
          
         }
    } 
}