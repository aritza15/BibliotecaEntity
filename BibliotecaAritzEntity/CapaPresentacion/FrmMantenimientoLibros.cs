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
    public partial class FrmMantenimientoLibros : Form
    {
        public FrmMantenimientoLibros()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            FrmAnadirLibro frm = new FrmAnadirLibro();
            frm.Show();
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            FrmBorrarLibro frm = new FrmBorrarLibro();
            frm.Show();
            this.Close();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            FrmPrestamos frm = new FrmPrestamos();
            frm.Show();
            this.Close();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            FrmDevoluciones frm = new FrmDevoluciones();
            frm.Show();
            this.Close();
        }
    }
}
