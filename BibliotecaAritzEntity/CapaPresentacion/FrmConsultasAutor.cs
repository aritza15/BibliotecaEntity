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
    public partial class FrmConsultasAutor : Form
    {
        public string msg = "";
        public List<Autor> listaAutores = new List<Autor>();
        public FrmConsultasAutor()
        {
            InitializeComponent();
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            if (txtAutor.Text != "")
            {
                dgvAutores.DataSource = "";
               listaAutores = Program.gestor.DevolverAutoresPorNombre(txtAutor.Text);
                dgvAutores.DataSource = (from aut in listaAutores
                                        select new { aut.Id, aut.Nombre }).ToList();
            }
            else
            {
                dgvAutores.DataSource = "";
                return;
            }
            
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var libros = Program.gestor.DevolverLibrosDeAutor(int.Parse(dgvAutores.CurrentRow.Cells[0].Value.ToString()),out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }
            dgvLibros.DataSource = (from lib in libros
                                    select new { lib.Isbn,lib.Titulo }).ToList();
        }
    }
}
