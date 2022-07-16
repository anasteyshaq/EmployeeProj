namespace EmployeeProj
{
    partial class EmployeeInfo
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
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBonus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxKPI = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.Red;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(420, 287);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(111, 42);
            this.btnDeleteEmployee.TabIndex = 0;
            this.btnDeleteEmployee.Text = "Видалити";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(22, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Ім\'я";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(25, 47);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(179, 20);
            this.textBoxFName.TabIndex = 2;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(25, 87);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(179, 20);
            this.textBoxLName.TabIndex = 4;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(22, 71);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 3;
            this.lbLastName.Text = "Прізвище";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(25, 135);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(179, 20);
            this.textBoxPatronymic.TabIndex = 6;
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Location = new System.Drawing.Point(22, 119);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(67, 13);
            this.lbPatronymic.TabIndex = 5;
            this.lbPatronymic.Text = "По-батькові";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(13, 132);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(179, 20);
            this.textBoxPhone.TabIndex = 8;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(10, 116);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(52, 13);
            this.lbPhone.TabIndex = 7;
            this.lbPhone.Text = "Телефон";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(25, 216);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(179, 20);
            this.textBoxCity.TabIndex = 10;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(22, 200);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(35, 13);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "Місто";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(13, 85);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxAddress.TabIndex = 12;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(10, 69);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(44, 13);
            this.lbAddress.TabIndex = 11;
            this.lbAddress.Text = "Адреса";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 161);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контактна інформація";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 152);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ПІБ";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.Color.Gray;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveEmployee.Location = new System.Drawing.Point(16, 28);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(111, 42);
            this.btnSaveEmployee.TabIndex = 16;
            this.btnSaveEmployee.Text = "Зберегти";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveEmployee);
            this.groupBox3.Location = new System.Drawing.Point(404, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 131);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Керування даними";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Посада";
            // 
            // textBoxBonus
            // 
            this.textBoxBonus.Location = new System.Drawing.Point(243, 222);
            this.textBoxBonus.Name = "textBoxBonus";
            this.textBoxBonus.ReadOnly = true;
            this.textBoxBonus.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonus.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Премія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Оклад";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Оцінка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Відділ";
            // 
            // numericSalary
            // 
            this.numericSalary.Location = new System.Drawing.Point(243, 176);
            this.numericSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(100, 20);
            this.numericSalary.TabIndex = 28;
            this.numericSalary.ValueChanged += new System.EventHandler(this.numericSalary_ValueChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(243, 63);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartment.TabIndex = 29;
            this.comboBoxDepartment.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDepartment_SelectionChangeCommitted);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(243, 119);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosition.TabIndex = 30;
            // 
            // comboBoxKPI
            // 
            this.comboBoxKPI.FormattingEnabled = true;
            this.comboBoxKPI.Location = new System.Drawing.Point(243, 270);
            this.comboBoxKPI.Name = "comboBoxKPI";
            this.comboBoxKPI.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKPI.TabIndex = 31;
            this.comboBoxKPI.SelectionChangeCommitted += new System.EventHandler(this.comboBoxKPI_SelectionChangeCommitted);
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 346);
            this.Controls.Add(this.comboBoxKPI);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.numericSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBonus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.lbPatronymic);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "EmployeeInfo";
            this.Text = "EmployeeInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBonus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxKPI;
    }
}