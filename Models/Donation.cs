namespace CharitizeMVC.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int CauseId { get; set; }
        public Cause Cause { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        //public int TranscationId { get; set; }
        
        public DateTime DonationDate { get; set; }
    }
}
