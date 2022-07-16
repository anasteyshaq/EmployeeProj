namespace EmployeeProj
{
    partial class Main
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
            this.btnEditPos = new System.Windows.Forms.Button();
            this.btnAddEmpl = new System.Windows.Forms.Button();
            this.btnEditDpmnt = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.btnRefreshDgv = new System.Windows.Forms.Button();
            this.comboBoxFilterByDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditPos
            // 
            this.btnEditPos.Location = new System.Drawing.Point(129, 12);
            this.btnEditPos.Name = "btnEditPos";
            this.btnEditPos.Size = new System.Drawing.Size(98, 51);
            this.btnEditPos.TabIndex = 1;
            this.btnEditPos.Text = "Редагування посади";
            this.btnEditPos.UseVisualStyleBackColor = true;
            this.btnEditPos.Click += new System.EventHandler(this.btnEditPos_Click);
            // 
            // btnAddEmpl
            // 
            this.btnAddEmpl.Location = new System.Drawing.Point(233, 12);
            this.btnAddEmpl.Name = "btnAddEmpl";
            this.btnAddEmpl.Size = new System.Drawing.Size(98, 51);
            this.btnAddEmpl.TabIndex = 2;
            this.btnAddEmpl.Text = "Додати співробітника";
            this.btnAddEmpl.UseVisualStyleBackColor = true;
            this.btnAddEmpl.Click += new System.EventHandler(this.btnAddEmpl_Click);
            // 
            // btnEditDpmnt
            // 
            this.btnEditDpmnt.Location = new System.Drawing.Point(25, 12);
            this.btnEditDpmnt.Name = "btnEditDpmnt";
            this.btnEditDpmnt.Size = new System.Drawing.Size(98, 51);
            this.btnEditDpmnt.TabIndex = 0;
            this.btnEditDpmnt.Text = "Редагування відділів";
            this.btnEditDpmnt.UseVisualStyleBackColor = true;
            this.btnEditDpmnt.Click += new System.EventHandler(this.btnEditDpmnt_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(337, 12);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(98, 51);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "Виплати";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(441, 12);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(98, 51);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Формування звіту";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(23, 81);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(693, 374);
            this.dataGridViewEmployees.TabIndex = 7;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // btnRefreshDgv
            // 
            this.btnRefreshDgv.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRefreshDgv.BackgroundImage = global::EmployeeProj.Properties.Resources.Refresh_icon;
            this.btnRefreshDgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshDgv.Location = new System.Drawing.Point(666, 12);
            this.btnRefreshDgv.Name = "btnRefreshDgv";
            this.btnRefreshDgv.Size = new System.Drawing.Size(50, 50);
            this.btnRefreshDgv.TabIndex = 8;
            this.btnRefreshDgv.UseVisualStyleBackColor = false;
            this.btnRefreshDgv.Click += new System.EventHandler(this.btnRefreshDgv_Click);
            // 
            // comboBoxFilterByDepartment
            // 
            this.comboBoxFilterByDepartment.FormattingEnabled = true;
            this.comboBoxFilterByDepartment.Location = new System.Drawing.Point(545, 41);
            this.comboBoxFilterByDepartment.Name = "comboBoxFilterByDepartment";
            this.comboBoxFilterByDepartment.Size = new System.Drawing.Size(97, 21);
            this.comboBoxFilterByDepartment.TabIndex = 9;
            this.comboBoxFilterByDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterByDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Відділ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilterByDepartment);
            this.Controls.Add(this.btnRefreshDgv);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnAddEmpl);
            this.Controls.Add(this.btnEditPos);
            this.Controls.Add(this.btnEditDpmnt);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditPos;
        private System.Windows.Forms.Button btnAddEmpl;
        private System.Windows.Forms.Button btnEditDpmnt;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button btnRefreshDgv;
        private System.Windows.Forms.ComboBox comboBoxFilterByDepartment;
        private System.Windows.Forms.Label label1;
    }
}

