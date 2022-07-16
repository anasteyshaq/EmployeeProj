using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeProj
{
    public partial class AddDepartment : Form
    {
        private AppConnection app = new AppConnection();
        public AddDepartment()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            app.openConnection();
            var department = textBoxDepartment.Text;
            var addQuery = $"insert into Departments values ('{department}')";
            var command = new SqlCommand(addQuery, app.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запис створений успішно!");
            app.closeConnection();
            Form.ActiveForm.Close();
        }
    }
}
