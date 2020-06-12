using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Close();
        }
        private void btnCat_Click(object sender, EventArgs e)
        {
            FrmConsultaCategorias frm = new FrmConsultaCategorias();
            frm.Show();
            this.Close();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            FrmConsultasAutor frm = new FrmConsultasAutor();
            frm.Show();
            this.Close();
        }

        private void btnMoroso_Click(object sender, EventArgs e)
        {
            FrmMorosos frm = new FrmMorosos();
            frm.Show();
            this.Close();
        }
    }
}
