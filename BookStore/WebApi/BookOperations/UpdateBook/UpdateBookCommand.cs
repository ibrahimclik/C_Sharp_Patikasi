using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.BookOperations.GetBooks;
using WebApi.DBOperations;

namespace WebApi.BookOperations.UpdateBook
{

     public class UpdateBookCommand 
     {
        public UpdateBookModel ModelOne {get; set;}
        public int Bookid {get; set;}
        private readonly BookStoreDbContext _dbContext;
    

    public UpdateBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
         
        public void Handle() 
        {
           var book = _dbContext.Books.SingleOrDefault(x => x.Id == Bookid);
           if(book is null) {
           throw new InvalidOperationException("Bu isimde kitap mevcut değil");  }

          
           book.GenreId = ModelOne.GenreId != default ? ModelOne.GenreId : book.GenreId;
           book.Title = ModelOne. Title != default ? ModelOne.Title : book.Title;

           _dbContext.SaveChanges();
        }

        public class UpdateBookModel
        {
        
        
        public string Title { get; set; }
        public int GenreId { get; set; }
        
        }
    }

}