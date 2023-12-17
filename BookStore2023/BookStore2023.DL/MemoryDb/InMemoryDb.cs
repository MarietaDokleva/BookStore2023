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
    }
}
