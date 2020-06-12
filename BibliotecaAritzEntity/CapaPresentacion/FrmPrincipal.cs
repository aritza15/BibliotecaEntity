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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoLibros frm = new FrmMantenimientoLibros();
            frm.Show();
            this.Hide();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.Show();
            this.Hide();
        }
    }
}
