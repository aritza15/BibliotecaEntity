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
    public partial class FrmPrestamos : Form
    {
        public string mensaje = "";
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lstLibros.Items.Clear();
            List<Libro> ListaLibros;
            ListaLibros = Program.gestor.DevolverLibrosPorTitulo(txtTitulo.Text);
            foreach (Libro lib in ListaLibros)
            {
                lstLibros.Items.Add(lib);
                lstLibros.DisplayMember = "Titulo";
            }
            
        }

        private void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstLibros.SelectedItem as Libro == null)
            {
                MessageBox.Show("Debes seleccionar uno/s libros");
                return;
            }
            lstSeleccionados.Items.Add(lstLibros.SelectedItem as Libro);
            lstSeleccionados.DisplayMember = "Titulo";
        }
        private void txtNcarnet_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            if(txtNcarnet.Text == "")
            {
                MessageBox.Show("Debes introducir datos en todos los campos");
                return;
            }
            List<Libro> LibrosParaPrestar = new List<Libro>();
            foreach (Libro lib in lstSeleccionados.Items)
            {
                LibrosParaPrestar.Add(lib);
            }
            mensaje = Program.gestor.HacerPrestamo(LibrosParaPrestar, int.Parse(txtNcarnet.Text));
            MessageBox.Show(mensaje);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if(lstSeleccionados.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un libro que quieras deshacer.");
                return;
            }
            lstSeleccionados.Items.Remove(lstSeleccionados.SelectedItem);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMantenimientoLibros frm = new FrmMantenimientoLibros();
            frm.Show();
            this.Close();
        }
    }
}
