using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Applications.AuthorOperations.Queries.GetAuthors
{

    public class GetAuthorDetailQuery 
     { 
        public int AuthorId {get; set;} 
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetAuthorDetailQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GetAuthorsDetailViewModel Handle() 
        {

        var author = _context.Authors.SingleOrDefault(x=> x.Id == AuthorId);
        if(author is null) {
        throw new InvalidOperationException("Yazar Bulunamadı");
        }
        
        return _mapper.Map<GetAuthorsDetailViewModel>(author);

        }

        public class GetAuthorsDetailViewModel 
        {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string  LastName { get; set; }
        public DateTime BirthdayDate {get; set;}
        
        
        }
    } 
}