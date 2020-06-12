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
    public partial class FrmConsultaCategorias : Form
    {
        public string mensaje = "";
        public List<Libro> ListaLibros = new List<Libro>();
        public FrmConsultaCategorias()
        {
            InitializeComponent();
        }

        private void FrmConsultaCategorias_Load(object sender, EventArgs e)
        {
            cboCat.Items.Clear();
            cboCat.Items.AddRange(Program.gestor.DevolverCategorias().ToArray());
            cboCat.DisplayMember = "Descripcion";
        }

        private void btnTodosLibros_Click(object sender, EventArgs e)
        {
            dgvLibros.DataSource = "";
            ListaLibros = Program.gestor.ListaLibrosPorCategoria((cboCat.SelectedItem as Categoria).Id, 1, out mensaje);
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
                return;
            }
            dgvLibros.DataSource = (from lib in ListaLibros
                                    select new { lib.Isbn, lib.Titulo, Autores = string.Join(",", lib.Autores.Select(a => a.Nombre)), Categorias = string.Join(", ", lib.Categorias.Select(cat => cat.Descripcion)) }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.Show();
            this.Close();
        }

        private void btnLibrosPrestables_Click(object sender, EventArgs e)
        {
            dgvLibros.DataSource = "";
            ListaLibros = Program.gestor.ListaLibrosPorCategoria((cboCat.SelectedItem as Categoria).Id, 2, out mensaje);
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
                return;
            }
            dgvLibros.DataSource = (from lib in ListaLibros
                                    select new { lib.Isbn, lib.Titulo, Autores = string.Join(",", lib.Autores.Select(a => a.Nombre)), Categorias = string.Join(", ", lib.Categorias.Select(cat => cat.Descripcion)) }).ToList();
        }

        private void btnPrestables_Click(object sender, EventArgs e)
        {
            dgvLibros.DataSource = "";
            ListaLibros = Program.gestor.ListaLibrosPorCategoria((cboCat.SelectedItem as Categoria).Id, 3, out mensaje);
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
                return;
            }

            dgvLibros.DataSource = (from lib in ListaLibros
                                    select new { lib.Isbn, lib.Titulo, Autores = string.Join(",", lib.Autores.Select(a=>a.Nombre)), Categorias = string.Join(", ", lib.Categorias.Select(cat=>cat.Descripcion)) }).ToList();
        }
    }
}
