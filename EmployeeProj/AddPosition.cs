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
    public partial class AddPosition : Form
    {
        private AppConnection app = new AppConnection();
        public AddPosition()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            app.openConnection();
            var position = textBoxPosition.Text;
            var department = comboBoxDepartment.Text;
            var depId = GetDepartmentId(department);
            var addQuery = $"insert into Positions values ('{position}',{depId})";
            var command = new SqlCommand(addQuery, app.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запис створений успішно!");
            app.closeConnection();
            Form.ActiveForm.Close();
        }
        int GetDepartmentId(string departmentName)
        {
            int depId = 0;
            string queryString = $"SELECT Id FROM Departments where departmentName = '{departmentName}'";

            SqlCommand command = new SqlCommand(queryString, app.GetConnection());
            app.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    depId = reader.GetInt32(0);
                }

            }
            reader.Close();
            return depId;
        }
        private void FillDepartments()
        {
            string queryString = @"SELECT DepartmentName FROM Departments";

            SqlCommand command = new SqlCommand(queryString, app.GetConnection());
            app.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxDepartment.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void AddPosition_Load(object sender, EventArgs e)
        {
            FillDepartments();
        }
    }
}
