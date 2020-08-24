namespace Taller2
{
    partial class frmCalificaciones
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
            this.lblTituloCalifica = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota5 = new System.Windows.Forms.TextBox();
            this.lblNota5 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloCalifica
            // 
            this.lblTituloCalifica.AutoSize = true;
            this.lblTituloCalifica.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCalifica.Font = new System.Drawing.Font("Impact", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCalifica.ForeColor = System.Drawing.Color.Brown;
            this.lblTituloCalifica.Location = new System.Drawing.Point(161, 85);
            this.lblTituloCalifica.Name = "lblTituloCalifica";
            this.lblTituloCalifica.Size = new System.Drawing.Size(481, 35);
            this.lblTituloCalifica.TabIndex = 1;
            this.lblTituloCalifica.Text = "APLICATIVO VALIDADOR DE CALIFICACIONES";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(280, 371);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 46);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(385, 156);
            this.txtNota1.MaxLength = 3;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(78, 26);
            this.txtNota1.TabIndex = 3;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(194, 163);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(177, 19);
            this.lblNota1.TabIndex = 2;
            this.lblNota1.Text = "Digite la Primera nota:";
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(385, 194);
            this.txtNota2.MaxLength = 3;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(78, 26);
            this.txtNota2.TabIndex = 5;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota2_KeyPress);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(194, 201);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(187, 19);
            this.lblNota2.TabIndex = 4;
            this.lblNota2.Text = "Digite la Segunda nota:";
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(385, 236);
            this.txtNota3.MaxLength = 3;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(78, 26);
            this.txtNota3.TabIndex = 7;
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota3_KeyPress);
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(194, 243);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(175, 19);
            this.lblNota3.TabIndex = 6;
            this.lblNota3.Text = "Digite la Tercera nota:";
            // 
            // txtNota4
            // 
            this.txtNota4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(385, 277);
            this.txtNota4.MaxLength = 3;
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(78, 26);
            this.txtNota4.TabIndex = 9;
            this.txtNota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota4_KeyPress);
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota4.Location = new System.Drawing.Point(194, 284);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(169, 19);
            this.lblNota4.TabIndex = 8;
            this.lblNota4.Text = "Digite la Cuarta nota:";
            // 
            // txtNota5
            // 
            this.txtNota5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota5.Location = new System.Drawing.Point(385, 324);
            this.txtNota5.MaxLength = 3;
            this.txtNota5.Name = "txtNota5";
            this.txtNota5.Size = new System.Drawing.Size(78, 26);
            this.txtNota5.TabIndex = 11;
            this.txtNota5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota5_KeyPress);
            // 
            // lblNota5
            // 
            this.lblNota5.AutoSize = true;
            this.lblNota5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota5.Location = new System.Drawing.Point(194, 331);
            this.lblNota5.Name = "lblNota5";
            this.lblNota5.Size = new System.Drawing.Size(168, 19);
            this.lblNota5.TabIndex = 10;
            this.lblNota5.Text = "Digite la Quinta nota:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblResultado.Location = new System.Drawing.Point(504, 177);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(108, 19);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "RESULTADO";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // lblResultado1
            // 
            this.lblResultado1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado1.ForeColor = System.Drawing.Color.Black;
            this.lblResultado1.Location = new System.Drawing.Point(503, 206);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(136, 16);
            this.lblResultado1.TabIndex = 14;
            this.lblResultado1.Text = "Comentario Resultado";
            this.lblResultado1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado1.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(415, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 46);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taller2.Properties.Resources.fondo_calificaciones;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 501);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNota5);
            this.Controls.Add(this.lblNota5);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblTituloCalifica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCalifica;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txtNota5;
        private System.Windows.Forms.Label lblNota5;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}