using Account_Registration;
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

namespace Benosa_Streams_2
{
    public partial class FrmStudentRecord : Form
    {
        private string path;

        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvViewRecord.Items.Add(_getText);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            lvViewRecord.Clear();
            string message = "Successfully Uploaded!";
            string title = "Notification!";
            MessageBox.Show(message, title);
        
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
