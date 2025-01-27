using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class EquipmentDataFilter : DataFilter<Equipment>
    {
        public EquipmentDataFilter(IQueryable<Equipment> data) : base(data)
        {
        }

        public override IQueryable<Equipment> Filter(string searchTerm)
        {
            searchTerm = searchTerm.ToLower();
            return data.Where(equipment =>
                equipment.Model != null && equipment.Model.ToLower().Contains(searchTerm) ||
                
                equipment.SellingCost.ToString().Contains(searchTerm)
            );
        }
    }
}
