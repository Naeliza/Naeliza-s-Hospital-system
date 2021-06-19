namespace CapaPresentacion
{
    partial class ConsultarPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPacientes));
            this.btnCed = new System.Windows.Forms.PictureBox();
            this.btnAse = new System.Windows.Forms.PictureBox();
            this.btnNom = new System.Windows.Forms.PictureBox();
            this.cbxTexto = new System.Windows.Forms.ComboBox();
            this.btnImprimirCed = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimirAsegurado = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(-44, 58);
            this.txtNombre.Size = new System.Drawing.Size(11, 39);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ButtonText = "           Imprimir";
            this.btnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Iconimage")));
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.Location = new System.Drawing.Point(0, 541);
            this.btnImprimir.Text = "           Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            this.btnAtras.Location = new System.Drawing.Point(625, 541);
            // 
            // btnCed
            // 
            this.btnCed.Image = ((System.Drawing.Image)(resources.GetObject("btnCed.Image")));
            this.btnCed.Location = new System.Drawing.Point(498, 55);
            this.btnCed.Name = "btnCed";
            this.btnCed.Size = new System.Drawing.Size(58, 53);
            this.btnCed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCed.TabIndex = 54;
            this.btnCed.TabStop = false;
            this.btnCed.Click += new System.EventHandler(this.btnCed_Click);
            // 
            // btnAse
            // 
            this.btnAse.Image = ((System.Drawing.Image)(resources.GetObject("btnAse.Image")));
            this.btnAse.Location = new System.Drawing.Point(581, 55);
            this.btnAse.Name = "btnAse";
            this.btnAse.Size = new System.Drawing.Size(58, 53);
            this.btnAse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAse.TabIndex = 53;
            this.btnAse.TabStop = false;
            this.btnAse.Click += new System.EventHandler(this.btnAse_Click);
            // 
            // btnNom
            // 
            this.btnNom.Image = ((System.Drawing.Image)(resources.GetObject("btnNom.Image")));
            this.btnNom.Location = new System.Drawing.Point(413, 54);
            this.btnNom.Name = "btnNom";
            this.btnNom.Size = new System.Drawing.Size(56, 53);
            this.btnNom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNom.TabIndex = 56;
            this.btnNom.TabStop = false;
            this.btnNom.Click += new System.EventHandler(this.btnNom_Click);
            // 
            // cbxTexto
            // 
            this.cbxTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.cbxTexto.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTexto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxTexto.FormattingEnabled = true;
            this.cbxTexto.Items.AddRange(new object[] {
            "Asegurado",
            "No Asegurado"});
            this.cbxTexto.Location = new System.Drawing.Point(43, 73);
            this.cbxTexto.Name = "cbxTexto";
            this.cbxTexto.Size = new System.Drawing.Size(317, 31);
            this.cbxTexto.TabIndex = 55;
            this.cbxTexto.TextChanged += new System.EventHandler(this.cbxTexto_TextChanged);
            // 
            // btnImprimirCed
            // 
            this.btnImprimirCed.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirCed.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirCed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirCed.BorderRadius = 0;
            this.btnImprimirCed.ButtonText = "        Imprimir";
            this.btnImprimirCed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirCed.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimirCed.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimirCed.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimirCed.Iconimage")));
            this.btnImprimirCed.Iconimage_right = null;
            this.btnImprimirCed.Iconimage_right_Selected = null;
            this.btnImprimirCed.Iconimage_Selected = null;
            this.btnImprimirCed.IconMarginLeft = 0;
            this.btnImprimirCed.IconMarginRight = 0;
            this.btnImprimirCed.IconRightVisible = true;
            this.btnImprimirCed.IconRightZoom = 0D;
            this.btnImprimirCed.IconVisible = true;
            this.btnImprimirCed.IconZoom = 90D;
            this.btnImprimirCed.IsTab = false;
            this.btnImprimirCed.Location = new System.Drawing.Point(413, 541);
            this.btnImprimirCed.Name = "btnImprimirCed";
            this.btnImprimirCed.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimirCed.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirCed.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirCed.selected = false;
            this.btnImprimirCed.Size = new System.Drawing.Size(212, 45);
            this.btnImprimirCed.TabIndex = 58;
            this.btnImprimirCed.Text = "        Imprimir";
            this.btnImprimirCed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirCed.Textcolor = System.Drawing.Color.White;
            this.btnImprimirCed.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCed.Click += new System.EventHandler(this.btnImprimirCed_Click);
            // 
            // btnImprimirAsegurado
            // 
            this.btnImprimirAsegurado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirAsegurado.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirAsegurado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirAsegurado.BorderRadius = 0;
            this.btnImprimirAsegurado.ButtonText = "        Imprimir";
            this.btnImprimirAsegurado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirAsegurado.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimirAsegurado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimirAsegurado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimirAsegurado.Iconimage")));
            this.btnImprimirAsegurado.Iconimage_right = null;
            this.btnImprimirAsegurado.Iconimage_right_Selected = null;
            this.btnImprimirAsegurado.Iconimage_Selected = null;
            this.btnImprimirAsegurado.IconMarginLeft = 0;
            this.btnImprimirAsegurado.IconMarginRight = 0;
            this.btnImprimirAsegurado.IconRightVisible = true;
            this.btnImprimirAsegurado.IconRightZoom = 0D;
            this.btnImprimirAsegurado.IconVisible = true;
            this.btnImprimirAsegurado.IconZoom = 90D;
            this.btnImprimirAsegurado.IsTab = false;
            this.btnImprimirAsegurado.Location = new System.Drawing.Point(207, 541);
            this.btnImprimirAsegurado.Name = "btnImprimirAsegurado";
            this.btnImprimirAsegurado.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimirAsegurado.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirAsegurado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirAsegurado.selected = false;
            this.btnImprimirAsegurado.Size = new System.Drawing.Size(212, 45);
            this.btnImprimirAsegurado.TabIndex = 57;
            this.btnImprimirAsegurado.Text = "        Imprimir";
            this.btnImprimirAsegurado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirAsegurado.Textcolor = System.Drawing.Color.White;
            this.btnImprimirAsegurado.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirAsegurado.Click += new System.EventHandler(this.btnImprimirAsegurado_Click);
            // 
            // ConsultarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 626);
            this.Controls.Add(this.btnImprimirCed);
            this.Controls.Add(this.btnImprimirAsegurado);
            this.Controls.Add(this.btnNom);
            this.Controls.Add(this.cbxTexto);
            this.Controls.Add(this.btnCed);
            this.Controls.Add(this.btnAse);
            this.Name = "ConsultarPacientes";
            this.Text = "ConsultarPacientes";
            this.Load += new System.EventHandler(this.ConsultarPacientes_Load);
            this.Controls.SetChildIndex(this.btnAse, 0);
            this.Controls.SetChildIndex(this.btnCed, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.cbxTexto, 0);
            this.Controls.SetChildIndex(this.btnNom, 0);
            this.Controls.SetChildIndex(this.btnImprimirAsegurado, 0);
            this.Controls.SetChildIndex(this.btnImprimirCed, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCed;
        private System.Windows.Forms.PictureBox btnAse;
        private System.Windows.Forms.PictureBox btnNom;
        private System.Windows.Forms.ComboBox cbxTexto;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimirCed;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimirAsegurado;
    }
}