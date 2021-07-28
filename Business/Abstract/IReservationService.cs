using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReservationService
    {
        ReservationResultDto GetReservationInfo(DateTime checkOutDate, DateTime returnedDate, int countryId);
        int GetReservationBusinessDays(int countryId, DateTime checkOutDate, DateTime returnedDate);
        decimal CalculatePenalty(int businessDays, int penaltyDay, decimal penaltyAmout);
    }
}
