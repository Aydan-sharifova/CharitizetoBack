namespace CharitizeMVC.Models
{
    public class CauseCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int CauseId { get; set; }
        public Cause? Cause { get; set; }
        public ICollection<Donation>Donations { get; set; }
    }
}
