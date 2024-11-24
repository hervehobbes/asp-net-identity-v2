using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityNetCore.Data
{
    public class ApplicationDBContext  : IdentityDbContext
    {
        public ApplicationDBContext()
        { }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                _ = optionsBuilder.UseSqlServer("Data Source=.;Database=AspnetIdentityV2;Trusted_Connection=True;Integrated Security=SSPI;Encrypt=False", opt => opt.EnableRetryOnFailure());
            }
        }
    }
}
