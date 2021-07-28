using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class BookCheckOutFormModel
    {
        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public DateTime ReturnedDate { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}
