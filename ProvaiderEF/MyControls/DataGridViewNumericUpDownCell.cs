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
            // Настройка стандартного внешнего вида
            this.Style.Format = "N0";
            this.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            // Получение редактора
            var editingControl = DataGridView.EditingControl as DataGridViewNumericUpDownEditingControl;
            if (editingControl != null)
            {
                // Настройка значений для редактора
                editingControl.Value = (int)this.Value;
                editingControl.Minimum = 0; // Минимальное значение
                                            // Здесь можно добавить другие настройки для элемента NumericUpDown
            }
        }
    }
}
