using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;
using static WebApi.BookOperations.GetBooks.GetBooksQuery;

namespace WebApi.BookOperations.GetById
{
     
     
    public class GetById 
    {
         private readonly BookStoreDbContext _dbContext; //Buna sadece kurucu metottan erişilebiliyor bu kod sayesinde.
         private readonly IMapper _mapper;
         public int BookId {get; set;}
        public GetById(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public BooksViewModel Handle() {  //Asıl işi yapacak metodum.
        
        var book= _dbContext.Books.Where(book=> book.Id == BookId).SingleOrDefault();

        if(book is null)
        throw new InvalidOperationException("Kitap Bulunamadı");

        BooksViewModel md = _mapper.Map<BooksViewModel>(book);  
        
        //new GetByIdModel();
        //md.Title=book.Title;
        //md.Genre=((GenreEnum)book.GenreId).ToString("dd/MM/yyyy");
        //md.PageCount=book.PageCount;
        //md.PublishDate=book.PublishDate.ToString("dd/MM/yyyy");   //Bu kısımlara ihtiyaç duymuyorum artık bu çevirileri mapper yapacak.
        
        return md;


        }

        public class GetByIdModel {

        
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate {get; set;}
        public string Genre {get; set;}

        }

        
    }

}