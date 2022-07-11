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
            this.btnEditDpmnt = new System.Windows.Forms.Button();
            this.btnEditPos = new System.Windows.Forms.Button();
            this.btnAddEmpl = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditDpmnt
            // 
            this.btnEditDpmnt.Location = new System.Drawing.Point(12, 7);
            this.btnEditDpmnt.Name = "btnEditDpmnt";
            this.btnEditDpmnt.Size = new System.Drawing.Size(98, 51);
            this.btnEditDpmnt.TabIndex = 0;
            this.btnEditDpmnt.Text = "Редагування відділів";
            this.btnEditDpmnt.UseVisualStyleBackColor = true;
            this.btnEditDpmnt.Click += new System.EventHandler(this.btnEditDpmnt_Click);
            // 
            // btnEditPos
            // 
            this.btnEditPos.Location = new System.Drawing.Point(127, 7);
            this.btnEditPos.Name = "btnEditPos";
            this.btnEditPos.Size = new System.Drawing.Size(98, 51);
            this.btnEditPos.TabIndex = 1;
            this.btnEditPos.Text = "Редагування посади";
            this.btnEditPos.UseVisualStyleBackColor = true;
            // 
            // btnAddEmpl
            // 
            this.btnAddEmpl.Location = new System.Drawing.Point(244, 7);
            this.btnAddEmpl.Name = "btnAddEmpl";
            this.btnAddEmpl.Size = new System.Drawing.Size(98, 51);
            this.btnAddEmpl.TabIndex = 2;
            this.btnAddEmpl.Text = "Додати співробітника";
            this.btnAddEmpl.UseVisualStyleBackColor = true;
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(361, 7);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(98, 51);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "Виплати";
            this.btnSalary.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(480, 7);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(98, 51);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Формування звіту";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 486);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnAddEmpl);
            this.Controls.Add(this.btnEditPos);
            this.Controls.Add(this.btnEditDpmnt);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditDpmnt;
        private System.Windows.Forms.Button btnEditPos;
        private System.Windows.Forms.Button btnAddEmpl;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnLog;
    }
}

