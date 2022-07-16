using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeProj
{
    public partial class EditDepartment : Form
    {
        private int selectedRow;
        private AppConnection appConnection = new AppConnection();
        public EditDepartment()
        {
            InitializeComponent();
        }
        private void EditDepartment_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewDepartments);
        }
        private void CreateColumns()
        {
            dataGridViewDepartments.Columns.Add("Id", String.Empty);
            dataGridViewDepartments.Columns.Add("Department", "Відділ");
            dataGridViewDepartments.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = @"select * from departments";

            SqlCommand command = new SqlCommand(queryString, appConnection.GetConnection());
            appConnection.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();

        }

        private void dataGridViewDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridViewDepartments.Rows[selectedRow];
                textBoxDepartment.Text = row.Cells["Department"].Value.ToString();
            }
        }

        private void btnRefreshDgv_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewDepartments);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddDepartment add = new AddDepartment();
            add.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        
        private void DeleteRow()
        {
            int index = dataGridViewDepartments.CurrentCell.RowIndex;
            dataGridViewDepartments.Rows[index].Visible = false;
            dataGridViewDepartments.Rows[index].Cells["IsNew"].Value = RowState.Deleted;
                return;
        }

        private void UpdateDepartments()
        {
            appConnection.openConnection();
            for (int i = 0; i < dataGridViewDepartments.Rows.Count; i++)
            {
                var rowState = (RowState) dataGridViewDepartments.Rows[i].Cells["IsNew"].Value;
                var id = Convert.ToInt32(dataGridViewDepartments.Rows[i].Cells["Id"].Value);
                var dep = dataGridViewDepartments.Rows[i].Cells["Department"].Value;
                if (rowState == RowState.Existed)
                    continue;
                else if (rowState == RowState.Deleted)
                {
                    var deleteQuery = $"delete from Departments  where Id = {id}";
                    var command = new SqlCommand (deleteQuery, appConnection.GetConnection());
                    command.ExecuteNonQuery();
                }
                else if (rowState == RowState.Modified)
                {
                    var deleteQuery = $"update Departments set departmentName = '{dep}' where Id = {id}";
                    var command = new SqlCommand(deleteQuery, appConnection.GetConnection());
                    command.ExecuteNonQuery();
                }

            }
            appConnection.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewDepartments.CurrentCell.RowIndex;
            var dep = textBoxDepartment.Text;
            if (dataGridViewDepartments.Rows[selectedRowIndex].Cells["Id"].Value.ToString() != String.Empty)
            {
                dataGridViewDepartments.Rows[selectedRowIndex].Cells["Department"].Value = dep;
                dataGridViewDepartments.Rows[selectedRowIndex].Cells["IsNew"].Value = RowState.Modified;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateDepartments();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}
