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
    public partial class InformacionVenta : Form
    {
        public InformacionVenta()
        {
            InitializeComponent();
        }

        public InformacionVenta(Venta detallesVenta)
        {
            InitializeComponent();

            
            lblValorBase.Text = detallesVenta.ValorBase.ToString("C");
            lblIncremento.Text = detallesVenta.IncrementoPorTipo.ToString("C");
            lblBeneficiario.Text = detallesVenta.IncrementoPorBeneficiario.ToString("C");
            lblValorTotal.Text = detallesVenta.ValorTotal.ToString("C");
        }
    }
}
