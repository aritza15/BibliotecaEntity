using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAnadirLibro : Form
    {
        public string ruta ="";
        public string mensaje = "";
        public List<Categoria> ListaC = new List<Categoria>();
        public List<Autor> ListaA = new List<Autor>();
        public FrmAnadirLibro()
        {
            InitializeComponent();
        }

        private void FrmAnadirLibro_Load(object sender, EventArgs e)
        {
            txtUnidades.ShortcutsEnabled = false;
            txtUnidades.ContextMenu = new ContextMenu();
            List<Autor> ListaAutores = new List<Autor>();
            ListaAutores = Program.gestor.DevolverAutores();
            cboAutores.Items.Clear();
            cboAutores.Items.AddRange(ListaAutores.ToArray());
            cboAutores.DisplayMember = "Nombre";

            List<Categoria> ListaCategorias = new List<Categoria>();
            ListaCategorias = Program.gestor.DevolverCategorias();
            cboCategorias.Items.Clear();
            cboCategorias.Items.AddRange(ListaCategorias.ToArray());
            cboCategorias.DisplayMember = "Descripcion";

            cboDisponibilidad.Items.Clear();
            cboDisponibilidad.Items.Add("Prestable");
            cboDisponibilidad.Items.Add("Solo consulta");
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCat.Items.Add(cboCategorias.SelectedItem as Categoria);
            lstCat.DisplayMember = "Descripcion";
        }

        private void cboAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAutores.Items.Add(cboAutores.SelectedItem as Autor);
            lstAutores.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMantenimientoLibros frm = new FrmMantenimientoLibros();
            frm.Show();
            this.Close();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            FrmAnadirAutor frm = new FrmAnadirAutor();
            frm.Show();
            this.Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.ShowDialog();
            pbCaratula.ImageLocation = openFileDialog1.FileName;
            pbCaratula.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btnAnadirLibro_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIsbn.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtEditorial.Text) || string.IsNullOrWhiteSpace(txtSinopsis.Text))
            {
                MessageBox.Show("No puedes dejar valores en blanco");
                return;
            }
            ListaC.Clear();
            foreach (Categoria cat in lstCat.Items)
            {
                ListaC.Add(cat);
            }
            ListaA.Clear();
            foreach (Autor aut in lstAutores.Items)
            {
                ListaA.Add(aut);
            }
            if (!File.Exists($"\\Fotos\\{openFileDialog1.SafeFileName}"))
            {
                ruta = $"..\\..\\Fotos\\{openFileDialog1.SafeFileName}";
                File.Copy(openFileDialog1.FileName, ruta);
            }
            else
            {
                MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre.");
            }
            mensaje = Program.gestor.AnadirLibro(txtIsbn.Text, txtTitulo.Text, txtEditorial.Text, txtSinopsis.Text, ruta, int.Parse(txtUnidades.Text), cboDisponibilidad.SelectedItem.ToString(), ListaC, ListaA);
            MessageBox.Show(mensaje);
        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
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

       
    }
}
