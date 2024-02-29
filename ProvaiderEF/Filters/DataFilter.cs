using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class DataFilter<T>
    {
        protected IQueryable<T> data;

        public DataFilter(IQueryable<T> data)
        {
            this.data = data;
        }

        public virtual IQueryable<T> Filter(string searchTerm)
        {
            return data;
        }

        public void FilterDataGridView(DataGridView dataGridView, string searchTerm)
        {
            var filteredData = Filter(searchTerm).ToList();
            dataGridView.DataSource = filteredData;
        }
    }
}
