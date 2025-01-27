using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class FormAbstractClass: Form
    {
        #region ДИЗАЙН
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        protected extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        protected extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected virtual void CustomForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 33, 74);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        protected virtual void CustomForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        protected void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        protected void RefreshTable<T>(DataGridView dataGridView, DbSet<T> dataSet)
            where T : class
        {
            var data = dataSet.ToList();
            dataGridView.DataSource = data;
        }
    }
}
