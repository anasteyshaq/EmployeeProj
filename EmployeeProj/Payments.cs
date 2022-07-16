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
    public partial class Payments : Form
    {
        private AppConnection database = new AppConnection();
        public Payments()
        {
            InitializeComponent();
            FillDepartments();
            CreateColumns();
            RefreshDataGrid(dataGridViewPayments);
        }
        private void CreateColumns()
        {
            dataGridViewPayments.Columns.Add("Id", String.Empty);
            dataGridViewPayments.Columns.Add("fullName", "ПІБ");
            dataGridViewPayments.Columns.Add("department", String.Empty);
            dataGridViewPayments.Columns.Add("position", String.Empty);
            dataGridViewPayments.Columns.Add("salary", String.Empty);
            dataGridViewPayments.Columns.Add("KPI", String.Empty);
            dataGridViewPayments.Columns.Add("bonus", String.Empty);
            dataGridViewPayments.Columns.Add("firstName", String.Empty);
            dataGridViewPayments.Columns.Add("lastName", String.Empty);
            dataGridViewPayments.Columns.Add("patronymic", String.Empty);
            dataGridViewPayments.Columns.Add("payments", "Заробітна плата");
            dataGridViewPayments.Columns["Id"].Visible=false;
            dataGridViewPayments.Columns["department"].Visible = false;
            dataGridViewPayments.Columns["position"].Visible = false;
            dataGridViewPayments.Columns["salary"].Visible = false;
            dataGridViewPayments.Columns["KPI"].Visible = false;
            dataGridViewPayments.Columns["bonus"].Visible = false;
            dataGridViewPayments.Columns["firstName"].Visible = false;
            dataGridViewPayments.Columns["lastname"].Visible = false;
            dataGridViewPayments.Columns["patronymic"].Visible = false;
            dataGridViewPayments.Columns["fullName"].Width= 250;
            dataGridViewPayments.Columns["payments"].Width = 238;

        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            int Id = record.GetInt32(0);
            string firstName = record.GetString(1);
            string lastName = record.GetString(2);
            string patronymic = record.GetString(3);
            string fullName = firstName + " " + lastName + " " + patronymic;
            string department = record.GetString(4);
            string position = record.GetString(5);
            decimal salary = Math.Round(record.GetDecimal(6), 2);
            string kpi = record.GetString(7);
            var bonus = Math.Round(CheckBonus(salary, kpi), 2);
            var payments = salary + bonus;
            dgv.Rows.Add(Id, fullName, department, position, salary, kpi, bonus, firstName,
                lastName, patronymic, payments);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString;
            var depName = comboBoxFilterByDepartment.Text;

            if (depName == String.Empty)
            {
                queryString = "use EmployeesDb " +
                              "SELECT Employees.Id, Employees.FirstName, Employees.LastName, Employees.Patronymic, " +
                              "Departments.DepartmentName, Positions.PositionName, Employees.Salary, KPIs.KPIName " +
                              "FROM Employees " +
                              "JOIN Positions on Employees.PositionId = Positions.Id " +
                              "JOIN Departments on Positions.DepartmentId = Departments.Id " +
                              "JOIN KPIs on Employees.KPIId = KPIs.Id";
            }
            else
            {
                queryString = "use EmployeesDb " +
                              "SELECT Employees.Id, Employees.FirstName, Employees.LastName, Employees.Patronymic, " +
                              "Departments.DepartmentName, Positions.PositionName, Employees.Salary, KPIs.KPIName " +
                              "FROM Employees " +
                              "JOIN Positions on Employees.PositionId = Positions.Id " +
                              "JOIN Departments on Positions.DepartmentId = Departments.Id " +
                              "JOIN KPIs on Employees.KPIId = KPIs.Id "+
                              $"where Departments.DepartmentName = '{depName}' ";
            }

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private void FillDepartments()
        {
            string queryString = @"SELECT DepartmentName FROM Departments";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            comboBoxFilterByDepartment.Items.Add(String.Empty);
            while (reader.Read())
            {
                comboBoxFilterByDepartment.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private decimal CheckBonus(decimal salary, string kpi)
        {
            decimal coeff;
            decimal bonus;
            switch (kpi)
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
                    throw new ArgumentException();
            }
            bonus = salary - coeff * salary;
            return bonus;
        }

        private void comboBoxFilterByDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewPayments);
        }

        private void btnRefreshDgv_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewPayments);
        }
    }
}
