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
    public partial class frmTaller2 : Form
    {
        public frmTaller2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestra aplicación!!", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            // Abrir App Mayor de Edad en forma Modal
            frmMayorEdad mayor = new frmMayorEdad();
            mayor.ShowDialog();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            // Abrir App Calificaciones en forma Modal
            frmCalificaciones calificaciones = new frmCalificaciones();
            calificaciones.ShowDialog();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            // Abrir App Descuentos en forma Modal
            frmDescuento descuento = new frmDescuento();
            descuento.ShowDialog();
        }
    }
}
