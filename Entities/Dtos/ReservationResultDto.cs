using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ReservationResultDto
    {
        public int BusinessDays { get; set; }
        public int PenaltyDays { get; set; }
        public decimal PenaltyAmount { get; set; }
        public decimal TotalPenaltyDays => BusinessDays > PenaltyDays ? BusinessDays - PenaltyDays : 0;
        public string MoneyIcon { get; set; }
    }
}
