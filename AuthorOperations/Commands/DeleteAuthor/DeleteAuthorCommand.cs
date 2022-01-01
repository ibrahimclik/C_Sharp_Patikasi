using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Applications.AuthorOperations.Commands.DeleteAuthorCommand
{
    public class DeleteAuthorCommand 
    {
        private readonly BookStoreDbContext _context;
        public int AuthorId { get; set; }
       
        public DeleteAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }


        public void Handle() 
        {
        
        var obj = _context.Authors.SingleOrDefault(x => x.Id == AuthorId); 
        if(obj is null) 
        {
        throw new InvalidOperationException("Bu id ile eşleşen bir yazar bulunmamaktadır");
        }
        _context.Remove(obj);
        _context.SaveChanges();

        }

    }

}