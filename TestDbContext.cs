using Microsoft.EntityFrameworkCore;

namespace NZFM.Common.Web
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }

        public DbSet<MockTable> MockTables => Set<MockTable>();
    }

    public class MockTable
    {
        public System.Guid Id { get; set; }
        public string Description { get; set; }
    }
}
