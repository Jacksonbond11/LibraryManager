namespace LibraryManager.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password_hash { get; set; }
        public int library_card_number { get; set; }
        public double fine_balance { get; set; }
    }
}