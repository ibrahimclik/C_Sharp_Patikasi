using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DBOperations {   //Bu sınıfı oluşturmamda ve kullanmamda ki temel amacım inmemort db'nin başlangıç verilerine sahip olması.

public class DataGenerator {

   public static void Initialize(IServiceProvider serviceProvider) {   //ServiceProvider sayesinde uygulama ilk çalıştığında ayağa kalkacak bir yapı yapıyorum.

       using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>())) {
           
           if(context.Books.Any()) {
           return;
           }

           context.Books.AddRange(
           new Book {
  //Id=1,
  Title="Lean StartUP",
  GenreId=1, //Personal Growth
  PageCount = 200,
  PublishDate=new DateTime(2001,06,12)
},

new Book {
  //Id=2,
  Title="Herland",
  GenreId=2, //Science Finction
  PageCount =250 ,
  PublishDate=new DateTime(2010,05,23)
},

new Book {
  //Id=3,
  Title="Dune",
  GenreId=2, //Science Finction
  PageCount =540 ,
  PublishDate=new DateTime(2002,12,21)
}

   );
   context.SaveChanges(); //Eklediğim üç veriyi kaydet diyorum burada.

   }

   } 
   
 }

}