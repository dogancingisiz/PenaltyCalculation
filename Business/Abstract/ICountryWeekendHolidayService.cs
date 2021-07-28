using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountryWeekendHolidayService
    {
        List<CountryWeekendHoliday> GetList(int countryId);
        bool IsWeekendHoliday(int countryId, DateTime date);
    }
}
