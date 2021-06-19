namespace CapaPresentacion
{
    partial class ConsultarInternamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarInternamiento));
            this.btnHabi = new System.Windows.Forms.PictureBox();
            this.cbxTexto = new System.Windows.Forms.ComboBox();
            this.btnFecha = new System.Windows.Forms.PictureBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.btnImprimirFecha = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHabi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(1317, 58);
            this.txtNombre.Size = new System.Drawing.Size(48, 39);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Iconimage")));
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.Location = new System.Drawing.Point(21, 539);
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            // 
            // btnHabi
            // 
            this.btnHabi.Image = ((System.Drawing.Image)(resources.GetObject("btnHabi.Image")));
            this.btnHabi.Location = new System.Drawing.Point(497, 55);
            this.btnHabi.Name = "btnHabi";
            this.btnHabi.Size = new System.Drawing.Size(56, 50);
            this.btnHabi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHabi.TabIndex = 61;
            this.btnHabi.TabStop = false;
            this.btnHabi.Click += new System.EventHandler(this.btnHabi_Click);
            // 
            // cbxTexto
            // 
            this.cbxTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.cbxTexto.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTexto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxTexto.FormattingEnabled = true;
            this.cbxTexto.Items.AddRange(new object[] {
            "Doble",
            "Privada",
            "Suite"});
            this.cbxTexto.Location = new System.Drawing.Point(58, 74);
            this.cbxTexto.Name = "cbxTexto";
            this.cbxTexto.Size = new System.Drawing.Size(341, 31);
            this.cbxTexto.TabIndex = 60;
            this.cbxTexto.TextChanged += new System.EventHandler(this.cbxTexto_TextChanged);
            // 
            // btnFecha
            // 
            this.btnFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnFecha.Image")));
            this.btnFecha.Location = new System.Drawing.Point(596, 55);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(58, 50);
            this.btnFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFecha.TabIndex = 63;
            this.btnFecha.TabStop = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(58, 19);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(341, 30);
            this.Fecha.TabIndex = 62;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            this.Fecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fecha_MouseDown);
            // 
            // btnImprimirFecha
            // 
            this.btnImprimirFecha.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirFecha.BorderRadius = 0;
            this.btnImprimirFecha.ButtonText = "            Imprimir";
            this.btnImprimirFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirFecha.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimirFecha.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimirFecha.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimirFecha.Iconimage")));
            this.btnImprimirFecha.Iconimage_right = null;
            this.btnImprimirFecha.Iconimage_right_Selected = null;
            this.btnImprimirFecha.Iconimage_Selected = null;
            this.btnImprimirFecha.IconMarginLeft = 0;
            this.btnImprimirFecha.IconMarginRight = 0;
            this.btnImprimirFecha.IconRightVisible = true;
            this.btnImprimirFecha.IconRightZoom = 0D;
            this.btnImprimirFecha.IconVisible = true;
            this.btnImprimirFecha.IconZoom = 90D;
            this.btnImprimirFecha.IsTab = false;
            this.btnImprimirFecha.Location = new System.Drawing.Point(239, 539);
            this.btnImprimirFecha.Name = "btnImprimirFecha";
            this.btnImprimirFecha.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimirFecha.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirFecha.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirFecha.selected = false;
            this.btnImprimirFecha.Size = new System.Drawing.Size(212, 45);
            this.btnImprimirFecha.TabIndex = 64;
            this.btnImprimirFecha.Text = "            Imprimir";
            this.btnImprimirFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFecha.Textcolor = System.Drawing.Color.White;
            this.btnImprimirFecha.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFecha.Click += new System.EventHandler(this.btnImprimirFecha_Click);
            // 
            // ConsultarInternamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.btnImprimirFecha);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.btnHabi);
            this.Controls.Add(this.cbxTexto);
            this.Name = "ConsultarInternamiento";
            this.Text = "ConsultarInternamiento";
            this.Load += new System.EventHandler(this.ConsultarInternamiento_Load);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.cbxTexto, 0);
            this.Controls.SetChildIndex(this.btnHabi, 0);
            this.Controls.SetChildIndex(this.Fecha, 0);
            this.Controls.SetChildIndex(this.btnFecha, 0);
            this.Controls.SetChildIndex(this.btnImprimirFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHabi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnHabi;
        private System.Windows.Forms.ComboBox cbxTexto;
        private System.Windows.Forms.PictureBox btnFecha;
        private System.Windows.Forms.DateTimePicker Fecha;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimirFecha;
    }
}