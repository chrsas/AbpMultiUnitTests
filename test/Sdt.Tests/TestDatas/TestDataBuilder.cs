using Sdt.EntityFrameworkCore;

namespace Sdt.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly SdtDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(SdtDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.SaveChanges();
        }
    }
}
