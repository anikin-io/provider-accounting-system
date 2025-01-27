using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaiderEF
{
    public partial class FormAuthorization : FormAbstractClass
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ProvaiderDbConnection"].ConnectionString;

        public FormAuthorization()
        {
            InitializeComponent();
        }

        #region ДИЗАЙН
        protected override void CustomForm_Load(object sender, EventArgs e)
        {
            base.CustomForm_Load(sender, e);
        }

        private void panelBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void CustomForm_Resize(object sender, EventArgs e)
        {
            base.CustomForm_Resize(sender, e);
        }
        #endregion

        #region ЛОГИКА

        private void AttemptAuthorization()
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            bool isAuthenticated = false;
            string EmployeeType = String.Empty;
            string EmployeeFirstName = String.Empty;
            string EmployeeMiddleName = String.Empty;
            int employeeId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("CheckLoginAndPassword", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Login", login));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                cmd.Parameters.Add(new SqlParameter("@IsAuthenticated", SqlDbType.Bit));
                cmd.Parameters["@IsAuthenticated"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@EmployeeId", SqlDbType.Int)); 
                cmd.Parameters["@EmployeeId"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@EmployeeType", SqlDbType.NVarChar, -1));
                cmd.Parameters["@EmployeeType"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@EmployeeFirstName", SqlDbType.NVarChar, -1));
                cmd.Parameters["@EmployeeFirstName"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@EmployeeMiddleName", SqlDbType.NVarChar, -1));
                cmd.Parameters["@EmployeeMiddleName"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                isAuthenticated = (bool)cmd.Parameters["@IsAuthenticated"].Value;
                employeeId = Convert.ToInt32(cmd.Parameters["@EmployeeId"].Value);
                EmployeeType = cmd.Parameters["@EmployeeType"].Value.ToString();
                EmployeeFirstName = cmd.Parameters["@EmployeeFirstName"].Value.ToString();
                EmployeeMiddleName = cmd.Parameters["@EmployeeMiddleName"].Value != DBNull.Value
                ? cmd.Parameters["@EmployeeMiddleName"].Value.ToString()
                : string.Empty;
            }

            if (isAuthenticated)
            {
                
                switch (EmployeeType)
                {
                    case "Менеджер по продажам":
                        this.Hide();
                        FormMenuManager formMainMenuManager = new FormMenuManager(EmployeeFirstName, EmployeeMiddleName);
                        formMainMenuManager.Show();
                        break;
                    case "Мастер":
                        this.Hide();
                        FormMenuMaster formMenuMaster = new FormMenuMaster(employeeId, EmployeeFirstName, EmployeeMiddleName); 
                        formMenuMaster.Show();
                        break;
                    case "Специалист тех поддержки":
                        this.Hide();

                        break;
                    default:
                        MessageBox.Show("Неизвестный тип сотрудника", "Ошибка авторизации");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации");
            }
        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            AttemptAuthorization();
        }

        private void FormAuthorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AttemptAuthorization();
            }
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AttemptAuthorization();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AttemptAuthorization();
            }
        }
        #endregion
    }
}
