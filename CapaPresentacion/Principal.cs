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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAgregarSeguro_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AgregarSeguro formularioNuevo = new AgregarSeguro();
            formularioNuevo.FormClosed += (s, args) => this.Show();
            formularioNuevo.Show();
            this.Hide();
        }

        private void BtnSeguros_Click(object sender, EventArgs e)
        {
            VentasUsuarios formularioNuevo = new VentasUsuarios();
            formularioNuevo.FormClosed += (s, args) => this.Show();
            formularioNuevo.Show();
            this.Hide();
        }

        private void BtnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios formularioNuevo = new Usuarios();
            formularioNuevo.FormClosed += (s, args) => this.Show();
            formularioNuevo.Show();
            this.Hide();
        }
    }
}
