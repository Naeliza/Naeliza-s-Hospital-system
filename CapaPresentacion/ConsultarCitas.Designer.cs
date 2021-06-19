namespace CapaPresentacion
{
    partial class ConsultarCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCitas));
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.btnFecha = new System.Windows.Forms.PictureBox();
            this.btnPaciente = new System.Windows.Forms.PictureBox();
            this.btnDoctor = new System.Windows.Forms.PictureBox();
            this.btnImprimirFecha = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimirDoctor = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Size = new System.Drawing.Size(285, 39);
            this.txtNombre.OnValueChanged += new System.EventHandler(this.txtNombre_OnValueChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Iconimage")));
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.Location = new System.Drawing.Point(0, 540);
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            this.btnAtras.Location = new System.Drawing.Point(627, 533);
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(56, 19);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(285, 30);
            this.Fecha.TabIndex = 47;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            this.Fecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fecha_MouseDown);
            // 
            // btnFecha
            // 
            this.btnFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnFecha.Image")));
            this.btnFecha.Location = new System.Drawing.Point(393, 52);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(56, 53);
            this.btnFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFecha.TabIndex = 52;
            this.btnFecha.TabStop = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.Location = new System.Drawing.Point(493, 52);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(56, 53);
            this.btnPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPaciente.TabIndex = 53;
            this.btnPaciente.TabStop = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctor.Image")));
            this.btnDoctor.Location = new System.Drawing.Point(585, 52);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(56, 53);
            this.btnDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDoctor.TabIndex = 54;
            this.btnDoctor.TabStop = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnImprimirFecha
            // 
            this.btnImprimirFecha.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirFecha.BorderRadius = 0;
            this.btnImprimirFecha.ButtonText = "          Imprimir";
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
            this.btnImprimirFecha.Location = new System.Drawing.Point(419, 540);
            this.btnImprimirFecha.Name = "btnImprimirFecha";
            this.btnImprimirFecha.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimirFecha.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirFecha.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirFecha.selected = false;
            this.btnImprimirFecha.Size = new System.Drawing.Size(212, 45);
            this.btnImprimirFecha.TabIndex = 68;
            this.btnImprimirFecha.Text = "          Imprimir";
            this.btnImprimirFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFecha.Textcolor = System.Drawing.Color.White;
            this.btnImprimirFecha.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFecha.Click += new System.EventHandler(this.btnImprimirFecha_Click);
            // 
            // btnImprimirDoctor
            // 
            this.btnImprimirDoctor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirDoctor.BorderRadius = 0;
            this.btnImprimirDoctor.ButtonText = "          Imprimir";
            this.btnImprimirDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirDoctor.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimirDoctor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimirDoctor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimirDoctor.Iconimage")));
            this.btnImprimirDoctor.Iconimage_right = null;
            this.btnImprimirDoctor.Iconimage_right_Selected = null;
            this.btnImprimirDoctor.Iconimage_Selected = null;
            this.btnImprimirDoctor.IconMarginLeft = 0;
            this.btnImprimirDoctor.IconMarginRight = 0;
            this.btnImprimirDoctor.IconRightVisible = true;
            this.btnImprimirDoctor.IconRightZoom = 0D;
            this.btnImprimirDoctor.IconVisible = true;
            this.btnImprimirDoctor.IconZoom = 90D;
            this.btnImprimirDoctor.IsTab = false;
            this.btnImprimirDoctor.Location = new System.Drawing.Point(201, 540);
            this.btnImprimirDoctor.Name = "btnImprimirDoctor";
            this.btnImprimirDoctor.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimirDoctor.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirDoctor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirDoctor.selected = false;
            this.btnImprimirDoctor.Size = new System.Drawing.Size(212, 45);
            this.btnImprimirDoctor.TabIndex = 69;
            this.btnImprimirDoctor.Text = "          Imprimir";
            this.btnImprimirDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirDoctor.Textcolor = System.Drawing.Color.White;
            this.btnImprimirDoctor.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirDoctor.Click += new System.EventHandler(this.btnImprimirDoctor_Click);
            // 
            // ConsultarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 625);
            this.Controls.Add(this.btnImprimirDoctor);
            this.Controls.Add(this.btnImprimirFecha);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.Fecha);
            this.Name = "ConsultarCitas";
            this.Text = "ConsultarCitas";
            this.Load += new System.EventHandler(this.ConsultarCitas_Load);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.Fecha, 0);
            this.Controls.SetChildIndex(this.btnFecha, 0);
            this.Controls.SetChildIndex(this.btnPaciente, 0);
            this.Controls.SetChildIndex(this.btnDoctor, 0);
            this.Controls.SetChildIndex(this.btnImprimirFecha, 0);
            this.Controls.SetChildIndex(this.btnImprimirDoctor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.PictureBox btnFecha;
        private System.Windows.Forms.PictureBox btnPaciente;
        private System.Windows.Forms.PictureBox btnDoctor;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimirFecha;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimirDoctor;
    }
}