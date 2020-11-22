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

namespace FrmConsecionaria
{
    public partial class FrmAlta : Form
    {

        protected Auto a;
        protected Moto m;

        /// <summary>
        /// Contructor default
        /// </summary>
        public FrmAlta()
        {
            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(ETipo));
            comboBox2.DataSource = Enum.GetValues(typeof(ECilindrada));
            comboBox2.Visible = false;
           
        }

        /// <summary>
        /// Constructor de Auto
        /// </summary>
        /// <param name="a"></param>
        public FrmAlta(Auto a) : this()
        {

            this.a = a;

            this.textMarca.Text = a.Marca;
            this.textPrecio.Text = a.Precio.ToString();
        }

        /// <summary>
        /// Constructor de Moto
        /// </summary>
        /// <param name="m"></param>
        public FrmAlta(Moto m) : this()
        {
            this.m = m;

            this.textMarca.Text = m.Marca;
            this.textPrecio.Text = m.Precio.ToString();
            this.comboBox1.Text = m.Cilindarada.ToString();
        }


        /// <summary>
        /// Propiedad solo lectura Auto
        /// </summary>
        public Auto Auto
        {
            get { return this.a; }
        }

        /// <summary>
        /// Propiedad solo lectura Moto
        /// </summary>
        public Moto Moto
        {
            get { return this.m; }
        }


        /// <summary>
        /// Aceptar Alta, doy de alta un Vehiculo (Auto o Moto segun el checkbox) y creo la nueva instancia de dicho tipo de vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string id = this.textID.Text;        
            string tipo;
            id = id == "" ? "0" : id;

            if (checkBox1.Checked)
            {
                tipo = this.comboBox2.Text;

                this.m = new Moto(ConsoleColor.White, (ECilindrada)Enum.Parse(typeof(ECilindrada), tipo), this.textMarca.Text, float.Parse(textPrecio.Text));
            }
            else
            {
                tipo = this.comboBox1.Text;

                this.a = new Auto((ETipo)Enum.Parse(typeof(ETipo), tipo), this.textMarca.Text, float.Parse(textPrecio.Text));             
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        /// <summary>
        /// Cancelar Alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


        private void FrmABM_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Modifica la visivilidad de objetos, para adaptarse al Alta segun el Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.checkBox1.Text = "Cambiar a Auto";
                this.comboBox1.Visible = false;
                this.comboBox2.Visible = true;
                this.label3.Text = "Cilindrada";
                this.groupBox1.Text = "Alta - Moto";
            }
            else
            {
                this.checkBox1.Text = "Cambiar a Moto";
                this.comboBox1.Visible = true;
                this.comboBox2.Visible = false;                
                this.label3.Text = "Tipo";
                this.groupBox1.Text = "Alta - Auto";
            }
            
        }
    }
}
