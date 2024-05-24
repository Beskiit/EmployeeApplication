namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.departmentInput = new System.Windows.Forms.TextBox();
            this.ratePerHourInput = new System.Windows.Forms.TextBox();
            this.jobTitleInput = new System.Windows.Forms.TextBox();
            this.totalHoursInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.firstNameOutput = new System.Windows.Forms.Label();
            this.lastNameOutput = new System.Windows.Forms.Label();
            this.salaryOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rate per hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total hours worked";
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeButton.Location = new System.Drawing.Point(291, 299);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(75, 23);
            this.computeButton.TabIndex = 6;
            this.computeButton.Text = "Compute Salary";
            this.computeButton.UseVisualStyleBackColor = false;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(129, 67);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(100, 20);
            this.firstNameInput.TabIndex = 7;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(461, 67);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 20);
            this.lastNameInput.TabIndex = 8;
            // 
            // departmentInput
            // 
            this.departmentInput.Location = new System.Drawing.Point(129, 152);
            this.departmentInput.Name = "departmentInput";
            this.departmentInput.Size = new System.Drawing.Size(100, 20);
            this.departmentInput.TabIndex = 9;
            // 
            // ratePerHourInput
            // 
            this.ratePerHourInput.Location = new System.Drawing.Point(129, 253);
            this.ratePerHourInput.Name = "ratePerHourInput";
            this.ratePerHourInput.Size = new System.Drawing.Size(100, 20);
            this.ratePerHourInput.TabIndex = 10;
            // 
            // jobTitleInput
            // 
            this.jobTitleInput.Location = new System.Drawing.Point(461, 152);
            this.jobTitleInput.Name = "jobTitleInput";
            this.jobTitleInput.Size = new System.Drawing.Size(100, 20);
            this.jobTitleInput.TabIndex = 11;
            // 
            // totalHoursInput
            // 
            this.totalHoursInput.Location = new System.Drawing.Point(461, 253);
            this.totalHoursInput.Name = "totalHoursInput";
            this.totalHoursInput.Size = new System.Drawing.Size(100, 20);
            this.totalHoursInput.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Basic Salary:";
            // 
            // firstNameOutput
            // 
            this.firstNameOutput.AutoSize = true;
            this.firstNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameOutput.Location = new System.Drawing.Point(198, 342);
            this.firstNameOutput.Name = "firstNameOutput";
            this.firstNameOutput.Size = new System.Drawing.Size(0, 18);
            this.firstNameOutput.TabIndex = 16;
            // 
            // lastNameOutput
            // 
            this.lastNameOutput.AutoSize = true;
            this.lastNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameOutput.Location = new System.Drawing.Point(200, 376);
            this.lastNameOutput.Name = "lastNameOutput";
            this.lastNameOutput.Size = new System.Drawing.Size(0, 18);
            this.lastNameOutput.TabIndex = 17;
            // 
            // salaryOutput
            // 
            this.salaryOutput.AutoSize = true;
            this.salaryOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryOutput.Location = new System.Drawing.Point(211, 404);
            this.salaryOutput.Name = "salaryOutput";
            this.salaryOutput.Size = new System.Drawing.Size(0, 20);
            this.salaryOutput.TabIndex = 18;
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salaryOutput);
            this.Controls.Add(this.lastNameOutput);
            this.Controls.Add(this.firstNameOutput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalHoursInput);
            this.Controls.Add(this.jobTitleInput);
            this.Controls.Add(this.ratePerHourInput);
            this.Controls.Add(this.departmentInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComputeSalary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox departmentInput;
        private System.Windows.Forms.TextBox ratePerHourInput;
        private System.Windows.Forms.TextBox jobTitleInput;
        private System.Windows.Forms.TextBox totalHoursInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label firstNameOutput;
        private System.Windows.Forms.Label lastNameOutput;
        private System.Windows.Forms.Label salaryOutput;
    }
}

