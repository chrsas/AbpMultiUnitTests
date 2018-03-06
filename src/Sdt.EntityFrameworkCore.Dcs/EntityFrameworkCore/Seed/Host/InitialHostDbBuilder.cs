
namespace Sdt.Dcs.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly DcsDbContext _context;

        public InitialHostDbBuilder(DcsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.SaveChanges();
        }
    }
}
