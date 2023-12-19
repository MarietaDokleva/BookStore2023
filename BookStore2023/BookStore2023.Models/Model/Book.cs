namespace BookStore2023.Models.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int AutorId { get; set; }
    }
}