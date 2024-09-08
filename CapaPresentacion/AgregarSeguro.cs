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
    public partial class AgregarSeguro : Form
    {
        public AgregarSeguro()
        {
            InitializeComponent();
        }

        private void BtnRegresarSeguro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
