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
    public partial class FrmMorosos : Form
    {
        public string msg;
        public FrmMorosos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.Show();
            this.Close();
        }

        private void FrmMorosos_Load(object sender, EventArgs e)
        {
            var morosos = Program.gestor.DevolverLibrosMorosos(out msg);
            if(msg!= "")
            {
                MessageBox.Show(msg);
                return;
            }
            dgvMorosos.DataSource = (from mor in morosos
                                     select new { mor.Libro.Titulo,mor.NCarnet,mor.Lectores.Nombre, mor.FechaDevolucion }).ToList();
        }
    }
}
