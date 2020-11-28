using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Data.SqlClient;
using Entidades;
using System.Threading;

namespace FrmConsecionaria
{
    public partial class FrmLista : Form
    {
        string xml_Concesionaria = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\DataTableConsecionariaDatos.xml";
        string xml_Concesionaria_Schema = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\DataTableConsecionariaSchema.xml";

        protected SqlDataAdapter da;
        protected DataTable dt;


        public FrmLista()
        {
            InitializeComponent();

            if (!this.ConfigurarDataAdapter())
            {
                MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                this.Close();
            }

            this.ConfigurarDataTable();

            try
            {
                this.da.Fill(this.dt);

                this.ConfigurarGrilla();

                this.dgvGrilla.DataSource = this.dt;

                txtVisorTickets.ScrollBars = ScrollBars.Vertical;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.btnVender.Click += new EventHandler(CambiarColorLetra);            
        }


        #region DataAdapter
        /// <summary>
        /// Configuracion del Data Adapter
        /// </summary>
        /// <returns></returns>
        private bool ConfigurarDataAdapter()
        {
            bool rta = false;

            try
            {
                    SqlConnection cn; cn = new SqlConnection(Properties.Settings.Default.Conexion);

                    this.da = new SqlDataAdapter();

                    this.da.SelectCommand = new SqlCommand("SELECT id, marca, precio, tipo FROM CONCESIONARIA", cn);
                    this.da.InsertCommand = new SqlCommand("INSERT INTO CONCESIONARIA (marca, precio, tipo) VALUES (@marca, @precio, @tipo)", cn);
                    this.da.UpdateCommand = new SqlCommand("UPDATE CONCESIONARIA SET marca=@marca, precio=@precio, tipo=@tipo WHERE id=@id", cn);
                    this.da.DeleteCommand = new SqlCommand("DELETE FROM CONCESIONARIA WHERE id=@id", cn);

                    this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                    this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "precio");
                    this.da.InsertCommand.Parameters.Add("@tipo", SqlDbType.VarChar, 50, "tipo");

                    this.da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                    this.da.UpdateCommand.Parameters.Add("@precio", SqlDbType.Float, 20, "precio");
                    this.da.UpdateCommand.Parameters.Add("@tipo", SqlDbType.VarChar, 50, "tipo");
                    //this.da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");

                    this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");

                    rta = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return rta;
        }

        #endregion

        #region DataTable
        /// <summary>
        /// Configuracion de Data Table
        /// </summary>
        private void ConfigurarDataTable()
        {
            this.dt = new DataTable("Consecionaria");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("marca", typeof(string));
            this.dt.Columns.Add("precio", typeof(float));
            this.dt.Columns.Add("tipo", typeof(string));

            this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;
        }

        #endregion

        #region DataGridView

        /// <summary>
        /// Configuracion de la Grilla
        /// </summary>
        private void ConfigurarGrilla()
        {
            this.dgvGrilla.RowsDefaultCellStyle.BackColor = Color.Wheat;

            this.dgvGrilla.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood;

            this.dgvGrilla.BackgroundColor = Color.Beige;

            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvGrilla.GridColor = Color.HotPink;

            this.dgvGrilla.ReadOnly = false;

            this.dgvGrilla.MultiSelect = false;

            this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvGrilla.RowsDefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            this.dgvGrilla.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            this.dgvGrilla.EditMode = DataGridViewEditMode.EditProgrammatically;

            this.dgvGrilla.RowHeadersVisible = false;            

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        #region Manejores de eventos
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.da.Update(this.dt);

                MessageBox.Show("Sincronizado!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Boton Agregar, Abro el Formulario de Alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            FrmAlta frm = new FrmAlta();
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {

                DataRow fila = this.dt.NewRow();

                //fila["id"] = frm.Persona.Id;
                if (frm.Auto is Auto)
                {
                    fila["marca"] = frm.Auto.Marca;
                    fila["precio"] = frm.Auto.Precio;
                    fila["tipo"] = frm.Auto.Tipo;
                }
                else
                {
                    fila["marca"] = frm.Moto.Marca;
                    fila["precio"] = frm.Moto.Precio;
                    fila["tipo"] = frm.Moto.Cilindarada;
                }

                this.dt.Rows.Add(fila);
            }           
        }

        /// <summary>
        /// Metodo Vehiculo, uso este metodo mediante un Hilo Secundario para Escribir dicho texto al label1(Info)
        /// </summary>
        private void vehiculoVendido()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => label1.Text = "VEHICULO VENDIDO FELICIDADES!!!"));
            }
            
        }


        /// <summary>
        /// Boton Vender, obtiene los valores segun el indice de la grilla seleccionado,
        /// Genero una instancia de tipo (Auto o Moto) se lo paso a Ticketera,
        /// genero el ticket y si esta todo Ok, Elimino de la grilla ese vehiculo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            Int32 indice = this.dgvGrilla.CurrentRow.Index;

            DataRow fila = this.dt.Rows[indice];
            Thread t = new Thread(vehiculoVendido);
            //bool aux = false;
            

            int id = int.Parse(fila["id"].ToString());
            string marca = fila["marca"].ToString();
            float precio = float.Parse(fila["precio"].ToString());
            string tipo = fila["tipo"].ToString();


            if (Ticketeadora<Vehiculo>.GeneradorDatosTickets(id, marca, precio, tipo))
            {
                MessageBox.Show("Ticket impreso correctamente!!!");
                this.dt.Rows[indice].Delete();
                t.Start();
            }
            else
            {
                MessageBox.Show("No se pudo imprimir el ticket!!!");
            }
        }



        /// <summary>
        /// Boton Cargar Data Table, carga el esquema de dicho xml y sus valores (xml_Concesionaria_Schema.xml y xml_Concesionaria.xml)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarDataTable_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(xml_Concesionaria_Schema))
                {
                    this.dt = new DataTable();

                    this.dt.ReadXmlSchema(xml_Concesionaria_Schema);

                    MessageBox.Show("Se ha cargado el esquema del DataTable!!!");
                }
                else
                {
                    MessageBox.Show("No existe ningún documento XML");
                }


                if (File.Exists(xml_Concesionaria))
                {
                    this.dt.ReadXml(xml_Concesionaria);

                    MessageBox.Show("Se han cargado los datos del DataTable!!!");

                }
                else
                {
                    MessageBox.Show("No existe ningún documento XML");
                }

                this.dgvGrilla.DataSource = this.dt;
            }
            catch
            {
                MessageBox.Show("Error al cargar el DataTable. ",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Boton Guardar en Data Table, guarda los datos del la grilla en un Data Table (xml_Concesionaria_Schema.xml y xml_Concesionaria.xml)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarDataTable_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dt.WriteXmlSchema(xml_Concesionaria_Schema);

                this.dt.WriteXml(xml_Concesionaria);

                MessageBox.Show("Se han guardado el esquema y los datos del DataTable!!!");

            }
            catch
            {
                MessageBox.Show("Error al guardar el DataTable. ",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Boton Abrir ticket, abre un FileDialog para abrir el archivo .txt del archivo tickets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirTickets_Click(object sender, EventArgs e)
        {

            DialogResult rta = openFileDialog1.ShowDialog();

            if (rta == DialogResult.OK)
            {

                string path = openFileDialog1.FileName;
                string texto;

                using (StreamReader f = new StreamReader(path))
                {
                    texto = f.ReadToEnd();
                    this.txtVisorTickets.Text = texto;
                }
            }

        }

        /// <summary>
        /// Metodo, cambia el color del label1 (Info) cuando se completa una Venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambiarColorLetra(object sender, EventArgs e)
        {
            Button cual = (Button)sender;

            Random r = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor rColorName = names[r.Next(names.Length)];
            Color rColor = Color.FromKnownColor(rColorName);

            if (cual == this.btnVender)
            {
                this.label1.ForeColor = rColor;
            }
        }



        #endregion


    }
}