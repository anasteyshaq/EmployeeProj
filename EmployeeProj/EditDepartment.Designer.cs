namespace EmployeeProj
{
    partial class EditDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefreshDgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AllowUserToAddRows = false;
            this.dataGridViewDepartments.AllowUserToDeleteRows = false;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.ReadOnly = true;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(362, 261);
            this.dataGridViewDepartments.TabIndex = 8;
            this.dataGridViewDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartments_CellClick);
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(487, 73);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(256, 20);
            this.textBoxDepartment.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(380, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Назва відділу:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(19, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 46);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Новий запис";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Location = new System.Drawing.Point(560, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 231);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управління записами";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 46);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(19, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 46);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(19, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 46);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefreshDgv
            // 
            this.btnRefreshDgv.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRefreshDgv.BackgroundImage = global::EmployeeProj.Properties.Resources.Refresh_icon;
            this.btnRefreshDgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshDgv.Location = new System.Drawing.Point(324, 12);
            this.btnRefreshDgv.Name = "btnRefreshDgv";
            this.btnRefreshDgv.Size = new System.Drawing.Size(50, 50);
            this.btnRefreshDgv.TabIndex = 16;
            this.btnRefreshDgv.UseVisualStyleBackColor = false;
            this.btnRefreshDgv.Click += new System.EventHandler(this.btnRefreshDgv_Click);
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 346);
            this.Controls.Add(this.btnRefreshDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditDepartment";
            this.Text = "Редагування відділів";
            this.Load += new System.EventHandler(this.EditDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefreshDgv;
    }
}