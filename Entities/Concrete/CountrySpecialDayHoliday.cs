using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CountrySpecialDayHoliday
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int SpecialDayId { get; set; }
        public DateTime Date { get; set; }
    }
}
