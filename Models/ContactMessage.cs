namespace CharitizeMVC.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public DateTime SendAt { get; set; }

    }
}
