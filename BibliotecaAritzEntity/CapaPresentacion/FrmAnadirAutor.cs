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
    public partial class FrmAnadirAutor : Form
    {
        public string mensaje ="";
        public FrmAnadirAutor()
        {
            InitializeComponent();
        }

        
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            mensaje= Program.gestor.AnadirAutor(int.Parse(txtId.Text), txtNombre.Text);
            MessageBox.Show(mensaje);
            if(mensaje != "Añadido correctamente")
            {
                return;
            }
            else
            {
                FrmAnadirLibro frm = new FrmAnadirLibro();
                frm.Show();
                this.Close();
            }
            
        }
    }
}
