using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace FrmConsecionaria
{

    public partial class FrmInicio : Form
    {
        private FrmLista frmLista;

        public FrmInicio()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            frmLista_show();
        }
       


        private void listaDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista_show();                     
        }

        private void frmLista_show()
        {
            if (frmLista == null)
            {
                frmLista = new FrmLista();
                frmLista.MdiParent = this;

                frmLista.Show();
            }
            else
            {
                frmLista = null;
            }
        }
    }
}
