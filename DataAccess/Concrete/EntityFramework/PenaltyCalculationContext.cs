using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class PenaltyCalculationContext : DbContext
    {
        public PenaltyCalculationContext(DbContextOptions<PenaltyCalculationContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<SpecialDay> SpecialDays { get; set; }
        public DbSet<CountryWeekendHoliday> CountryWeekendHolidays { get; set; }
        public DbSet<CountrySpecialDayHoliday> CountrySpecialDayHolidays { get; set; }
    }
}
