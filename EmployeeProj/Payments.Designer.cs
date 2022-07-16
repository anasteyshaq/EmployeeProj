namespace EmployeeProj
{
    partial class Payments
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilterByDepartment = new System.Windows.Forms.ComboBox();
            this.btnRefreshDgv = new System.Windows.Forms.Button();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Відділ";
            // 
            // comboBoxFilterByDepartment
            // 
            this.comboBoxFilterByDepartment.FormattingEnabled = true;
            this.comboBoxFilterByDepartment.Location = new System.Drawing.Point(342, 42);
            this.comboBoxFilterByDepartment.Name = "comboBoxFilterByDepartment";
            this.comboBoxFilterByDepartment.Size = new System.Drawing.Size(97, 21);
            this.comboBoxFilterByDepartment.TabIndex = 12;
            this.comboBoxFilterByDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterByDepartment_SelectedIndexChanged);
            // 
            // btnRefreshDgv
            // 
            this.btnRefreshDgv.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRefreshDgv.BackgroundImage = global::EmployeeProj.Properties.Resources.Refresh_icon;
            this.btnRefreshDgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshDgv.Location = new System.Drawing.Point(463, 13);
            this.btnRefreshDgv.Name = "btnRefreshDgv";
            this.btnRefreshDgv.Size = new System.Drawing.Size(50, 50);
            this.btnRefreshDgv.TabIndex = 11;
            this.btnRefreshDgv.UseVisualStyleBackColor = false;
            this.btnRefreshDgv.Click += new System.EventHandler(this.btnRefreshDgv_Click);
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AllowUserToAddRows = false;
            this.dataGridViewPayments.AllowUserToDeleteRows = false;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(25, 80);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.ReadOnly = true;
            this.dataGridViewPayments.Size = new System.Drawing.Size(488, 261);
            this.dataGridViewPayments.TabIndex = 18;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 353);
            this.Controls.Add(this.dataGridViewPayments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilterByDepartment);
            this.Controls.Add(this.btnRefreshDgv);
            this.Name = "Payments";
            this.Text = "Виплати";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilterByDepartment;
        private System.Windows.Forms.Button btnRefreshDgv;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
    }
}