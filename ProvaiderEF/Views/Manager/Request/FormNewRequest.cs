using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaiderEF
{
    public partial class FormNewRequest : FormAbstractClass
    {
        private MyContext dbContext;

        public FormNewRequest()
        {
            InitializeComponent();
            dbContext = new MyContext();
        }

        protected override void CustomForm_Resize(object sender, EventArgs e)
        {
            base.CustomForm_Resize(sender, e);
        }

        protected override void CustomForm_Load(object sender, EventArgs e)
        {
            base.CustomForm_Load(sender, e);
        }

        private void FormNewRequest_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void checkBoxEquipment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEquipment.Checked)
            {
                comboBoxEquipment.Enabled = false;
            }
            else { comboBoxEquipment.Enabled = true; }
        }



    }
}
