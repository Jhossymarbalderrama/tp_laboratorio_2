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
        bool opero = false;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double valor = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);

            if (valor == double.MinValue)
            {
                this.lblResultado.Text = "Error. Intente Nuevamente";
            }
            else
            {
                this.lblResultado.Text = Convert.ToString(valor);
                opero = true;
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
          if(opero)
            {
                this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
            }
            else
            {
                this.lblResultado.Text = "Valor Invalido";
            }            
        }

        /// <summary>
        ///  Obtiene los Valores 1 y 2 y el Operador
        /// </summary>
        /// <param name="numero1">valor 1</param>
        /// <param name="numero2">valor 2</param>
        /// <param name="operador">Operador(-,+,/,*)</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
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
    }
}
