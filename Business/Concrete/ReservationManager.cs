using Business.Abstract;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly ICountryWeekendHolidayService _countryWeekendHolidayService;
        private readonly ICountrySpecialDayHolidayService _countrySpecialDayHolidayService;
        private readonly ICountryService _countryService;
        public ReservationManager(ICountryWeekendHolidayService countryWeekendHolidayService, ICountrySpecialDayHolidayService countrySpecialDayHolidayService, ICountryService countryService)
        {
            _countryWeekendHolidayService = countryWeekendHolidayService;
            _countrySpecialDayHolidayService = countrySpecialDayHolidayService;
            _countryService = countryService;
        }

        public ReservationResultDto GetReservationInfo(DateTime checkOutDate, DateTime returnedDate, int countryId)
        {
            if (returnedDate <= checkOutDate)
            {
                return new ReservationResultDto();
            }

            int reservationBusinessDays = GetReservationBusinessDays(countryId, checkOutDate, returnedDate);
            decimal penaltyAmount = _countryService.GetPenaltyAmount(countryId);
            int penaltyDay = _countryService.GetPenaltyDay(countryId);

            decimal calculatePenalty = CalculatePenalty(reservationBusinessDays, penaltyDay, penaltyAmount);

            string moneyIcon = _countryService.GetMoneyIcon(countryId);

            return new ReservationResultDto
            {
                BusinessDays = reservationBusinessDays,
                PenaltyAmount = calculatePenalty,
                PenaltyDays = penaltyDay,
                MoneyIcon = moneyIcon
            };


        }

        public int GetReservationBusinessDays(int countryId, DateTime checkOutDate, DateTime returnedDate)
        {
            int days = 0;

            while (checkOutDate <= returnedDate)
            {
                if (_countryWeekendHolidayService.IsWeekendHoliday(countryId, checkOutDate) == false)
                {
                    if (_countrySpecialDayHolidayService.IsSpecialDayHoliday(countryId, checkOutDate) == false)
                    {
                        days++;
                    }
                }

                checkOutDate = checkOutDate.AddDays(1);
            }

            return days;
        }

        public decimal CalculatePenalty(int businessDays, int penaltyDay, decimal penaltyAmout)
        {
            if (businessDays > penaltyDay)
            {
                return (businessDays - penaltyDay) * penaltyAmout;
            }
            return 0;
        }
    }
}
