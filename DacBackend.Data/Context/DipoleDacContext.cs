using Microsoft.EntityFrameworkCore;

namespace DacBackend.Data.Context
{
    public class DipoleDacContext : DbContext
    {
        public DipoleDacContext(DbContextOptions<DipoleDacContext> options) : base(options)
        {

        }
    }
}
