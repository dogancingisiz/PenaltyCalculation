using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountryService
    {
        List<Country> GetList();
        decimal GetPenaltyAmount(int countryId);
        int GetPenaltyDay(int countryId);
        string GetMoneyIcon(int countryId);
    }
}
