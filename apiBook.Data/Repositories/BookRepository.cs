using apiBook.Model;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiBook.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private SqlServerConfiguration _connectionString;

        public BookRepository(SqlServerConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            var db = dbConnection();
            var sql = @"
                    SELECT id, namebook, descriptionbook, authorbook, publicationdate, numbercopies, cost FROM public.book order by id desc
                ";
            return await db.QueryAsync<Book>(sql, new {  });
        }

        public async Task<Book> GetBooksDetail(int id)
        {
            var db = dbConnection();
            var sql = @"
                    SELECT * FROM public.book
                    WHERE id = @Id
                ";
            return await db.QueryFirstOrDefaultAsync<Book>(sql, new { Id=id});
        }

        public async Task<bool> InsertBook(Book book)
        {
            var db = dbConnection();
            var sql = @"
                    INSERT INTO public.book 
                    (namebook, descriptionbook, authorbook, publicationdate, numbercopies, cost) 
                    VALUES (@NameBook, @DescriptionBook, @AuthorBook, @PublicationDate, @NumberCopies, @Cost)
                ";
            var result = await db.ExecuteAsync(sql, new
            {
                book.NameBook,
                book.Descriptionbook,
                book.Authorbook,
                book.NumberCopies,
                book.PublicationDate,
                book.Cost
            });
            return result > 0;
        }

        public async Task<bool> UpdateBook(Book book)
        {
            var db = dbConnection();
            var sql = @"
                    UPDATE public.book SET 
                    namebook= @NameBook,
                    descriptionbook= @DescriptionBook,
                    authorbook= @AuthorBook,
                    publicationdate= @PublicationDate,
                    numbercopies= @NumberCopies,
                    cost = @Cost
                    WHERE id= @Id
                ";
            var result = await db.ExecuteAsync(sql, new
            {
                book.Id,
                book.NameBook,
                book.Descriptionbook,
                book.Authorbook,
                book.NumberCopies,
                book.PublicationDate,
                book.Cost,
            });
            return result > 0;
        }
        public async Task<bool> DeleteBook(Book book)
        {
            var db = dbConnection();
            var sql = @"
                    DELETE  FROM public.book
                    WHERE id = @Id
                ";
            var result = await db.ExecuteAsync(sql, new { Id = book.Id });
            return result > 0;
        }
    }
}
