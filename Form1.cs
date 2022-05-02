using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          
          
            string funcionario = txtFuncionario.Text;   
            double salario = double.Parse(txtSalario.Text);
           

            if (RBtnCLT.Checked)
            {
                double desconto = salario * 0.06;
                double liquido = salario - desconto;

                lblResultado.Text = "O Salário líquido é: " + liquido;
            }

            if (RBtnFree.Checked)
            {
                double valor = double.Parse(txtValor.Text);
                double bonus = valor * 0.085;
                double liquido = salario + bonus;

                lblResultado.Text = "O Salário bonificado é: " + liquido;
            }

            if (RBtnPJ.Checked)
            {
                double desconto = salario * 0.06;
                double liquido = salario - desconto;
                lblResultado.Text = "O Salário líquido é: " + liquido;
            }


        }

        private void cBoxFree_CheckedChanged(object sender, EventArgs e)
        {
           
            //if (cBoxFree.Checked)
            //{
            //    txtValor.Enabled = true;
            //}
            //else
            //{
            //    txtValor.Enabled = false;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!RBtnFree.Checked)
            {
                txtValor.Enabled = false;
            }
        }

        private void RBtnFree_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnFree.Checked)
            {
                txtValor.Enabled = true;
            }
            else
            {
                txtValor.Enabled = false;
            }
        }

        private void RBtnFree_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RBtnFree.Checked)
            {
                txtValor.Enabled = true;
            }
            else
            {
                txtValor.Enabled = false;
            }
        }
    }
}
