using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CountryWeekendHoliday
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int DayOfWeek { get; set; }
    }
}
