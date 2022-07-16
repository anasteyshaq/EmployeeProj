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
    public partial class EditPosition : Form
    {
        private AppConnection appConnection = new AppConnection();
        private int selectedRow;
        public EditPosition()
        {
            InitializeComponent();
        }
        private void EditPosition_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewPositions);
            FillDepartments();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddPosition add = new AddPosition();
            add.Show();
        }

        private void CreateColumns()
        {
            dataGridViewPositions.Columns.Add("Id", String.Empty);
            dataGridViewPositions.Columns.Add("Department", "Відділ");
            dataGridViewPositions.Columns.Add("Position", "Посада");
            dataGridViewPositions.Columns.Add("DepartmentId", String.Empty);
            dataGridViewPositions.Columns.Add("IsNew", String.Empty);
           
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = @"select positions.id, departments.departmentname, positions.positionname, positions.departmentId
from positions join departments on departments.Id = positions.departmentId";

            SqlCommand command = new SqlCommand(queryString, appConnection.GetConnection());
            appConnection.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();

        }

        private void btnRefreshDgv_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewPositions);
        }


        private void dataGridViewPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridViewPositions.Rows[selectedRow];
                comboBoxDepartment.Text = row.Cells["Department"].Value.ToString();
                textBoxPosition.Text = row.Cells["Position"].Value.ToString();
            }
        }

        private void FillDepartments()
        {
            string queryString = @"SELECT DepartmentName FROM Departments";

            SqlCommand command = new SqlCommand(queryString, appConnection.GetConnection());
            appConnection.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxDepartment.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }
        private void DeleteRow()
        {
            int index = dataGridViewPositions.CurrentCell.RowIndex;
            dataGridViewPositions.Rows[index].Visible = false;
            dataGridViewPositions.Rows[index].Cells["IsNew"].Value = RowState.Deleted;
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void UpdatePositions()
        {
            appConnection.openConnection();
            for (int i = 0; i < dataGridViewPositions.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridViewPositions.Rows[i].Cells["IsNew"].Value;
                var posName = dataGridViewPositions.Rows[i].Cells["Position"].Value;
                var id = Convert.ToInt32(dataGridViewPositions.Rows[i].Cells["Id"].Value);
                var depId = Convert.ToInt32(dataGridViewPositions.Rows[i].Cells["DepartmentId"].Value);
                if (rowState == RowState.Existed)
                    continue;
                else if (rowState == RowState.Deleted)
                {
                    var deleteQuery = $"delete from Positions where Id = {id}";
                    var command = new SqlCommand(deleteQuery, appConnection.GetConnection());
                    command.ExecuteNonQuery();
                }
                else if (rowState == RowState.Modified)
                {
                    var deleteQuery = $"update Positions set positionName = '{posName}', departmentId = '{depId}' where Id = {id}";
                    var command = new SqlCommand(deleteQuery, appConnection.GetConnection());
                    command.ExecuteNonQuery();
                }

            }
            appConnection.closeConnection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Change();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridViewPositions.CurrentCell.RowIndex;
            var dep = comboBoxDepartment.Text;
            var pos = textBoxPosition.Text;
            if (dataGridViewPositions.Rows[selectedRowIndex].Cells["Id"].Value.ToString() != String.Empty)
            {
                dataGridViewPositions.Rows[selectedRowIndex].Cells["Position"].Value = pos;
                dataGridViewPositions.Rows[selectedRowIndex].Cells["Department"].Value = dep;
                dataGridViewPositions.Rows[selectedRowIndex].Cells["IsNew"].Value = RowState.Modified;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePositions();
        }
    }
}
