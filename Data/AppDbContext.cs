using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharitizeMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
