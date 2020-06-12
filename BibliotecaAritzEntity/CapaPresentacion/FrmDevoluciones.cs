using Entidades;
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
    
    public partial class FrmDevoluciones : Form
    {
        public List<LibrosLectores> ListaPrestamos;
        public List<LibrosLectores> ListaDevolucion = new List<LibrosLectores>();
        string msg = "";
        public FrmDevoluciones()
        {
            InitializeComponent();
        }

        private void txtNcarnet_TextChanged(object sender, EventArgs e)
        {
            if (txtNcarnet.Text == "")
            {
                return;
            }
            ListaPrestamos = Program.gestor.DevolverPrestamos(int.Parse(txtNcarnet.Text),out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }
            dgvDevoluciones.DataSource =(from prestamo in ListaPrestamos
                                       select new {prestamo.Isbn,prestamo.NCarnet, prestamo.Libro.Titulo,prestamo.FechaPrestamo,prestamo.FechaDevolucion}).ToList();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

            msg = Program.gestor.RealizarDevolucion(ListaDevolucion);
            MessageBox.Show(msg);
            ListaDevolucion.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMantenimientoLibros frm = new FrmMantenimientoLibros();
            frm.Show();
            this.Close();
        }

        private void dgvDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaDevolucion.Add(new LibrosLectores(dgvDevoluciones.CurrentRow.Cells[0].Value.ToString(), int.Parse(dgvDevoluciones.CurrentRow.Cells[1].Value.ToString()), DateTime.Parse(dgvDevoluciones.CurrentRow.Cells[3].Value.ToString()), DateTime.Parse(dgvDevoluciones.CurrentRow.Cells[4].Value.ToString())));
        }
    }
}
