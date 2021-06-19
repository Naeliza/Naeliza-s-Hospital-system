namespace CapaPresentacion
{
    partial class ConsultarMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMedicos));
            this.btnNom = new System.Windows.Forms.PictureBox();
            this.btnEspe = new System.Windows.Forms.PictureBox();
            this.btnImprimirNom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimirEspe = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEspe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(43, 63);
            this.txtNombre.Size = new System.Drawing.Size(347, 39);
            this.txtNombre.OnValueChanged += new System.EventHandler(this.txtNombre_OnValueChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.Location = new System.Drawing.Point(-44, 539);
            this.btnImprimir.Size = new System.Drawing.Size(10, 45);
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            this.btnAtras.Location = new System.Drawing.Point(555, 532);
            // 
            // btnNom
            // 
            this.btnNom.Image = ((System.Drawing.Image)(resources.GetObject("btnNom.Image")));
            this.btnNom.Location = new System.Drawing.Point(450, 55);
            this.btnNom.Name = "btnNom";
            this.btnNom.Size = new System.Drawing.Size(56, 53);
            this.btnNom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNom.TabIndex = 51;
            this.btnNom.TabStop = false;
            this.btnNom.Click += new System.EventHandler(this.btnNom_Click);
            // 
            // btnEspe
            // 
            this.btnEspe.Image = ((System.Drawing.Image)(resources.GetObject("btnEspe.Image")));
            this.btnEspe.Location = new System.Drawing.Point(573, 55);
            this.btnEspe.Name = "btnEspe";
            this.btnEspe.Size = new System.Drawing.Size(56, 53);
            this.btnEspe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEspe.TabIndex = 52;
            this.btnEspe.TabStop = false;
            this.btnEspe.Click += new System.EventHandler(this.btnEspe_Click);
            // 
            // btnImprimirNom
            // 
            this.btnImprimirNom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirNom.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirNom.BorderRadius = 0;
            this.btnImprimirNom.ButtonText = "            Imprimir";
            this.btnImprimirNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirNom.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimirNom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimirNom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimirNom.Iconimage")));
            this.btnImprimirNom.Iconimage_right = null;
            this.btnImprimirNom.Iconimage_right_Selected = null;
            this.btnImprimirNom.Iconimage_Selected = null;
            this.btnImprimirNom.IconMarginLeft = 0;
            this.btnImprimirNom.IconMarginRight = 0;
            this.btnImprimirNom.IconRightVisible = true;
            this.btnImprimirNom.IconRightZoom = 0D;
            this.btnImprimirNom.IconVisible = true;
            this.btnImprimirNom.IconZoom = 90D;
            this.btnImprimirNom.IsTab = false;
            this.btnImprimirNom.Location = new System.Drawing.Point(75, 539);
            this.btnImprimirNom.Name = "btnImprimirNom";
            this.btnImprimirNom.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimirNom.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirNom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirNom.selected = false;
            this.btnImprimirNom.Size = new System.Drawing.Size(212, 45);
            this.btnImprimirNom.TabIndex = 53;
            this.btnImprimirNom.Text = "            Imprimir";
            this.btnImprimirNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirNom.Textcolor = System.Drawing.Color.White;
            this.btnImprimirNom.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirNom.Click += new System.EventHandler(this.btnImprimirNom_Click);
            // 
            // btnImprimirEspe
            // 
            this.btnImprimirEspe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirEspe.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirEspe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirEspe.BorderRadius = 0;
            this.btnImprimirEspe.ButtonText = "            Imprimir";
            this.btnImprimirEspe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirEspe.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimirEspe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimirEspe.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimirEspe.Iconimage")));
            this.btnImprimirEspe.Iconimage_right = null;
            this.btnImprimirEspe.Iconimage_right_Selected = null;
            this.btnImprimirEspe.Iconimage_Selected = null;
            this.btnImprimirEspe.IconMarginLeft = 0;
            this.btnImprimirEspe.IconMarginRight = 0;
            this.btnImprimirEspe.IconRightVisible = true;
            this.btnImprimirEspe.IconRightZoom = 0D;
            this.btnImprimirEspe.IconVisible = true;
            this.btnImprimirEspe.IconZoom = 90D;
            this.btnImprimirEspe.IsTab = false;
            this.btnImprimirEspe.Location = new System.Drawing.Point(309, 539);
            this.btnImprimirEspe.Name = "btnImprimirEspe";
            this.btnImprimirEspe.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimirEspe.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirEspe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirEspe.selected = false;
            this.btnImprimirEspe.Size = new System.Drawing.Size(212, 45);
            this.btnImprimirEspe.TabIndex = 54;
            this.btnImprimirEspe.Text = "            Imprimir";
            this.btnImprimirEspe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirEspe.Textcolor = System.Drawing.Color.White;
            this.btnImprimirEspe.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirEspe.Click += new System.EventHandler(this.btnImprimirEspe_Click);
            // 
            // ConsultarMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 630);
            this.Controls.Add(this.btnImprimirEspe);
            this.Controls.Add(this.btnImprimirNom);
            this.Controls.Add(this.btnEspe);
            this.Controls.Add(this.btnNom);
            this.Name = "ConsultarMedicos";
            this.Text = "ConsultarMedicos";
            this.Load += new System.EventHandler(this.ConsultarMedicos_Load);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnNom, 0);
            this.Controls.SetChildIndex(this.btnEspe, 0);
            this.Controls.SetChildIndex(this.btnImprimirNom, 0);
            this.Controls.SetChildIndex(this.btnImprimirEspe, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEspe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnNom;
        private System.Windows.Forms.PictureBox btnEspe;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimirNom;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimirEspe;
    }
}