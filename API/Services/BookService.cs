using API.Services.Interface;
using Data.MyBookApp;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _BookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _BookRepository=bookRepository;
        }
        public async Task<Guid> AddBook(Book book)
        {
            return await _BookRepository.AddBook(book);
        }

        public async Task<Book> GetBook(Guid Id)
        {
            return await _BookRepository.GetBook(Id);
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _BookRepository.GetBooks();
        }
    }
}
