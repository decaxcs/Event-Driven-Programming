using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicComputationBenosa;

namespace BasicCalculatorBenosa
{
    public partial class FrmBasicCalculator : Form
    {
        float total;
        float num1, num2;
        public FrmBasicCalculator()
        {
            InitializeComponent();
            num1 = 0;
            num2 = 0;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Int64.Parse(tbNum1.Text);
            num2 = Int64.Parse(tbNum2.Text);

            if (cbOperations.SelectedIndex == 0)
            {
                total = BasicComputationBenosa.BasicComputationBenosa.Addition(num1, num2);
            }
            else if(cbOperations.SelectedIndex == 1)
            {
                total = BasicComputationBenosa.BasicComputationBenosa.Subtraction(num1, num2);
            }
            else if (cbOperations.SelectedIndex == 2)
            {
                total = BasicComputationBenosa.BasicComputationBenosa.Multiplication(num1, num2);
            }
            else if (cbOperations.SelectedIndex == 3)
            {
                total = BasicComputationBenosa.BasicComputationBenosa.Division(num1, num2);
            }
            lblTotal.Text = total.ToString();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
