using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaDatos.CD_Seguros;

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnRegresarSeguro_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Id = txtId.Text,
                Nombre = txtNombre.Text,
                Contacto = txtContacto.Text
            };

            CN_Seguros negocioSeguros = new CN_Seguros();
            negocioSeguros.GuardarUsuario(nuevoUsuario);

            MessageBox.Show("Usuario registrado exitosamente");
        }

        private void BtnMostrarUsuario_Click(object sender, EventArgs e)
        {
            CN_Seguros negocioSeguros = new CN_Seguros();
            List<Usuario> listaUsuarios = negocioSeguros.ListadoUsuarios();
            dataGridView1.DataSource = listaUsuarios;
        }
    }
}
