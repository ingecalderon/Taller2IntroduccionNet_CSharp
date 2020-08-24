namespace Taller2
{
    partial class frmTaller2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picMainSalir = new System.Windows.Forms.PictureBox();
            this.picMainDescuento = new System.Windows.Forms.PictureBox();
            this.picMainCalificaciones = new System.Windows.Forms.PictureBox();
            this.picMainMayor18 = new System.Windows.Forms.PictureBox();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMainSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMayor18)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBienvenida.Location = new System.Drawing.Point(25, 34);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(529, 22);
            this.lblBienvenida.TabIndex = 6;
            this.lblBienvenida.Text = "\"BIENVENIDOS!!  -  TALLER 2 PROGRAMACION C# .NET\"";
            // 
            // btnDescuento
            // 
            this.btnDescuento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuento.Location = new System.Drawing.Point(402, 203);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(120, 50);
            this.btnDescuento.TabIndex = 11;
            this.btnDescuento.Text = "&Descuento";
            this.btnDescuento.UseVisualStyleBackColor = true;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.Location = new System.Drawing.Point(227, 203);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(120, 50);
            this.btnCalificaciones.TabIndex = 10;
            this.btnCalificaciones.Text = "&Calificaciones";
            this.btnCalificaciones.UseVisualStyleBackColor = true;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayor.Location = new System.Drawing.Point(52, 203);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(120, 50);
            this.btnMayor.TabIndex = 9;
            this.btnMayor.Text = "&Mayor de Edad";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(227, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 50);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Sa&lir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picMainSalir
            // 
            this.picMainSalir.Image = global::Taller2.Properties.Resources.salir;
            this.picMainSalir.InitialImage = global::Taller2.Properties.Resources.salir;
            this.picMainSalir.Location = new System.Drawing.Point(237, 279);
            this.picMainSalir.Name = "picMainSalir";
            this.picMainSalir.Size = new System.Drawing.Size(100, 100);
            this.picMainSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainSalir.TabIndex = 16;
            this.picMainSalir.TabStop = false;
            this.tipMain.SetToolTip(this.picMainSalir, "Salir del programa");
            // 
            // picMainDescuento
            // 
            this.picMainDescuento.Image = global::Taller2.Properties.Resources.descuento;
            this.picMainDescuento.InitialImage = global::Taller2.Properties.Resources.descuento;
            this.picMainDescuento.Location = new System.Drawing.Point(411, 93);
            this.picMainDescuento.Name = "picMainDescuento";
            this.picMainDescuento.Size = new System.Drawing.Size(100, 100);
            this.picMainDescuento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainDescuento.TabIndex = 14;
            this.picMainDescuento.TabStop = false;
            this.tipMain.SetToolTip(this.picMainDescuento, "Verifica los descuentos de temporada");
            // 
            // picMainCalificaciones
            // 
            this.picMainCalificaciones.Image = global::Taller2.Properties.Resources.calificaciones;
            this.picMainCalificaciones.InitialImage = global::Taller2.Properties.Resources.calificaciones;
            this.picMainCalificaciones.Location = new System.Drawing.Point(237, 93);
            this.picMainCalificaciones.Name = "picMainCalificaciones";
            this.picMainCalificaciones.Size = new System.Drawing.Size(100, 100);
            this.picMainCalificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainCalificaciones.TabIndex = 13;
            this.picMainCalificaciones.TabStop = false;
            this.tipMain.SetToolTip(this.picMainCalificaciones, "Valida como te fue en tu estudio");
            // 
            // picMainMayor18
            // 
            this.picMainMayor18.Image = global::Taller2.Properties.Resources.mayor18;
            this.picMainMayor18.InitialImage = global::Taller2.Properties.Resources.mayor18;
            this.picMainMayor18.Location = new System.Drawing.Point(62, 93);
            this.picMainMayor18.Name = "picMainMayor18";
            this.picMainMayor18.Size = new System.Drawing.Size(100, 100);
            this.picMainMayor18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainMayor18.TabIndex = 12;
            this.picMainMayor18.TabStop = false;
            this.tipMain.SetToolTip(this.picMainMayor18, "Mira si eres mayor de edad");
            // 
            // frmTaller2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(578, 459);
            this.ControlBox = false;
            this.Controls.Add(this.picMainSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.picMainDescuento);
            this.Controls.Add(this.picMainCalificaciones);
            this.Controls.Add(this.picMainMayor18);
            this.Controls.Add(this.btnDescuento);
            this.Controls.Add(this.btnCalificaciones);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.lblBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaller2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Taller 2";
            ((System.ComponentModel.ISupportInitialize)(this.picMainSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMayor18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox picMainDescuento;
        private System.Windows.Forms.PictureBox picMainCalificaciones;
        private System.Windows.Forms.PictureBox picMainMayor18;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.PictureBox picMainSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip tipMain;
    }
}

