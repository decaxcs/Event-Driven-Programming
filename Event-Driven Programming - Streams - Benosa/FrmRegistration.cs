using Event_Driven_Programming___Streams___Benosa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            String getStudentNo = tBStudentNo.Text;
            String getLastName = tBLastName.Text;
            String getAge = tbAge.Text;
            String getBday = dtpBday.Text;
            String getProgram = cbProgram.Text;
            String getFirstName= tBFirstName.Text;
            String getMiddleName = tBMiddleName.Text;
            String getGender = cbGender.Text;
            String getContactNo = tbContactNo.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No.: " + getStudentNo);
                outputFile.WriteLine("Full Name: " + getFirstName + " " + getMiddleName + " " + getLastName );
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBday);
                outputFile.WriteLine("Contact No.: " + getContactNo);

                Console.WriteLine(getStudentNo);
                Console.WriteLine(getFirstName);
                Console.WriteLine(getMiddleName);
                Console.WriteLine(getLastName);
                Console.WriteLine(getProgram);
                Console.WriteLine(getGender);
                Console.WriteLine(getAge);
                Console.WriteLine(getBday);
                Console.WriteLine(getContactNo);
            }
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
