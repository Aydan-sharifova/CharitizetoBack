namespace CharitizeMVC.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Profession { get; set; }
        public string CommentText { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
