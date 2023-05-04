using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st_degree_equation_solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool textAorBisEmpty()
        {
            if (textA.Text=="")
            {
                return true;
            }
            else if (textB.Text=="")
            { return true;}
            else { return false; }
        }
        private bool is_textAnumbers()
        {
            try
            {
                double Var_A = Convert.ToDouble(textA.Text);
                return true;
            }
            catch { return false; }
        }
        private bool is_textBnumbers()
        {
            try
            {
                double Var_B = Convert.ToDouble(textB.Text);
                return true;
            }
            catch { return false; }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (textAorBisEmpty()==false)
            {
                try
                {
                    double Var_A = Convert.ToDouble(textA.Text);
                    double Var_B = Convert.ToDouble(textB.Text);
                    if (Var_A == 0 && Var_B == 0)
                    {
                        MessageBox.Show("All numbers are solutions to this Equation");
                    }
                    else if (Var_A == 0)
                    {
                        MessageBox.Show("there is no solution to this equation");
                    }
                    else
                    {
                        string result = String.Format("{0:0.00}", (-Var_B / Var_A));
                        textX.Text = result;
                    }
                }
                catch { }
                
            }
        }

        private void textA_Validating(object sender, CancelEventArgs e)
        {
            if (is_textAnumbers()==false)
            {
                e.Cancel=true;
                textA.Focus();
                errorProvider1.SetError(textA, "please enter a number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textA, "");
            }
        }

        private void textB_Validating(object sender, CancelEventArgs e)
        {
            if (is_textBnumbers() == false)
            {
                e.Cancel = true;
                textB.Focus();
                errorProvider1.SetError(textB, "please enter a number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textB, "");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            textA.Text = "";
            textB.Text = "";
            textX.Text = "";
        }
    }
}
