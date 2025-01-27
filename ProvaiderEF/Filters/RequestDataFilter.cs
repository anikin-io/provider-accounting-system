using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class RequestDataFilter : DataFilter<Request>
    {
        public RequestDataFilter(IQueryable<Request> data) : base(data)
        {
        }

        public override IQueryable<Request> Filter(string searchTerm)
        {
            searchTerm = searchTerm.ToLower();
            return data.Where(request =>
                (request.PotentialSubscriber.LastName != null && request.PotentialSubscriber.LastName.ToLower().Contains(searchTerm)) ||
                (request.PotentialSubscriber.FirstName != null && request.PotentialSubscriber.FirstName.ToLower().Contains(searchTerm)) ||
                (request.PotentialSubscriber.MiddleName != null && request.PotentialSubscriber.MiddleName.ToLower().Contains(searchTerm)) ||
                (request.PotentialSubscriber.PhoneNumber != null && request.PotentialSubscriber.PhoneNumber.ToLower().Contains(searchTerm)) ||
                (request.PotentialSubscriber.Address != null && request.PotentialSubscriber.Address.ToLower().Contains(searchTerm)) ||
                (request.Tariff.TariffName != null && request.Tariff.TariffName.ToLower().Contains(searchTerm)) ||
                (request.Equipment.Model != null && request.Equipment.Model.ToLower().Contains(searchTerm)) ||
                (request.RequestDate.ToString().Contains(searchTerm)) ||
                (!string.IsNullOrWhiteSpace(request.RequestDescription) && request.RequestDescription.ToLower().Contains(searchTerm)) ||
                (request.RequestStatus.ToLower().Contains(searchTerm))
            );
        }
    }
}
