using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CountrySpecialDayHolidayManager : ICountrySpecialDayHolidayService
    {
        private readonly ICountrySpecialDayHolidayDal _countrySpecialDayHolidayDal;
        public CountrySpecialDayHolidayManager(ICountrySpecialDayHolidayDal countrySpecialDayHolidayDal)
        {
            _countrySpecialDayHolidayDal = countrySpecialDayHolidayDal;
        }

        public List<CountrySpecialDayHoliday> GetList(int countryId)
        {
            return _countrySpecialDayHolidayDal.GetList(countryId);
        }

        public bool IsSpecialDayHoliday(int countryId, DateTime date)
        {
            var dates = GetList(countryId);
            return dates.Any(x => x.Date == date);
        }
    }
}
