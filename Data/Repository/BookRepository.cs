using Data.MyBookApp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly MyBookAppDBContext _myBookAppDBContext;
        public BookRepository(MyBookAppDBContext myBookAppDBContext)
        {
            _myBookAppDBContext = myBookAppDBContext;
        }
        public async Task<Guid> AddBook(Book book)
        {
            _myBookAppDBContext.Books.Add(book);
            await _myBookAppDBContext.SaveChangesAsync();
            return book.Id;
        }

        public async Task<Book> GetBook(Guid Id)
        {
            return await _myBookAppDBContext.Books.AsNoTracking().FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _myBookAppDBContext.Books.ToListAsync();
        }
    }
}
