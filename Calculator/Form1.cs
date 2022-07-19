using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtFirstNumber.Focus();
      
        }

        double firstNumber = 0;
        double sceondNumber = 0;
        double dMrestult = 0;
       

        private void Addbutton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            sceondNumber = Convert.ToDouble(txtsecondNumbe.Text);
            double result = firstNumber + sceondNumber;
            txtresult.Text = result.ToString();
            txtFirstNumber.Text  = "";
            txtsecondNumbe.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            sceondNumber = Convert.ToDouble(txtsecondNumbe.Text);
            double result = firstNumber - sceondNumber;
            txtresult.Text = result.ToString();
            txtFirstNumber.Text = "";
            txtsecondNumbe.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            sceondNumber = Convert.ToDouble(txtsecondNumbe.Text);
            double result = firstNumber * sceondNumber;
            txtresult.Text = result.ToString();
            txtFirstNumber.Text = "";
            txtsecondNumbe.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            sceondNumber = Convert.ToDouble(txtsecondNumbe.Text);
            double result = firstNumber / sceondNumber;
            txtresult.Text = result.ToString();
            txtFirstNumber.Text = "";
            txtsecondNumbe.Text = "";
        }

        private void btnMadd_Click(object sender, EventArgs e)
        {
            
            double Madd = Convert.ToDouble(txtresult.Text);
            txtresult.Text = "";
            dMrestult += Madd;
            
        }

        private void btnMSub_Click(object sender, EventArgs e)
        {
            
            double Msub = Convert.ToDouble(txtresult.Text);
            txtresult.Text = "";
            dMrestult -= Msub;
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtresult.Text = dMrestult.ToString();
        }

        private void txtFirstNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtsecondNumbe.Focus();
            }
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFirstNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtFirstNumber.Text = txtFirstNumber.Text.Remove(txtFirstNumber.Text.Length - 1);
            }
        }

        private void txtsecondNumbe_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtsecondNumbe.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtsecondNumbe.Text = txtsecondNumbe.Text.Remove(txtsecondNumbe.Text.Length - 1);
            }

        }
    }
}

