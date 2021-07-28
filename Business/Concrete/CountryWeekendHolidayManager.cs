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
    public class CountryWeekendHolidayManager : ICountryWeekendHolidayService
    {
        private readonly ICountryWeekendHolidayDal _countryWeekendHolidayDal;
        public CountryWeekendHolidayManager(ICountryWeekendHolidayDal countryWeekendHolidayDal)
        {
            _countryWeekendHolidayDal = countryWeekendHolidayDal;
        }

        public List<CountryWeekendHoliday> GetList(int countryId)
        {
            return _countryWeekendHolidayDal.GetList(countryId);
        }

        public bool IsWeekendHoliday(int countryId, DateTime date)
        {
            var result = GetList(countryId);

            int dayOfWeek = (int)(date.DayOfWeek);
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                dayOfWeek = 7;
            }

            return result.Any(x => x.DayOfWeek == dayOfWeek);
        }
    }
}
