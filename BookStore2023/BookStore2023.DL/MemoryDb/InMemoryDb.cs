using BookStore2023.Models.Model;

namespace BookStore2023.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Autor> Autors = new List<Autor>()
        {
            new Autor()
            {
                Birthday = DateTime.Now,
                Id = 1,
                Name = "Autor 1"
            },
             new Autor()
            {
                Birthday = DateTime.Now,
                Id = 2,
                Name = "Autor 2"
            },
              new Autor()
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
                Title = "Title 1"
            },
            new Book()
            {
                Id = 2,
                Title = "Title 2"
            },
            new Book()
            {
                Id= 3,
                Title = "Title 3"
            }
        };
    }
}
