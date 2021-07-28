using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCountrySpecialHolidayDal : ICountrySpecialDayHolidayDal
    {
        private readonly PenaltyCalculationContext _context;
        public EfCountrySpecialHolidayDal(PenaltyCalculationContext context)
        {
            _context = context;
        }

        public List<CountrySpecialDayHoliday> GetList(int countryId)
        {
            var result = from specialDay in _context.CountrySpecialDayHolidays
                         where specialDay.CountryId == countryId
                         select specialDay;

            return result.ToList();
        }
    }
}
