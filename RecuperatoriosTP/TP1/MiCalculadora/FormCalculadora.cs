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


        /// <summary>
        /// Boton Operar, llama a Operar para hacer dicha operacion, luego lo muestra en resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double valor;

            if(this.cmbOperador.Text == "")
            {
                this.cmbOperador.Text = "+";
            }

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
         

        /// <summary>
        /// Boton Limpiar pantalla, limpia todo lo q tengo en los txtbox , operador y resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        /// <summary>
        /// Boton Cerrar, llama al evento Close()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Boton, Convertir de decimal a Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }


        /// <summary>
        /// Boton, Comverti de binario a Decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Evento Form Closing, Una mensaje si esta seguro salir de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro de querer salir?","Salir",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Evento Load, Limpia la pantalla al cargar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }
    }
}
