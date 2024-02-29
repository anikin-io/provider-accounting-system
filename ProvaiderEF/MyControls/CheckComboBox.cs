using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProvaiderEF.MyControls
{
    public class CheckComboBox: ComboBox
    {
        public class CheckComboBoxItem
        {
            public CheckComboBoxItem(string text, bool initialCheckState)
            {
                _checkState = initialCheckState;
                _text = text;
            }

            private bool _checkState = false;
            public bool CheckState
            {
                get { return _checkState; }
                set { _checkState = value; }
            }

            private string _text = "";
            public string Text
            {
                get { return _text; }
                set { _text = value; }
            }

            private object _tag = null;
            public object Tag
            {
                get { return _tag; }
                set { _tag = value; }
            }
            public override string ToString()
            {
                return "Select Options";
            }
        }
        public CheckComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DrawItem += new DrawItemEventHandler(CheckComboBox_DrawItem);
            this.SelectedIndexChanged += new EventHandler(CheckComboBox_SelectedIndexChanged);
            SelectedText = "Select Options";
        }

        void CheckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxItem item = (CheckComboBoxItem)SelectedItem;
            item.CheckState = !item.CheckState;
            if (CheckStateChanged != null)
                CheckStateChanged(item, e);
        }

        void CheckComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }

            if (!(Items[e.Index] is CheckComboBoxItem))
            {
                e.Graphics.DrawString(
                    Items[e.Index].ToString(),
                    this.Font,
                    Brushes.Black,
                    new Point(e.Bounds.X, e.Bounds.Y));
                return;
            }

            CheckComboBoxItem box = (CheckComboBoxItem)Items[e.Index];
            CheckBoxRenderer.RenderMatchingApplicationState = true;
            CheckBoxRenderer.DrawCheckBox(
                e.Graphics,
                new Point(e.Bounds.X, e.Bounds.Y),
                e.Bounds,
                box.Text,
                this.Font,
                (e.State & DrawItemState.Focus) == 0,
                box.CheckState ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);
        }

        public event EventHandler CheckStateChanged;
    }
}
