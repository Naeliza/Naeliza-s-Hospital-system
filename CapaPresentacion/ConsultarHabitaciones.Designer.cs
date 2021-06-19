namespace CapaPresentacion
{
    partial class ConsultarHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarHabitaciones));
            this.cbxTexto = new System.Windows.Forms.ComboBox();
            this.btnHabi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHabi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(822, 58);
            this.txtNombre.Size = new System.Drawing.Size(560, 39);
            // 
            // btnImprimir
            // 
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
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
            this.cbxTexto.Location = new System.Drawing.Point(79, 65);
            this.cbxTexto.Name = "cbxTexto";
            this.cbxTexto.Size = new System.Drawing.Size(341, 31);
            this.cbxTexto.TabIndex = 58;
            this.cbxTexto.TextChanged += new System.EventHandler(this.cbxTexto_TextChanged);
            // 
            // btnHabi
            // 
            this.btnHabi.Image = ((System.Drawing.Image)(resources.GetObject("btnHabi.Image")));
            this.btnHabi.Location = new System.Drawing.Point(526, 55);
            this.btnHabi.Name = "btnHabi";
            this.btnHabi.Size = new System.Drawing.Size(56, 50);
            this.btnHabi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHabi.TabIndex = 59;
            this.btnHabi.TabStop = false;
            this.btnHabi.Click += new System.EventHandler(this.btnHabi_Click);
            // 
            // ConsultarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 624);
            this.Controls.Add(this.btnHabi);
            this.Controls.Add(this.cbxTexto);
            this.Name = "ConsultarHabitaciones";
            this.Text = "ConsultarHabitaciones";
            this.Load += new System.EventHandler(this.ConsultarHabitaciones_Load);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.cbxTexto, 0);
            this.Controls.SetChildIndex(this.btnHabi, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHabi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTexto;
        private System.Windows.Forms.PictureBox btnHabi;
    }
}