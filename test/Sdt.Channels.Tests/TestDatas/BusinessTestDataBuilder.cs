using Sdt.Dcs.EntityFrameworkCore;
using Sdt.EntityFrameworkCore;

namespace Sdt.Channels.Tests.TestDatas
{
    public class BusinessTestDataBuilder
    {
        private readonly DcsDbContext _context;
        private readonly int _tenantId;

        public BusinessTestDataBuilder(DcsDbContext context, int tenantId)
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
