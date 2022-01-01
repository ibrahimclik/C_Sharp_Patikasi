using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Applications.AuthorOperations.Commands.UpdateAuthor 
{

     public class UpdateAuthorCommand 
     
     {
        public int AuthorId { get; set; }
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public UpdateAuthorCommandViewModel Model { get; set; }
        public UpdateAuthorCommand(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public void Handle() 
        {
           var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
           if(author is null) {
           throw new InvalidOperationException("Bu id numarasına sahip yazar mevcut değil");  }

          
           author.Name = Model.Name != default ? Model.Name : author.Name;
           author.LastName = Model. LastName != default ? Model.LastName : author.LastName;
           author.BirthdayDate=Model.BirthdayDate != default ? Model.BirthdayDate : author.BirthdayDate;

           _context.SaveChanges();
        }
        
        
        public class UpdateAuthorCommandViewModel 
        {

        public string Name { get; set; }  
        public string LastName { get; set; }
        public DateTime BirthdayDate {get; set;}

        }

    }

}