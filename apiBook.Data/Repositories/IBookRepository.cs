using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apiBook.Model;

namespace apiBook.Data.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBooksDetail(int id);
        Task<bool> InsertBook(Book book);
        Task<bool> UpdateBook(Book book);
        Task<bool> DeleteBook(Book book);
    }
}
