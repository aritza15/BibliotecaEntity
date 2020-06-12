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
    public partial class FrmBorrarLibro : Form
    {
        public string mensaje = "";
        public List<Libro> ListaLibros;
        public FrmBorrarLibro()
        {
            InitializeComponent();
        }

        private void FrmBorrarLibro_Load(object sender, EventArgs e)
        {
            
            ListaLibros = Program.gestor.DevolverLibros();
            cboBorrar.Items.Clear();
            cboBorrar.Items.AddRange(ListaLibros.ToArray());
            cboBorrar.DisplayMember = "Titulo";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(cboBorrar.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado ningun libro");
                return;
            }
            mensaje = Program.gestor.BorrarLibro((cboBorrar.SelectedItem as Libro).Isbn);
            MessageBox.Show(mensaje);
            cboBorrar.Items.Clear();
            ListaLibros = Program.gestor.DevolverLibros();
            cboBorrar.Items.AddRange(ListaLibros.ToArray());
            cboBorrar.DisplayMember = "Titulo"; 
        }

       
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMantenimientoLibros frm = new FrmMantenimientoLibros();
            frm.Show();
            this.Close();
        }
    }
}
