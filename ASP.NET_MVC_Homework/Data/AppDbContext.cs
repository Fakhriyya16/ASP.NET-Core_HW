using ASP.NET_MVC_Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_Homework.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderBackgroundImg> SliderBackgroundImgs { get; set; }
    }
}
