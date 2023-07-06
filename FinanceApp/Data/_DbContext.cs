using FinanceApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FinanceApp.Data
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options)
            : base(options) 
        {
            
        }

        public DbSet<TestData> testDatas { get; set; }
    }

}
