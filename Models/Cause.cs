namespace CharitizeMVC.Models
{
    public class Cause
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal GoalAmount { get; set; }
        public decimal RaisedAmount { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public ICollection<Cause> Causes { get; set; } = new List<Cause>();
        public ICollection<Donation> Donations { get; set; } = new List<Donation>();


    }
}
