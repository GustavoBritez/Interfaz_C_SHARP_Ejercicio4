using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        TextBox TextBox_Focus;
        public Form1()
        {
            InitializeComponent();
            

        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
        }

        private void RESULTADO_Click(object sender, EventArgs e)
        {
            if (BTN_Raiz.Checked)
            {
                double num = Double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero"));
                TX_Resultado.Text = Math.Sqrt(num).ToString();
            }


            if ( !string.IsNullOrEmpty(TX_1.Text) && !string.IsNullOrEmpty(TX_2.Text))
            {
                if (int.TryParse(TX_1.Text , out int num1) && int.TryParse(TX_2.Text , out int num2))
                {
                    if( BTN_Suma.Checked )
                    {
                        TX_Resultado.Text = (num1 + num2).ToString();
                    }
                    if (BTN_Resta.Checked)
                    {
                        TX_Resultado.Text = (num1 - num2).ToString();
                    }
                    if (BTN_Multi.Checked)
                    {
                        TX_Resultado.Text = (num1 * num2).ToString();
                    }
                    if (BTN_Divisor.Checked)
                    {
                        TX_Resultado.Text = (num1 / num2).ToString();
                    }
                }
            }
        }
        private void TX_1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
