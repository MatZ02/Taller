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
    public partial class VentasUsuarios : Form
    {
        public VentasUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnMostrarUsuario_Click(object sender, EventArgs e)
        {
            CN_Seguros Usuarios = new CN_Seguros();
            List<Usuario> listaUsuarios = Usuarios.ListadoUsuarios();
            dataGridViewUsuarios.DataSource = listaUsuarios;

            CN_Seguros Seguros = new CN_Seguros();
            List<Seguro> ListaSeguros = Seguros.ListadoSeguros();
            dataGridViewSeguros.DataSource = ListaSeguros;

            CN_Seguros Ventas = new CN_Seguros();
            List<Venta> listaVentas = Ventas.ListadoVentas();
            dataGridViewVentas.DataSource = listaVentas;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            CN_Seguros negocioSeguros = new CN_Seguros();

            Seguro seguro = negocioSeguros.BuscarSeguro(txtCodigo.Text);

            Usuario cliente = negocioSeguros.BuscarUsuario(txtId.Text);

            int cantidadBeneficiarios = int.Parse(txtBeneficiarios.Text);

            Venta detallesVenta = negocioSeguros.CalcularDetallesVenta(seguro, cliente, cantidadBeneficiarios);

            InformacionVenta formDetalles = new InformacionVenta(detallesVenta);

            formDetalles.ShowDialog();

            negocioSeguros.GuardarVenta(detallesVenta);

            MessageBox.Show("Venta registrada exitosamente");
            
        }
    }
}
