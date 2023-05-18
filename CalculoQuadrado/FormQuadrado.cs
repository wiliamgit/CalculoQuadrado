using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoQuadrado
{
    public partial class FormQuadrado : Form
    {
        public FormQuadrado()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //Declarar as variaveis
            int numero;
            int quadrado = 0;

            //Atribuir o  valor de entrada na variavel numero vindo do txBox_Calcular

            numero = Convert.ToInt32(txBox_Calcular.Text);

            //atribui o valor de entrada na variavel quadrado, realizando calculo.

            quadrado = numero * numero;

            //ToString passar int para texto 

            lbl_Resul.Text = "Quadrado de " + numero + " é " + quadrado.ToString();
            txBox_Calcular.Text = "";
            //focus focar com o cursor no txBox
            txBox_Calcular.Focus();

        }

        private void btn_Calcular(object sender, KeyPressEventArgs e)
        {

        }
    }
}
