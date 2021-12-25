using System;
using Microsoft.EntityFrameworkCore;

namespace WebApi.DBOperations {

public class BookStoreDbContext : DbContext {  //Bu sınıfın DbContext olabilmesi için daha önce eklediğimiz paketten kalıtım alması gerekiyor.   
  
  public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) 
  { } 

  public DbSet<Book> Books {get; set; }

        internal object SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

}