namespace Account_Registration
{
    partial class FrmRegistration
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBStudentNo = new System.Windows.Forms.TextBox();
            this.tBLastName = new System.Windows.Forms.TextBox();
            this.tBFirstName = new System.Windows.Forms.TextBox();
            this.tBMiddleName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Birthday";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tBStudentNo
            // 
            this.tBStudentNo.Location = new System.Drawing.Point(15, 26);
            this.tBStudentNo.Name = "tBStudentNo";
            this.tBStudentNo.Size = new System.Drawing.Size(100, 20);
            this.tBStudentNo.TabIndex = 8;
            this.tBStudentNo.Text = " ";
            // 
            // tBLastName
            // 
            this.tBLastName.Location = new System.Drawing.Point(15, 86);
            this.tBLastName.Name = "tBLastName";
            this.tBLastName.Size = new System.Drawing.Size(100, 20);
            this.tBLastName.TabIndex = 10;
            // 
            // tBFirstName
            // 
            this.tBFirstName.Location = new System.Drawing.Point(350, 86);
            this.tBFirstName.Name = "tBFirstName";
            this.tBFirstName.Size = new System.Drawing.Size(100, 20);
            this.tBFirstName.TabIndex = 11;
            // 
            // tBMiddleName
            // 
            this.tBMiddleName.Location = new System.Drawing.Point(653, 86);
            this.tBMiddleName.Name = "tBMiddleName";
            this.tBMiddleName.Size = new System.Drawing.Size(100, 20);
            this.tBMiddleName.TabIndex = 12;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(15, 146);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 13;
            // 
            // tbContactNo
            // 
            this.tbContactNo.Location = new System.Drawing.Point(350, 206);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(100, 20);
            this.tbContactNo.TabIndex = 14;
            this.tbContactNo.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BSIT",
            "BSBA",
            "BSIS",
            "BSA",
            "ART"});
            this.cbProgram.Location = new System.Drawing.Point(350, 26);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(121, 21);
            this.cbProgram.TabIndex = 16;
            this.cbProgram.SelectedIndexChanged += new System.EventHandler(this.cbProgram_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(370, 320);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpBday
            // 
            this.dtpBday.Location = new System.Drawing.Point(15, 206);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(200, 20);
            this.dtpBday.TabIndex = 18;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(350, 130);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 13);
            this.Gender.TabIndex = 19;
            this.Gender.Text = "Gender:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(350, 146);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 20;
            // 
            // btnRecords
            // 
            this.btnRecords.Location = new System.Drawing.Point(678, 320);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(75, 23);
            this.btnRecords.TabIndex = 21;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.dtpBday);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.tbContactNo);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tBMiddleName);
            this.Controls.Add(this.tBFirstName);
            this.Controls.Add(this.tBLastName);
            this.Controls.Add(this.tBStudentNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBStudentNo;
        private System.Windows.Forms.TextBox tBLastName;
        private System.Windows.Forms.TextBox tBFirstName;
        private System.Windows.Forms.TextBox tBMiddleName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnRecords;
    }
}

