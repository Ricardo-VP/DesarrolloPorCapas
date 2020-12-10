using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionForm
{
    public partial class frmIU : Form
    {
        public frmIU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();

            string nombre = this.txtNombre.Text;
            this.txtMensaje.Text = conta.Saludos(nombre);

            double x = double.Parse(this.txtSaldoInicial.Text);
            this.txtResultados.Text = Convert.ToString(conta.getSaldos(x));

            int mes = Convert.ToInt32(this.txtNumMes.Text);
            this.txtMes.Text = CapaLogica.Utilidades.getNombreDelMes(mes);
        }
    }
}
