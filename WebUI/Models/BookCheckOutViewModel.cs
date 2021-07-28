using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class BookCheckOutViewModel
    {
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public int CountryId { get; set; }

        public List<Country> Countries { get; set; }
    }
}
