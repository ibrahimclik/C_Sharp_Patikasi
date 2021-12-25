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
using static WebApi.BookOperations.GetById.GetById;
using static WebApi.BookOperations.UpdateBook.UpdateBookCommand;

namespace WebApi.AddControllers
{

[ApiController]               // Controllerimizin bir http response döndüreceğini belirtme için bunu yapacağız.
[Route("[controller]s")]      // Hangi talebe(request) hangi kaynağın(source) geri dönüş yapacağını belirtmek için bu kısmı yazdık.

public class BookController:ControllerBase 
{

private static List<Book> BookList = new List<Book>(); 

private readonly BookStoreDbContext  _context;

public BookController (BookStoreDbContext context)

{
   _context = context;
}

//new Book {
//  Id=1,
//  Title="Lean StartUP",
//  GenreId=1, //Personal Growth
//  PageCount = 200,
//  PublishDate=new DateTime(2001,06,12)
//},
//
//new Book {
//  Id=2,
//  Title="Herland",
//  GenreId=2, //Science Finction
//  PageCount =250 ,
//  PublishDate=new DateTime(2010,05,23)
//},
//
//new Book {
//  Id=3,
//  Title="Dune",
//  GenreId=2, //Science Finction
//  PageCount =540 ,
//  PublishDate=new DateTime(2002,12,21)
//},
//};

[HttpGet]
public IActionResult GetBooks() {  //Geri dönüş tipi public,geri dönüş türü liste ismi GetBooks olam bir metot tanımladım burada.

  GetBooksQuery query = new GetBooksQuery(_context);
  var result=query.Handle();
  return Ok(result);

}







[HttpGet("{id}")]


public IActionResult GetById(int id) {  //Geri dönüş tipi public,geri dönüş türü book ismi GetById olan bir metot tanımladım burada.

GetByIdModel result;

try {

GetById gbi = new GetById(_context);
gbi.BookId=id;   //Bu rootan almış olduğum id.
result=gbi.Handle();

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

CreateBookCommand command = new CreateBookCommand(_context);

try
{

  command.Model = newBook;
  command.Handle();

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

  DeleteBookCommand cm=new DeleteBookCommand(_context);   //Sınıfın instance'ını oluşturup _context parametresini gönderdik.
  cm.Bookid=id;
  cm.Handle();
     
  }
  catch (Exception ex)
  {
       return BadRequest(ex.Message);
  }

   return Ok();
}
}
}