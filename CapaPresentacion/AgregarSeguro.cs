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
    public partial class AgregarSeguro : Form
    {
        private CN_Seguros negocioSeguros;
        public AgregarSeguro()
        {
            InitializeComponent();
        }

        private void BtnRegresarSeguro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarSeguro_Click(object sender, EventArgs e)
        {
            Seguro nuevoSeguro = new Seguro
            {
                Codigo = txtCodigo.Text,
                Tipo = txtTipo.Text,
                PorcentajeIncremento = decimal.Parse(TxtIncremento.Text),
                Valor = decimal.Parse(txtValor.Text)
            };
            CN_Seguros negocioSeguros = new CN_Seguros();
            negocioSeguros.GuardarSeguro(nuevoSeguro);
            MessageBox.Show("Seguro registrado exitosamente");
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            CN_Seguros negocioSeguros = new CN_Seguros();
            List<Seguro> ListaSeguros = negocioSeguros.ListadoSeguros();
            dataGridView1.DataSource = ListaSeguros;
        }
    }
}
