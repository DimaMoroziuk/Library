using LibraryServise.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServise.Data
{
    public class DAL
    {
        private MyDbContext ctx;

        public DAL()
        {
            ctx = new MyDbContext();
        }

        public IQueryable<Book> GetBooks()
        {
            return ctx.Books;
        }
        public IQueryable<Author> GetAuthors()
        {
            return ctx.Authors;
        }
        public IQueryable<Genre> GetGenres()
        {
            return ctx.Genres;
        }
        public void AddAuhor(Author author)
        {
            ctx.Authors.Add(author);
            ctx.SaveChangesAsync();
        }
        public void AddBook(Book book)
        {
            ctx.Books.Add(book);
            ctx.SaveChangesAsync();
        }
        public void AddGenre(Genre genre)
        {
            ctx.Genres.Add(genre);
            ctx.SaveChangesAsync();
        }
    }
}
