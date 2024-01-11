using BookStore2023.Models.Model;

namespace BookStore2023.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> Autors = new List<Author>()
        {
            new Author()
            {
                Birthday = DateTime.Now,
                Id = 1,
                Name = "Autor 1"
            },
             new Author()
            {
                Birthday = DateTime.Now,
                Id = 2,
                Name = "Autor 2"
            },
              new Author()
            {
                Birthday = DateTime.Now,
                Id = 3,
                Name = "Autor 3"
            }
        };

        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Book 1",
                AutorId = 1,
                ReleaseDate = new DateTime(2005,05,07)
            },
            new Book()
            {
                Id = 4,
                Title = "Book 4",
                AutorId = 1,
                ReleaseDate = new DateTime(2007,05,07)
            },
            new Book()
            {
                Id = 2,
                Title = "Book 2",
                AutorId = 2,
                ReleaseDate = new DateTime(2015,05,07)
            },
            new Book()
            {
                Id = 3,
                Title = "Book 3",
                AutorId = 3,
                ReleaseDate = new DateTime(2010,05,07)
            },
        };
    }
}
