namespace CapaPresentacion
{
    partial class CrudPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudPacientes));
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCed = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbxAsegurado = new System.Windows.Forms.ComboBox();
            this.btnCita = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            this.btnAtras.Location = new System.Drawing.Point(575, 543);
            // 
            // btnInsertar
            // 
            this.btnInsertar.IconRightVisible = true;
            this.btnInsertar.IconVisible = true;
            this.btnInsertar.Location = new System.Drawing.Point(575, 80);
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.Location = new System.Drawing.Point(577, 368);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconVisible = true;
            this.btnBorrar.Location = new System.Drawing.Point(575, 229);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.IconRightVisible = true;
            this.btnRefrescar.IconVisible = true;
            this.btnRefrescar.Location = new System.Drawing.Point(575, 296);
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.Location = new System.Drawing.Point(577, 147);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeColumns = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 218);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.Size = new System.Drawing.Size(557, 323);
            this.dgvPacientes.TabIndex = 47;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 176);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(124, 23);
            this.bunifuCustomLabel4.TabIndex = 46;
            this.bunifuCustomLabel4.Text = "Asegurad@:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(52, 74);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(94, 23);
            this.bunifuCustomLabel3.TabIndex = 45;
            this.bunifuCustomLabel3.Text = "Nombre:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(60, 125);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(86, 23);
            this.bunifuCustomLabel2.TabIndex = 44;
            this.bunifuCustomLabel2.Text = "Cedula:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 566);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 23);
            this.bunifuCustomLabel1.TabIndex = 43;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // txtCed
            // 
            this.txtCed.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtCed.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtCed.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtCed.BorderThickness = 3;
            this.txtCed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCed.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCed.ForeColor = System.Drawing.Color.White;
            this.txtCed.isPassword = false;
            this.txtCed.Location = new System.Drawing.Point(155, 109);
            this.txtCed.Margin = new System.Windows.Forms.Padding(6);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(341, 39);
            this.txtCed.TabIndex = 41;
            this.txtCed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtNombre.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtNombre.BorderThickness = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(155, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(341, 39);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtID.Location = new System.Drawing.Point(56, 550);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 39);
            this.txtID.TabIndex = 39;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.OnValueChanged += new System.EventHandler(this.txtID_OnValueChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // cbxAsegurado
            // 
            this.cbxAsegurado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.cbxAsegurado.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAsegurado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxAsegurado.FormattingEnabled = true;
            this.cbxAsegurado.Items.AddRange(new object[] {
            "Asegurado",
            "No Asegurado"});
            this.cbxAsegurado.Location = new System.Drawing.Point(155, 168);
            this.cbxAsegurado.Name = "cbxAsegurado";
            this.cbxAsegurado.Size = new System.Drawing.Size(341, 31);
            this.cbxAsegurado.TabIndex = 48;
            // 
            // btnCita
            // 
            this.btnCita.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCita.BackColor = System.Drawing.Color.Transparent;
            this.btnCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCita.BorderRadius = 0;
            this.btnCita.ButtonText = "   Hacer Cita";
            this.btnCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCita.DisabledColor = System.Drawing.Color.Gray;
            this.btnCita.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCita.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCita.Iconimage")));
            this.btnCita.Iconimage_right = null;
            this.btnCita.Iconimage_right_Selected = null;
            this.btnCita.Iconimage_Selected = null;
            this.btnCita.IconMarginLeft = 0;
            this.btnCita.IconMarginRight = 0;
            this.btnCita.IconRightVisible = true;
            this.btnCita.IconRightZoom = 0D;
            this.btnCita.IconVisible = true;
            this.btnCita.IconZoom = 90D;
            this.btnCita.IsTab = false;
            this.btnCita.Location = new System.Drawing.Point(575, 450);
            this.btnCita.Name = "btnCita";
            this.btnCita.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCita.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnCita.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCita.selected = false;
            this.btnCita.Size = new System.Drawing.Size(211, 52);
            this.btnCita.TabIndex = 49;
            this.btnCita.Text = "   Hacer Cita";
            this.btnCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCita.Textcolor = System.Drawing.Color.White;
            this.btnCita.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // CrudPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.cbxAsegurado);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Name = "CrudPacientes";
            this.Text = "CrudPacientes";
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnInsertar, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnRefrescar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtCed, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel1, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel3, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel4, 0);
            this.Controls.SetChildIndex(this.dgvPacientes, 0);
            this.Controls.SetChildIndex(this.cbxAsegurado, 0);
            this.Controls.SetChildIndex(this.btnCita, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCed;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private System.Windows.Forms.ComboBox cbxAsegurado;
        public Bunifu.Framework.UI.BunifuFlatButton btnCita;
    }
}