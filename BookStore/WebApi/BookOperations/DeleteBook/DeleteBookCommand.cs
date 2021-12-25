using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.BookOperations.GetBooks;
using WebApi.DBOperations;

namespace WebApi.BookOperations.DeleteBook
{

    public class DeleteBookCommand 
    {
    public int Bookid {get; set;}
    private readonly BookStoreDbContext _dbContext;  
    public DeleteBookCommand(BookStoreDbContext dbContext) 
    {

     _dbContext=dbContext;

    }

    public void Handle() 
    {
    
    var book = _dbContext.Books.SingleOrDefault(x=> x.Id == Bookid);
    if (book is null)
    throw new InvalidOperationException("Bu isimde kitap mevcut değil");

    _dbContext.Remove(book);
    _dbContext.SaveChanges();
    
    }
    }
}