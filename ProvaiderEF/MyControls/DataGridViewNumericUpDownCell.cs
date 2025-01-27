using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class DataGridViewNumericUpDownCell : DataGridViewTextBoxCell
    {
        public override Type EditType => typeof(DataGridViewNumericUpDownEditingControl);
        public override Type ValueType => typeof(int);
        public override object DefaultNewRowValue => 0;
        public DataGridViewNumericUpDownCell() : base()
        {
            this.Style.Format = "N0";
            this.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            var editingControl = DataGridView.EditingControl as DataGridViewNumericUpDownEditingControl;
            if (editingControl != null)
            {
                editingControl.Value = (int)this.Value;
                editingControl.Minimum = 0;                                            
            }
        }
    }
}
