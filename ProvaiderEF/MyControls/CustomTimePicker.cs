using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF.MyControls
{
    public class CustomTimePicker : DateTimePicker
    {
        private Color textColor = Color.Black;
        private Color backColor = Color.White;

        public Color CustomTextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                Invalidate();
            }
        }

        public Color CustomBackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                Invalidate();
            }
        }

        public CustomTimePicker()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "HH:mm";

            ShowUpDown = true;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                Rectangle biggerRect = new Rectangle(-2, -2, Width + 3, Height + 3);
                e.Graphics.FillRectangle(backBrush, biggerRect);
            }

            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Near; 
                format.LineAlignment = StringAlignment.Center;

                int padding = 18;
                Rectangle paddedRect = new Rectangle(padding, 0, Width - (2 * padding), Height);

                e.Graphics.DrawString(Text, Font, textBrush, paddedRect, format);
            }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            base.OnValueChanged(eventargs);
            Invalidate();
        }
    }

}
