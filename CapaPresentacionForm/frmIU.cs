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
            //Validaciones
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingresa tu nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (txtSaldoInicial.Text.Length == 0)
            {
                MessageBox.Show("Ingresa tu saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSaldoInicial.Focus();
                return;
            }
            if (txtSaldoInicial.Text.Length == 0)
            {
                MessageBox.Show("Ingresa tu saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSaldoInicial.Focus();
                return;
            }
            if (txtNumMes.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el numero del mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumMes.Focus();
                return;
            }
            if (txtFecha.Text.Length == 0)
            {
                MessageBox.Show("Ingresa una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFecha.Focus();
                return;
            }


            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();

            string nombre = this.txtNombre.Text;
            this.txtMensaje.Text = conta.Saludos(nombre);

            double x = double.Parse(this.txtSaldoInicial.Text);
            this.txtResultados.Text = Convert.ToString(conta.getSaldos(x));

            int mes = Convert.ToInt32(this.txtNumMes.Text);
            this.txtMes.Text = CapaLogica.Utilidades.getNombreDelMes(mes);

            string fecha = this.txtFecha.Text;
            this.txtResultFecha.Text = Convert.ToString(CapaLogica.Utilidades.Fecha(fecha));
        }

        private void txtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo números ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNumMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
