using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class frmMayorEdad : Form
    {
        public frmMayorEdad()
        {
            InitializeComponent();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Ejecutar proceso presionando tecla enter
            if (e.KeyChar == 13)
            {
                btnCalcular.PerformClick();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validacion Edad sin valor
            if (txtEdad.Text == string.Empty)
            {
                MessageBox.Show("No ha digitado la Edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEdad.Focus();
            }

            else
            {
                int edad;
                edad = int.Parse(txtEdad.Text);
                if (edad > 18)
                {
                    MessageBox.Show(("La edad escrita es " + edad + ". La persona es mayor de edad."), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEdad.Focus();
                    txtEdad.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(("La edad escrita es " + edad + ". La persona es menor de edad."), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEdad.Focus();
                    txtEdad.Text = string.Empty;
                }
            }
        }
    }
}
