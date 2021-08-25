using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class HRMContextFactory : DesignTimeDbContextFactoryBase<HRMContext>
    {
        protected override HRMContext CreateNewInstance(DbContextOptions<HRMContext> options)
        {

            return new HRMContext(options);
        }
    }
}
