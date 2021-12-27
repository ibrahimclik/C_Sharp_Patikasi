using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.DeleteBook;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.GetById;
using WebApi.BookOperations.UpdateBook;
using WebApi.DBOperations;
using static WebApi.BookOperations.CreateBook.CreateBookCommand;
using static WebApi.BookOperations.GetBooks.GetBooksQuery;
using static WebApi.BookOperations.UpdateBook.UpdateBookCommand;

namespace WebApi.AddControllers
{

[ApiController]               // Controllerimizin bir http response döndüreceğini belirtme için bunu yapacağız.
[Route("[controller]s")]      // Hangi talebe(request) hangi kaynağın(source) geri dönüş yapacağını belirtmek için bu kısmı yazdık.

public class BookController:ControllerBase 
{

private readonly IMapper _mapper;
private static List<Book> BookList = new List<Book>(); 

private readonly BookStoreDbContext  _context;

        public BookController(BookStoreDbContext context, IMapper mapper)

        {
            _context = context;
            _mapper = mapper;
        }



        [HttpGet]
public IActionResult GetBooks() {  //Geri dönüş tipi public,geri dönüş türü liste ismi GetBooks olam bir metot tanımladım burada.

  GetBooksQuery query = new GetBooksQuery(_context,_mapper);
  var result=query.Handle();
  return Ok(result);

}







[HttpGet("{id}")]


public IActionResult GetById(int id) {  //Geri dönüş tipi public,geri dönüş türü book ismi GetById olan bir metot tanımladım burada.

BooksViewModel result;

try {

GetById command = new GetById(_context,_mapper);
command.BookId=id;   //Bu rootan almış olduğum id.
GetByIdValidator validator=new GetByIdValidator();
ValidationResult vresult=validator.Validate(command);
validator.ValidateAndThrow(command);
result=command.Handle();

}

catch (Exception ex)
{
   return BadRequest(ex.Message);
}

return Ok(result);

//
//   var book= _context.Books.Where(book=> book.Id == id).SingleOrDefault();
//   return book; 
//
}






[HttpPost] 

public IActionResult AddBook([FromBody] CreateBookModel newBook) {

CreateBookCommand command = new CreateBookCommand(_context,_mapper);

try
{

  command.Model = newBook;

  CreateBookCommandValidator validator = new CreateBookCommandValidator(); //Burada CreateBookCommandValidator sınıfın bir instance'ını oluşturduk. 
  validator.ValidateAndThrow(command);
  command.Handle();
  
 // if(!result.IsValid) {
 // foreach (var item in result.Errors)
 // {
 //     Console.WriteLine("Özellik" + item.PropertyName + " Error Message: " + item.ErrorMessage);
 // }
 // }
 // else
 // {
 //   command.Handle();
 // }
  

}
catch (Exception ex)
{
    return BadRequest(ex.Message);
}

return Ok();
}

[HttpPut("{id}")]        //Bu komut sayesinde güncelleme işlemini yapacağımız id'yi belirttik.








public IActionResult UpdateBook(int id,[FromBody] UpdateBookModel updatedBook) {


try
{
UpdateBookCommand command = new UpdateBookCommand(_context);
command.ModelOne= updatedBook;
command.Bookid=id;
UpdateBookCommandValidator validator=new UpdateBookCommandValidator();  //Burada sınıfın bir instance'ını oluşturduk.
ValidationResult result = validator.Validate(command);
validator.ValidateAndThrow(command);

//if(!result.IsValid) 
//{
//
//foreach (var item in result.Errors)
//{
//  Console.WriteLine("Özellik: "+item.PropertyName+" Error Message: "+item.ErrorMessage);
//}
//}
//else 
//{
//} 
command.Handle(); 


     
}
catch (Exception ex)
{
    return BadRequest(ex.Message);
}


return  Ok();




//var book = _context.Books.SingleOrDefault(x=>x.Id == id);
//
//if(book is null) {
//
//return BadRequest();  // Burada book değişkeninin null olması durumunda elimizde güncelleyecek bir veri olmadığı için hata fırlatıyoruz.
//}
//
//book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
//book.PageCount =updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
//book.PublishDate =updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
//book.Title = updatedBook.Title != default != default ? updatedBook.Title : book.Title;
// 
//_context.SaveChanges();  //Bu komutu ekledim çünkü artık bir statik listeyle değil bir veritabanı(DB) ile çalışıyorum.
//
//return Ok();
}





[HttpDelete("{id}")]

public IActionResult DeleteBook(int id)

{

  try
  {

  DeleteBookCommand command=new DeleteBookCommand(_context);   //Sınıfın instance'ını oluşturup _context parametresini gönderdik.
  command.Bookid=id;
  DeleteBookCommandValidator validator=new DeleteBookCommandValidator();
  ValidationResult result = validator.Validate(command);
  validator.ValidateAndThrow(command);

  command.Handle();
     
  }
  catch (Exception ex)
  {
       return BadRequest(ex.Message);
  }

   return Ok();
}
}
}