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
    public partial class EmployeeInfo : Form
    {
        Employee emp = new Employee();
        private AppConnection database = new AppConnection();
        private DataGridViewRow _row;

        public EmployeeInfo(DataGridViewRow row)
        {
            InitializeComponent();
            this._row = row;
            RefreshData();
            FillDepartments();
            FillKPI();
        }
        private void comboBoxDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            emp.Department = comboBoxDepartment.SelectedItem.ToString();
            comboBoxPosition.Text = string.Empty;
            FillPositions();
        }
        private void RefreshData()
        {
            comboBoxDepartment.Text = _row.Cells["department"].Value.ToString();
            comboBoxPosition.Text = _row.Cells["position"].Value.ToString();
            numericSalary.Value = Convert.ToDecimal(_row.Cells["salary"].Value);
            emp.KPI = comboBoxKPI.Text = _row.Cells["KPI"].Value.ToString();
            textBoxBonus.Text = _row.Cells["bonus"].Value.ToString();
            textBoxFName.Text = _row.Cells["firstName"].Value.ToString();
            textBoxLName.Text = _row.Cells["lastName"].Value.ToString();
            textBoxPatronymic.Text = _row.Cells["patronymic"].Value.ToString();
            textBoxPhone.Text = _row.Cells["phone"].Value.ToString();
            emp.AddressLine = textBoxAddress.Text = _row.Cells["addressLine"].Value.ToString();
            emp.City = textBoxCity.Text = _row.Cells["city"].Value.ToString();
            emp.AddressId = GetAddrId(emp.City, emp.AddressLine);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(_row.Cells[0].Value);
            var deleteQuery = $"delete from Employees where id = {id}";
            var command = new SqlCommand(deleteQuery, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();
            EmployeeInfo.ActiveForm.Close();
            MessageBox.Show("Запис успішно видалено!");
        }

        void Change()
        {
            emp.FirstName = textBoxFName.Text;
            emp.LastName = textBoxLName.Text;
            emp.Patronymic = textBoxPatronymic.Text;
            emp.Department = comboBoxDepartment.Text.ToString();
            emp.Phone = textBoxPhone.Text;
            emp.City = textBoxCity.Text;
            emp.AddressLine = textBoxAddress.Text;
            emp.Position = comboBoxPosition.Text.ToString();
            emp.KPI = comboBoxKPI.Text.ToString();
            emp.Salary = numericSalary.Value;
            emp.Id = Convert.ToInt32(_row.Cells["Id"].Value);
            UpdateAddress();
            var depId = GetDepartmentId(emp.Department);
            emp.PositionId = GetPositionId(emp.Position, depId);
            emp.KPIId = GetKpiId(emp.KPI);
            UpdateEmployee();
            EmployeeInfo.ActiveForm.Close();
            MessageBox.Show("Запис успішно оновлено!");
        }
        private void FillPositions()
        {
            comboBoxPosition.Items.Clear();
            string department = emp.Department;
            string queryString = $"select PositionName from Positions join Departments on DepartmentId = Departments.Id WHERE DepartmentName = '{department}'";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxPosition.Items.Add(reader["PositionName"].ToString());
            }
            reader.Close();
        }
        private void FillDepartments()
        {
            string queryString = @"SELECT DepartmentName FROM Departments";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxDepartment.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void FillKPI()
        {
            string queryString = @"SELECT KPIName FROM KPIs";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxKPI.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }
        int GetAddrId(string city, string addressLine)
        {
            string queryString = $"SELECT Id FROM Addresses where AddressLine = '{addressLine}' and City = '{city}'";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            int AddrId = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AddrId = reader.GetInt32(0);
                }
            }
            reader.Close();
            return AddrId;
        }
        int GetKpiId(string Kpi)
        {
            string queryString = $"SELECT Id FROM KPIs where KPIName = '{Kpi}'";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            int kpiId = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    kpiId = reader.GetInt32(0);
                }

            }

            reader.Close();
            return kpiId;
        }

        void UpdateAddress()
        {
            string queryString = $"update Addresses set city = '{emp.City}', addressLine = '{emp.AddressLine}' where Id = '{emp.AddressId}'";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            command.ExecuteNonQuery();

            database.closeConnection();
        }

        int GetDepartmentId(string departmentName)
        {
            int depId = 0;
            string queryString = $"SELECT Id FROM Departments where departmentName = '{departmentName}'";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

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
        int GetPositionId(string positionName, int depId)
        {
            string queryString = $"SELECT Id FROM Positions where departmentId = '{depId}' and positionName = '{positionName}'";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();


            SqlDataReader reader = command.ExecuteReader();
            var posId = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    posId = reader.GetInt32(0);
                }

            }
            reader.Close();
            return posId;
        }
        void UpdateEmployee()
        {
            string queryString = $"update Employees set FirstName = '{emp.FirstName}', " +
                                 $"LastName = '{emp.LastName}', Patronymic = '{emp.Patronymic}',Salary = '{emp.Salary}'," +
                                 $"Phone = '{emp.Phone}', PositionId = '{emp.PositionId}', KPIId = '{emp.KPIId}' where Id = '{emp.Id}'";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            command.ExecuteNonQuery();

            database.closeConnection();
        }
        private decimal CheckBonus()
        {
            decimal coeff;
            switch (emp.KPI)
            {
                case "A":
                    coeff = 0.2m;
                    break;
                case "B":
                    coeff = 0.3m;
                    break;
                case "C":
                    coeff = 0.4m;
                    break;
                default:
                    coeff = 1.0m;
                    break;
            }
            return emp.Salary - coeff * emp.Salary;
        }
        private void numericSalary_ValueChanged(object sender, EventArgs e)
        {
            emp.Salary = numericSalary.Value;
            textBoxBonus.Text = CheckBonus().ToString();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void comboBoxKPI_SelectionChangeCommitted(object sender, EventArgs e)
        {
            emp.KPI = comboBoxKPI.SelectedItem.ToString();
            textBoxBonus.Text = CheckBonus().ToString();
        }
    }
}

