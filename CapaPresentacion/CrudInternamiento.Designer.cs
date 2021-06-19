namespace CapaPresentacion
{
    partial class CrudInternamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudInternamiento));
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.dgvInternamiento = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIDPaciente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtHabi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAlta = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            this.btnAtras.Location = new System.Drawing.Point(589, 515);
            // 
            // btnInsertar
            // 
            this.btnInsertar.IconRightVisible = true;
            this.btnInsertar.IconVisible = true;
            this.btnInsertar.Location = new System.Drawing.Point(588, 66);
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.Location = new System.Drawing.Point(588, 361);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconVisible = true;
            this.btnBorrar.Location = new System.Drawing.Point(589, 209);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.IconRightVisible = true;
            this.btnRefrescar.IconVisible = true;
            this.btnRefrescar.Location = new System.Drawing.Point(588, 289);
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.Location = new System.Drawing.Point(589, 133);
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(322, 549);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(155, 30);
            this.Fecha.TabIndex = 55;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            // 
            // dgvInternamiento
            // 
            this.dgvInternamiento.AllowUserToAddRows = false;
            this.dgvInternamiento.AllowUserToDeleteRows = false;
            this.dgvInternamiento.AllowUserToResizeColumns = false;
            this.dgvInternamiento.AllowUserToResizeRows = false;
            this.dgvInternamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternamiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvInternamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternamiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternamiento.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvInternamiento.Location = new System.Drawing.Point(9, 165);
            this.dgvInternamiento.Name = "dgvInternamiento";
            this.dgvInternamiento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternamiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternamiento.Size = new System.Drawing.Size(558, 363);
            this.dgvInternamiento.TabIndex = 54;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(35, 82);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(131, 23);
            this.bunifuCustomLabel2.TabIndex = 52;
            this.bunifuCustomLabel2.Text = "ID Paciente:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 555);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 23);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtIDPaciente.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtIDPaciente.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtIDPaciente.BorderThickness = 3;
            this.txtIDPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDPaciente.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPaciente.ForeColor = System.Drawing.Color.White;
            this.txtIDPaciente.isPassword = false;
            this.txtIDPaciente.Location = new System.Drawing.Point(175, 66);
            this.txtIDPaciente.Margin = new System.Windows.Forms.Padding(6);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(341, 39);
            this.txtIDPaciente.TabIndex = 49;
            this.txtIDPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPaciente_KeyPress);
            // 
            // txtID
            // 
            this.txtID.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtID.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtID.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtID.BorderThickness = 3;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.isPassword = false;
            this.txtID.Location = new System.Drawing.Point(60, 545);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 39);
            this.txtID.TabIndex = 48;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.OnValueChanged += new System.EventHandler(this.txtID_OnValueChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 133);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(155, 23);
            this.bunifuCustomLabel4.TabIndex = 53;
            this.bunifuCustomLabel4.Text = "ID Habitacion:";
            // 
            // txtHabi
            // 
            this.txtHabi.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtHabi.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtHabi.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtHabi.BorderThickness = 3;
            this.txtHabi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHabi.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabi.ForeColor = System.Drawing.Color.White;
            this.txtHabi.isPassword = false;
            this.txtHabi.Location = new System.Drawing.Point(175, 117);
            this.txtHabi.Margin = new System.Windows.Forms.Padding(6);
            this.txtHabi.Name = "txtHabi";
            this.txtHabi.Size = new System.Drawing.Size(341, 39);
            this.txtHabi.TabIndex = 50;
            this.txtHabi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHabi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHabi_KeyPress);
            // 
            // btnAlta
            // 
            this.btnAlta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAlta.BackColor = System.Drawing.Color.Transparent;
            this.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlta.BorderRadius = 0;
            this.btnAlta.ButtonText = "   Alta medica";
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAlta.Iconimage")));
            this.btnAlta.Iconimage_right = null;
            this.btnAlta.Iconimage_right_Selected = null;
            this.btnAlta.Iconimage_Selected = null;
            this.btnAlta.IconMarginLeft = 0;
            this.btnAlta.IconMarginRight = 0;
            this.btnAlta.IconRightVisible = true;
            this.btnAlta.IconRightZoom = 0D;
            this.btnAlta.IconVisible = true;
            this.btnAlta.IconZoom = 90D;
            this.btnAlta.IsTab = false;
            this.btnAlta.Location = new System.Drawing.Point(589, 441);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAlta.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAlta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlta.selected = false;
            this.btnAlta.Size = new System.Drawing.Size(211, 52);
            this.btnAlta.TabIndex = 56;
            this.btnAlta.Text = "   Alta medica";
            this.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Textcolor = System.Drawing.Color.White;
            this.btnAlta.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // CrudInternamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.dgvInternamiento);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtHabi);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.txtID);
            this.Name = "CrudInternamiento";
            this.Text = "CrudInternamiento";
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtIDPaciente, 0);
            this.Controls.SetChildIndex(this.txtHabi, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel1, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel4, 0);
            this.Controls.SetChildIndex(this.dgvInternamiento, 0);
            this.Controls.SetChildIndex(this.Fecha, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnInsertar, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnRefrescar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.btnAlta, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.DataGridView dgvInternamiento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtIDPaciente;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtHabi;
        public Bunifu.Framework.UI.BunifuFlatButton btnAlta;
    }
}