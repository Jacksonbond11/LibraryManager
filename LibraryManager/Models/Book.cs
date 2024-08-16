

namespace LibraryManager.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public string? Publisher { get; set; }
        public int PublicationYear { get; set; }
        public string? Category { get; set; }
        public string? ShelfLocation { get; set; }
        public int CopiesAvailable { get; set; }

    }

}