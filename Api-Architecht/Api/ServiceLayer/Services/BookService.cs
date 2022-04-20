using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Book;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository repository, IMapper mapper)
        {
          
            _repository = repository;
            _mapper = mapper;
            
        }

        public async Task CreateAsync(BookCreateDto book)
        {
            var books = _mapper.Map<Book>(book);
            await _repository.CreateAsync(books);
            
        }

    

        public async Task<List<BookListDto>> GetAllAsync()
        {
            var model = await _repository.GetAllAsync();
            var res = _mapper.Map<List<BookListDto>>(model);

            return res;
        }

        public BookListDto Edit(BookListDto book)
        {
           
            var bookss = _mapper.Map<Book>(book);
            _repository.UpdateAsync(bookss);

            return book;
        }
    }
}
