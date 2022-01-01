using System;
using System.Linq;
using AutoMapper;
using WebApi.Applications.Entities;
using WebApi.DBOperations;

namespace WebApi.Applications.AuthorOperations.Commands.CreateAuthorCommand  
{    
    public class CreateAuthorCommand 
    {
       private readonly BookStoreDbContext _context;
       private readonly IMapper _mapper;
       public CreateAuthorCommandViewModel Model { get; set; }


        public CreateAuthorCommand(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void Handle() 
        {
        var newobj = _context.Authors.SingleOrDefault(x => x.Name == Model.Name && x.LastName == Model.LastName);
        if(newobj is not null)
        throw new InvalidOperationException("Bu isimde bir yazar zaten kayıtlı");

        newobj=_mapper.Map<Author>(Model);
        _context.Authors.Add(newobj);
        _context.SaveChanges();
        
        }

        public class CreateAuthorCommandViewModel 
        {
        
        public string Name { get; set; }
        public string LastName { get; set; } 
        public DateTime BirthdayDate {get; set;}

        }

    }

}