using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCountryWeekendHolidayDal : ICountryWeekendHolidayDal
    {
        private readonly PenaltyCalculationContext _context;
        public EfCountryWeekendHolidayDal(PenaltyCalculationContext context)
        {
            _context = context;
        }

        public List<CountryWeekendHoliday> GetList(int countryId)
        {
            var result = from weekendHoliday in _context.CountryWeekendHolidays
                         where weekendHoliday.CountryId == countryId
                         select weekendHoliday;

            return result.ToList();
        }
    }
}
