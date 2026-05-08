namespace CharitizeMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CauseCategory> CauseCategories { get; set; } = new List<CauseCategory>();
    }
}
