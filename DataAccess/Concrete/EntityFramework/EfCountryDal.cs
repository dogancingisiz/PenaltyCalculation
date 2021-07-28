using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCountryDal : ICountryDal
    {
        private readonly PenaltyCalculationContext _context;
        public EfCountryDal(PenaltyCalculationContext context)
        {
            _context = context;
        }

        public List<Country> GetList()
        {
            return _context.Countries.ToList();
        }

        public string GetMoneyIcon(int countryId)
        {
            var country = _context.Countries.FirstOrDefault(x => x.Id == countryId);
            return country == null ? "" : country.MoneyIcon;
        }

        public decimal GetPenaltyAmount(int countryId)
        {
            var country = _context.Countries.FirstOrDefault(x => x.Id == countryId);
            return country == null ? 0 : country.PenaltyAmount;
        }

        public int GetPenaltyDay(int countryId)
        {
            var country = _context.Countries.FirstOrDefault(x => x.Id == countryId);
            return country == null ? 0 : country.PenaltyDay;
        }
    }
}
