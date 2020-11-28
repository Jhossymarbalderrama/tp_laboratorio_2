using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.SelectedItem = "+";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double valor;

           valor = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text[0]);
            

            if (valor == double.MinValue)
            {                
                this.lblResultado.Text = "Error.";
            }
            else
            {
                this.lblResultado.Text = Convert.ToString(valor);
            }         
        }
         
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);          
        }

        /// <summary>
        ///  Obtiene los Valores 1 y 2 y el Operador
        /// </summary>
        /// <param name="numero1">valor 1</param>
        /// <param name="numero2">valor 2</param>
        /// <param name="operador">Operador(-,+,/,*)</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, char operador)
        {
            
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);
            
            return Calculadora.Operar(numeroUno, numeroDos, operador);
        }

        /// <summary>
        /// Limpia la Pantalla, setea todos los campos en vacio
        /// </summary>
        private void LimpiarPantalla()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro de querer salir?","Salir",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }
    }
}
