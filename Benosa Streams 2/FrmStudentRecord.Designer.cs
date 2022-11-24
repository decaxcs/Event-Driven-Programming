namespace Benosa_Streams_2
{
    partial class FrmStudentRecord
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
            this.lvViewRecord = new System.Windows.Forms.ListView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lvViewRecord
            // 
            this.lvViewRecord.HideSelection = false;
            this.lvViewRecord.Location = new System.Drawing.Point(6, 34);
            this.lvViewRecord.Name = "lvViewRecord";
            this.lvViewRecord.Size = new System.Drawing.Size(394, 191);
            this.lvViewRecord.TabIndex = 2;
            this.lvViewRecord.UseCompatibleStateImageBehavior = false;
            this.lvViewRecord.View = System.Windows.Forms.View.List;
            this.lvViewRecord.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(406, 34);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(406, 63);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 4;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(406, 92);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 234);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lvViewRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.Load += new System.EventHandler(this.FrmStudentRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvViewRecord;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}