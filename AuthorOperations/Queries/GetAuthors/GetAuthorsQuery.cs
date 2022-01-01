using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.Applications.Entities;
using WebApi.DBOperations;

namespace WebApi.Applications.AuthorOperations.Queries.GetAuthors 
{
      
     public class GetAuthorsQuery 
     {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorsViewModel Model;

        public GetAuthorsQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GetAuthorsViewModel> Handle() 
        {
        var AuthorList = _context.Authors.OrderBy(x=>x.Id).ToList<Author>();
        List<GetAuthorsViewModel> viewmodel=_mapper.Map<List<GetAuthorsViewModel>>(AuthorList);
        return viewmodel;
        }

        public class GetAuthorsViewModel 
        {
        public int Id {get; set;}        
        public string Name { get; set; }
        public string  LastName { get; set; }
        public DateTime BirthdayDate {get; set;}
        
        
        }
    } 
}