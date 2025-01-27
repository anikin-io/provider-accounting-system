using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaiderEF
{
    public partial class FormNewTariff : FormAbstractClass
    {
        public FormNewTariff()
        {
            InitializeComponent();
        }

        #region ДИЗАЙН
        private void FormNewTariff_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void CustomForm_Load(object sender, EventArgs e)
        {
            base.CustomForm_Load(sender, e);
        }
        protected override void CustomForm_Resize(object sender, EventArgs e)
        {
            base.CustomForm_Resize(sender, e);
        }
        #endregion


    }
}
