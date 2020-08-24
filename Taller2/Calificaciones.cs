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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras / Borrar / Coma
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 44)
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
                txtNota2.Focus();
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras / Borrar / Coma
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 44)
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
                txtNota3.Focus();
            }
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras / Borrar / Coma
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 44)
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
                txtNota4.Focus();
            }
        }

        private void txtNota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras / Borrar / Coma
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 44)
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
                txtNota5.Focus();
            }
        }

        private void txtNota5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras / Borrar / Coma
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 44)
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
            //Validacion Campos sin valor
            if (txtNota1.Text == string.Empty || txtNota2.Text == string.Empty || txtNota3.Text == string.Empty || txtNota4.Text == string.Empty || txtNota5.Text == string.Empty)
            {
                MessageBox.Show("No ha digitado un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNota1.Focus();
            }

            else
            {
                Double Nota1, Nota2, Nota3, Nota4, Nota5, Promedio;
                Nota1 = Double.Parse(txtNota1.Text);
                Nota2 = Double.Parse(txtNota2.Text);
                Nota3 = Double.Parse(txtNota3.Text);
                Nota4 = Double.Parse(txtNota4.Text);
                Nota5 = Double.Parse(txtNota5.Text);
                if ((Nota1 > 0 && Nota1 <= 5) && (Nota2 > 0 && Nota2 <= 5) && (Nota3 > 0 && Nota3 <= 5) && (Nota4 > 0 && Nota4 <= 5) && (Nota5 > 0 && Nota5 <= 5))
                {
                    Promedio = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5;
                    if (Promedio >= 0 && Promedio <= 1)
                    {
                        lblResultado.Visible = true;
                        lblResultado1.Visible = true;
                        lblResultado.Text = "REPROBADO";
                        lblResultado1.Text = @"No recupera";
                    }
                    else
                    {
                        if (Promedio > 1 && Promedio < 3)
                        {
                            lblResultado.Visible = true;
                            lblResultado1.Visible = true;
                            lblResultado.Text = "REPROBADO";
                            lblResultado1.Text = @"Puede Habilitar";
                        }
                        else
                        {
                            if (Promedio >= 3 && Promedio < 4)
                            {
                                lblResultado.Visible = true;
                                lblResultado1.Visible = true;
                                lblResultado.Text = "APROBADO";
                                lblResultado1.Text = @"Hacer Plan de Mejora";
                            }
                            else
                            {
                                if (Promedio >= 4 && Promedio <= 4.5)
                                {
                                    lblResultado.Visible = true;
                                    lblResultado1.Visible = true;
                                    lblResultado.Text = "BUENO";
                                    lblResultado1.Text = @"Buen Rendimiento";
                                }
                                else
                                {
                                    if (Promedio >= 4.6 && Promedio <= 4.9)
                                    {
                                        lblResultado.Visible = true;
                                        lblResultado1.Visible = true;
                                        lblResultado.Text = "EXCELENTE";
                                        lblResultado1.Text = @"Sigue Asi!";
                                    }
                                    else
                                    {
                                        lblResultado.Visible = true;
                                        lblResultado1.Visible = true;
                                        lblResultado.Text = "EXCELENTE";
                                        lblResultado1.Text = @"Graduado Con Honores";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Los valores digitados en las Notas no pueden superar el valor de 5. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNota1.Focus();///Mensaje
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Focus();
            txtNota1.Text = String.Empty;
            txtNota2.Text = String.Empty;
            txtNota3.Text = String.Empty;
            txtNota4.Text = String.Empty;
            txtNota5.Text = String.Empty;
            lblResultado.Visible = false;
            lblResultado1.Visible = false;
        }
    }
}
