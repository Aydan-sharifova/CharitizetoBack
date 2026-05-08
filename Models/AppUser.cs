using CharitizeMVC.Enums;

namespace CharitizeMVC.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; } = Role.User;
        public DateTime CreatedAt { get; set; }
        public ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();
        public ICollection<Donation> Donations { get; set; } = new List<Donation>();

    }
}
