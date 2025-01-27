using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class TariffDataFilter : DataFilter<Tariff>
    {
        public TariffDataFilter(IQueryable<Tariff> data) : base(data)
        {
        }

        public override IQueryable<Tariff> Filter(string searchTerm)
        {
            searchTerm = searchTerm.ToLower();
            return data.Where(tariff =>
                tariff.TariffName.ToLower().Contains(searchTerm) ||
                tariff.TariffDescription != null && tariff.TariffDescription.ToLower().Contains(searchTerm) ||
                tariff.PaymentType.ToLower().Contains(searchTerm) ||
                tariff.Speed.ToString().Contains(searchTerm) ||
                tariff.TariffCost.ToString().Contains(searchTerm)
            );
        }
    }
}
