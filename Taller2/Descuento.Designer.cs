namespace Taller2
{
    partial class frmDescuento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloDescuento = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.cmbTemporada = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblValorDescuento = new System.Windows.Forms.Label();
            this.lblTotalCompra1 = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.picDescuento = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDescuento
            // 
            this.lblTituloDescuento.AutoSize = true;
            this.lblTituloDescuento.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDescuento.Location = new System.Drawing.Point(118, 32);
            this.lblTituloDescuento.Name = "lblTituloDescuento";
            this.lblTituloDescuento.Size = new System.Drawing.Size(445, 39);
            this.lblTituloDescuento.TabIndex = 1;
            this.lblTituloDescuento.Text = "APLICATIVO CALCULAR DESCUENTO";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(35, 117);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(203, 19);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Digite valor de la compra:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.Location = new System.Drawing.Point(35, 160);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(202, 19);
            this.lblTemporada.TabIndex = 4;
            this.lblTemporada.Text = "Seleccione la temporada:";
            // 
            // cmbTemporada
            // 
            this.cmbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemporada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemporada.FormattingEnabled = true;
            this.cmbTemporada.Items.AddRange(new object[] {
            "ESCOLAR",
            "HALLOWEEN",
            "DICIEMBRE"});
            this.cmbTemporada.Location = new System.Drawing.Point(277, 160);
            this.cmbTemporada.Name = "cmbTemporada";
            this.cmbTemporada.Size = new System.Drawing.Size(150, 27);
            this.cmbTemporada.TabIndex = 5;
            this.cmbTemporada.Click += new System.EventHandler(this.cmbTemporada_Click);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(35, 212);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(166, 19);
            this.lblDescuento.TabIndex = 6;
            this.lblDescuento.Text = "Descuento a aplicar:";
            // 
            // lblValorDescuento
            // 
            this.lblValorDescuento.AutoSize = true;
            this.lblValorDescuento.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDescuento.Location = new System.Drawing.Point(273, 212);
            this.lblValorDescuento.Name = "lblValorDescuento";
            this.lblValorDescuento.Size = new System.Drawing.Size(133, 18);
            this.lblValorDescuento.TabIndex = 7;
            this.lblValorDescuento.Text = "Valor Descuento";
            this.lblValorDescuento.Visible = false;
            // 
            // lblTotalCompra1
            // 
            this.lblTotalCompra1.AutoSize = true;
            this.lblTotalCompra1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra1.Location = new System.Drawing.Point(273, 262);
            this.lblTotalCompra1.Name = "lblTotalCompra1";
            this.lblTotalCompra1.Size = new System.Drawing.Size(152, 18);
            this.lblTotalCompra1.TabIndex = 9;
            this.lblTotalCompra1.Text = "Valor Total Compra";
            this.lblTotalCompra1.Visible = false;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(35, 262);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(160, 19);
            this.lblTotalCompra.TabIndex = 8;
            this.lblTotalCompra.Text = "Valor Total Compra:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(277, 116);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 26);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // picDescuento
            // 
            this.picDescuento.Image = global::Taller2.Properties.Resources.descuento;
            this.picDescuento.InitialImage = global::Taller2.Properties.Resources.descuento;
            this.picDescuento.Location = new System.Drawing.Point(493, 125);
            this.picDescuento.Name = "picDescuento";
            this.picDescuento.Size = new System.Drawing.Size(150, 150);
            this.picDescuento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDescuento.TabIndex = 10;
            this.picDescuento.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(254, 319);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 46);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(119, 319);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 46);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(681, 393);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.picDescuento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTotalCompra1);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.lblValorDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.cmbTemporada);
            this.Controls.Add(this.lblTemporada);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTituloDescuento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Descuento";
            ((System.ComponentModel.ISupportInitialize)(this.picDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDescuento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox cmbTemporada;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblValorDescuento;
        private System.Windows.Forms.Label lblTotalCompra1;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.PictureBox picDescuento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
    }
}