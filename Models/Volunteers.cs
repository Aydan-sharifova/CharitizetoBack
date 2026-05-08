namespace CharitizeMVC.Models
{
    public class Volunteers
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skill { get; set; }
        public int ExperienceYear { get; set; }
        public string MotivationLetter { get; set; }
        public DateTime AppliedAt { get; set; }

    }
}
