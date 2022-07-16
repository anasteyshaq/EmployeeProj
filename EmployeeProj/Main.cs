using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace EmployeeProj
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Main : Form
    {
        private AppConnection database = new AppConnection();
        private int selectedRow = 0;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewEmployees);
            FillDepartments();
        }

        private void CreateColumns()
        {
            dataGridViewEmployees.Columns.Add("Id", String.Empty);
            dataGridViewEmployees.Columns.Add("fullName", "ПІБ");
            dataGridViewEmployees.Columns.Add("department", "Відділ");
            dataGridViewEmployees.Columns.Add("position", "Посада");
            dataGridViewEmployees.Columns.Add("salary", "Оклад");
            dataGridViewEmployees.Columns.Add("KPI", "Оцінка");
            dataGridViewEmployees.Columns.Add("bonus", "Премія");
            dataGridViewEmployees.Columns.Add("firstName", String.Empty);
            dataGridViewEmployees.Columns.Add("lastName", String.Empty);
            dataGridViewEmployees.Columns.Add("patronymic", String.Empty);
            dataGridViewEmployees.Columns.Add("phone", String.Empty);
            dataGridViewEmployees.Columns.Add("addressLine", String.Empty);
            dataGridViewEmployees.Columns.Add("city", String.Empty);
            dataGridViewEmployees.Columns.Add("rowState", String.Empty);
            dataGridViewEmployees.Columns["Id"].Visible=false;
            dataGridViewEmployees.Columns["firstName"].Visible = false;
            dataGridViewEmployees.Columns["lastName"].Visible = false;
            dataGridViewEmployees.Columns["patronymic"].Visible = false;
            dataGridViewEmployees.Columns["phone"].Visible = false;
            dataGridViewEmployees.Columns["addressLine"].Visible = false;
            dataGridViewEmployees.Columns["city"].Visible = false;
            dataGridViewEmployees.Columns["rowState"].Visible = false;
            dataGridViewEmployees.Columns["fullName"].Width = 160;
            dataGridViewEmployees.Columns["department"].Width = 160;
            dataGridViewEmployees.Columns["position"].Width = 160;
            dataGridViewEmployees.Columns["salary"].Width = 60;
            dataGridViewEmployees.Columns["KPI"].Width = 45;
            dataGridViewEmployees.Columns["bonus"].Width = 65;
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {

            int Id = record.GetInt32(0);
            string firstName = record.GetString(1);
            string lastName = record.GetString(2);
            string patronymic = record.GetString(3);
            string fullName = firstName + " " + lastName + " " + patronymic;
            string phone = record.GetString(4);
            string department = record.GetString(5);
            string position = record.GetString(6);
            decimal salary = Math.Round(record.GetDecimal(7), 2);
            string kpi = record.GetString(8);
            var bonus = Math.Round(CheckBonus(salary, kpi), 2);
            string address = record.GetString(9);
            string city = record.GetString(10);

            dgv.Rows.Add(Id, fullName, department, position, salary, kpi, bonus, firstName,
                lastName, patronymic, phone, address, city, RowState.ModifiedNew);

        }


        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString;
            var depName = comboBoxFilterByDepartment.Text;

            if (depName == String.Empty)
            {
                queryString = "use EmployeesDb " +
                              "SELECT Employees.Id, Employees.FirstName, Employees.LastName, Employees.Patronymic, Phone, " +
                              "Departments.DepartmentName, Positions.PositionName, Employees.Salary, KPIs.KPIName, AddressLine, City " +
                              "FROM Employees " +
                              "JOIN Addresses on Employees.AddressId= Addresses.Id " +
                              "JOIN Positions on Employees.PositionId = Positions.Id " +
                              "JOIN Departments on Positions.DepartmentId = Departments.Id " +
                              "JOIN KPIs on Employees.KPIId = KPIs.Id";
            }
            else
            {
                queryString = "use EmployeesDb " +
                              "SELECT Employees.Id, Employees.FirstName, Employees.LastName, Employees.Patronymic, Phone, " +
                              "Departments.DepartmentName, Positions.PositionName, Employees.Salary, KPIs.KPIName, AddressLine, City " +
                              "FROM Employees " +
                              "JOIN Addresses on Employees.AddressId= Addresses.Id " +
                              "JOIN Positions on Employees.PositionId = Positions.Id " +
                              "JOIN Departments on Positions.DepartmentId = Departments.Id " +
                              "JOIN KPIs on Employees.KPIId = KPIs.Id " +
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
        private void btnEditDpmnt_Click(object sender, EventArgs e)
        {
            EditDepartment editDepartment = new EditDepartment();
            editDepartment.Show();
        }


       
        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row;
            selectedRow = e.RowIndex;
            row = dataGridViewEmployees.Rows[selectedRow];
            EmployeeInfo emp = new EmployeeInfo(row);
            emp.Show();
        }

        private void btnRefreshDgv_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewEmployees);
        }

        private void btnAddEmpl_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void comboBoxFilterByDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           RefreshDataGrid(dataGridViewEmployees);
        }

        private void btnEditPos_Click(object sender, EventArgs e)
        {
            EditPosition editPos = new EditPosition();
            editPos.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            CreateReport();
            MessageBox.Show("Звіт успішно записано у файл!");
        }

        private void CreateReport()
        {
            DateTime todaysDate = DateTime.Now;
            var path = todaysDate.ToFileTime() + ".txt";
            var strDelimeter = ',';
            using (StreamWriter sw = new StreamWriter(path))
            {
                var queryString = "use EmployeesDb " +
                                  "SELECT Employees.Id, Employees.FirstName, Employees.LastName, Employees.Patronymic, Phone, " +
                                  "Departments.DepartmentName, Positions.PositionName, Employees.Salary, KPIs.KPIName, AddressLine, City " +
                                  "FROM Employees " +
                                  "JOIN Addresses on Employees.AddressId= Addresses.Id " +
                                  "JOIN Positions on Employees.PositionId = Positions.Id " +
                                  "JOIN Departments on Positions.DepartmentId = Departments.Id " +
                                  "JOIN KPIs on Employees.KPIId = KPIs.Id " +
                                  "ORDER BY DepartmentName";
                SqlCommand command = new SqlCommand(queryString, database.GetConnection());
                database.openConnection();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string patronymic = reader.GetString(3);
                    string fullName = firstName + " " + lastName + " " + patronymic;
                    string department = reader.GetString(5);
                    string position = reader.GetString(6);
                    decimal salary = Math.Round(reader.GetDecimal(7), 2);
                    string kpi = reader.GetString(8);
                    var bonus = Math.Round(CheckBonus(salary, kpi), 2);
                    sw.Write("ПІБ:" + fullName + strDelimeter);
                    sw.Write("відділ:" + department + strDelimeter);
                    sw.Write("посада:" + position + strDelimeter);
                    sw.Write("оклад:" + salary + strDelimeter);
                    sw.Write("оцінка:" + kpi + strDelimeter);
                    sw.Write("премія:" + bonus);
                    sw.Write("\r\n");
                }
                reader.Close();
            }
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

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Payments salary = new Payments();
            salary.Show();
        }
    }
}

