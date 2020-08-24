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
    public partial class frmDescuento : Form
    {
        public frmDescuento()
        {
            InitializeComponent();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras / Borrar
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("No ha digitado un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
            }
            else
            {
                if (cmbTemporada.Text == "")
                {
                    MessageBox.Show("No ha seleccionado una temporada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTemporada.Focus();
                }
                else
                {
                    Double ValorCompra, ValorDescuento, ValorTotal;
                    ValorCompra = Double.Parse(txtValor.Text);
                    if (cmbTemporada.Text == "ESCOLAR")
                    {
                        if (ValorCompra > 0 && ValorCompra < 100000)
                        {
                            lblValorDescuento.Visible = true;
                            lblTotalCompra1.Visible = true;
                            lblValorDescuento.Text = 0 + "%";
                            ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                            ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                            lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                        }
                        else
                        {
                            if (ValorCompra > 100000 && ValorCompra <= 300000)
                            {
                                lblValorDescuento.Visible = true;
                                lblTotalCompra1.Visible = true;
                                lblValorDescuento.Text = 10 + "%";
                                ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                            }
                            else
                            {
                                lblValorDescuento.Visible = true;
                                lblTotalCompra1.Visible = true;
                                lblValorDescuento.Text = 15 + "%";
                                ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                            }
                        }
                    }
                    else
                    {
                        if (cmbTemporada.Text == "HALLOWEEN")
                        {
                            if (ValorCompra > 0 && ValorCompra <= 30000)
                            {
                                lblValorDescuento.Visible = true;
                                lblTotalCompra1.Visible = true;
                                lblValorDescuento.Text = 0 + "%";
                                ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                            }
                            else
                            {
                                if (ValorCompra >= 30001 && ValorCompra <= 200000)
                                {
                                    lblValorDescuento.Visible = true;
                                    lblTotalCompra1.Visible = true;
                                    lblValorDescuento.Text = 2 + "%";
                                    ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                    ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                    lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                                }
                                else
                                {
                                    lblValorDescuento.Visible = true;
                                    lblTotalCompra1.Visible = true;
                                    lblValorDescuento.Text = 5 + "%";
                                    ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                    ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                    lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                                }
                            }
                        }
                        else
                        {
                            if (cmbTemporada.Text == "DICIEMBRE")
                            {
                                if (ValorCompra > 0 && ValorCompra < 300000)
                                {
                                    lblValorDescuento.Visible = true;
                                    lblTotalCompra1.Visible = true;
                                    lblValorDescuento.Text = 0 + "%";
                                    ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                    ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                    lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                                }
                                else
                                {
                                    if (ValorCompra >= 300001 && ValorCompra <= 500000)
                                    {
                                        lblValorDescuento.Visible = true;
                                        lblTotalCompra1.Visible = true;
                                        lblValorDescuento.Text = 5 + "%";
                                        ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                        ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                        lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                                    }
                                    else
                                    {
                                        lblValorDescuento.Visible = true;
                                        lblTotalCompra1.Visible = true;
                                        lblValorDescuento.Text = 10 + "%";
                                        ValorDescuento = Double.Parse(lblValorDescuento.Text.Replace("%", ""));
                                        ValorTotal = ValorCompra - (ValorCompra * (ValorDescuento / 100));
                                        lblTotalCompra1.Text = Convert.ToString(String.Format("{0:C}", ValorTotal));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Focus();
            txtValor.Text = string.Empty;
            cmbTemporada.SelectedIndex = -1;  // Borra Contenido ComboBox
            lblValorDescuento.Visible = false;
            lblTotalCompra1.Visible = false;
        }

        private void cmbTemporada_Click(object sender, EventArgs e)
        {
            txtValor.Text = String.Format("{0:N0}", double.Parse(txtValor.Text));
        }
    }
}
