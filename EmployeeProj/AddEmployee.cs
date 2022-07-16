using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeProj
{
    public partial class AddEmployee : Form
    {
        private AppConnection database = new AppConnection();
        private Employee employee = new Employee();

        public AddEmployee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            FillDepartments();
            FillKPI();
        }
        private void FillPositions()
        {
            comboBoxPosition.Items.Clear();
            string department = employee.Department;
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

        private void comboBoxDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            employee.Department = comboBoxDepartment.SelectedItem.ToString();
            comboBoxPosition.Text = string.Empty;
            FillPositions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database.openConnection();
            employee.FirstName = textBoxFirstName.Text;
            employee.LastName = textBoxLastName.Text;
            employee.Patronymic = textBoxPatronymic.Text;
            employee.AddressLine = TextBoxAddressLine.Text;
            employee.City = textBoxCity.Text;
            employee.Phone = textBoxPhone.Text;
            employee.Department = comboBoxDepartment.SelectedItem.ToString();
            employee.KPI = comboBoxKPI.SelectedItem.ToString();
            employee.Position = comboBoxPosition.SelectedItem.ToString();
            employee.Salary = numSalary.Value;
            var depId = GetDepartmentId(employee.Department);
            employee.PositionId = GetPositionId(employee.Position, depId);
            employee.KPIId = GetKpiId(employee.KPI);
            CreateAddress(employee.City, employee.AddressLine);
            employee.AddressId = GetAddrId(employee.City, employee.AddressLine);
            CreateEmployee();
            AddEmployee.ActiveForm.Close();
            MessageBox.Show("Запис успішно був створений");
            //получить positionId --> вставить его в таблицу Employee

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

        void CreateAddress(string city, string addressLine)
        {
            string queryString = $"insert into Addresses values ('{city}', '{addressLine}')";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            command.ExecuteNonQuery();

            database.closeConnection();
        }
        void CreateEmployee()
        {
            string queryString = $"insert into Employees values ('{employee.FirstName}', " +
                                 $"'{employee.LastName}', '{employee.Patronymic}','{employee.Salary}'," +
                                 $"'{employee.Phone}', '{employee.AddressId}','{employee.PositionId}', '{employee.KPIId}')";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            command.ExecuteNonQuery();

            database.closeConnection();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
