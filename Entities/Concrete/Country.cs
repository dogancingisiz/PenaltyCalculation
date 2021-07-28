using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MoneyIcon { get; set; }
        public string Code { get; set; }
        public decimal PenaltyAmount { get; set; }
        public int PenaltyDay { get; set; }
    }
}
