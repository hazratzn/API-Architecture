using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookListDto>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
        }
    }
}
