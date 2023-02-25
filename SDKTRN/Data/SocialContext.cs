using Microsoft.EntityFrameworkCore;
using SDKTRN.Models;

namespace SDKTRN.Data
{
    public class SocialContext : DbContext
    {
        public SocialContext(DbContextOptions<SocialContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
