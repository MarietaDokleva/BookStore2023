using BookStore2023.DL.Interfaces;
using BookStore2023.DL.MemoryDb;
using BookStore2023.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore2023.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            InMemoryDb.Books.Add(book);
        }


        public void Delete(int Id)
        {
            var book = GetById(Id);

            if (book != null)
            {
                InMemoryDb.Books.Remove(book);
            }
        }

        public List<Book> GetAll()
        {
            return InMemoryDb.Books;
        }

        public Book? GetById(int Id)
        {
            return InMemoryDb.Books.FirstOrDefault(a => a.Id == Id);
        }

        public Book? Update(Book book)
        {
            var result = GetById(book.Id);

            if (result != null)
            {
                InMemoryDb.Books.Remove(result);
                Add(book);
                return book;
            }
            return null;
        }
        public List<Book> GetAllByAuthor(int authorId)
        {
            return InMemoryDb.Books
                .Where(b => b.AutorId == authorId)
                .ToList();
        }
    }
}