using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        private readonly ICountryDal _countryDal;
        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public List<Country> GetList()
        {
            return _countryDal.GetList();
        }

        public string GetMoneyIcon(int countryId)
        {
            return _countryDal.GetMoneyIcon(countryId);
        }

        public decimal GetPenaltyAmount(int countryId)
        {
            return _countryDal.GetPenaltyAmount(countryId);
        }

        public int GetPenaltyDay(int countryId)
        {
            return _countryDal.GetPenaltyDay(countryId);
        }
    }
}
