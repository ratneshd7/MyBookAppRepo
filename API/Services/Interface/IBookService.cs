using Data.MyBookApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IBookService
    {
        Task<Book> GetBook(Guid Id);
        Task<Guid> AddBook(Book book);
        Task<List<Book>> GetBooks();
    }
}
