namespace CapaPresentacion
{
    partial class CrudHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudHabitaciones));
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.dgvHabi = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnInternar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            this.btnAtras.Location = new System.Drawing.Point(579, 520);
            // 
            // btnInsertar
            // 
            this.btnInsertar.IconRightVisible = true;
            this.btnInsertar.IconVisible = true;
            this.btnInsertar.Location = new System.Drawing.Point(577, 58);
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.Location = new System.Drawing.Point(577, 365);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconVisible = true;
            this.btnBorrar.Location = new System.Drawing.Point(577, 208);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.IconRightVisible = true;
            this.btnRefrescar.IconVisible = true;
            this.btnRefrescar.Location = new System.Drawing.Point(577, 286);
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.Location = new System.Drawing.Point(577, 134);
            // 
            // cbxTipo
            // 
            this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            this.cbxTipo.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Doble",
            "Privada",
            "Suite"});
            this.cbxTipo.Location = new System.Drawing.Point(155, 168);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(341, 31);
            this.cbxTipo.TabIndex = 57;
            this.cbxTipo.TextChanged += new System.EventHandler(this.cbxTipo_TextChanged);
            // 
            // dgvHabi
            // 
            this.dgvHabi.AllowUserToAddRows = false;
            this.dgvHabi.AllowUserToDeleteRows = false;
            this.dgvHabi.AllowUserToResizeColumns = false;
            this.dgvHabi.AllowUserToResizeRows = false;
            this.dgvHabi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvHabi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHabi.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvHabi.Location = new System.Drawing.Point(12, 218);
            this.dgvHabi.Name = "dgvHabi";
            this.dgvHabi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHabi.Size = new System.Drawing.Size(561, 323);
            this.dgvHabi.TabIndex = 56;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(85, 176);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(61, 23);
            this.bunifuCustomLabel4.TabIndex = 55;
            this.bunifuCustomLabel4.Text = "Tipo:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(66, 74);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 23);
            this.bunifuCustomLabel3.TabIndex = 54;
            this.bunifuCustomLabel3.Text = "Precio:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(60, 125);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(95, 23);
            this.bunifuCustomLabel2.TabIndex = 53;
            this.bunifuCustomLabel2.Text = "Numero:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 566);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 23);
            this.bunifuCustomLabel1.TabIndex = 52;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // txtNum
            // 
            this.txtNum.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtNum.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtNum.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtNum.BorderThickness = 3;
            this.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNum.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.isPassword = false;
            this.txtNum.Location = new System.Drawing.Point(155, 109);
            this.txtNum.Margin = new System.Windows.Forms.Padding(6);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(341, 39);
            this.txtNum.TabIndex = 51;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtPrecio.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtPrecio.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtPrecio.BorderThickness = 3;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.isPassword = false;
            this.txtPrecio.Location = new System.Drawing.Point(155, 58);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(341, 39);
            this.txtPrecio.TabIndex = 50;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtID.TabIndex = 49;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.OnValueChanged += new System.EventHandler(this.txtID_OnValueChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // btnInternar
            // 
            this.btnInternar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInternar.BackColor = System.Drawing.Color.Transparent;
            this.btnInternar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInternar.BorderRadius = 0;
            this.btnInternar.ButtonText = "       Internamiento";
            this.btnInternar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternar.DisabledColor = System.Drawing.Color.Gray;
            this.btnInternar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInternar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInternar.Iconimage")));
            this.btnInternar.Iconimage_right = null;
            this.btnInternar.Iconimage_right_Selected = null;
            this.btnInternar.Iconimage_Selected = null;
            this.btnInternar.IconMarginLeft = 0;
            this.btnInternar.IconMarginRight = 0;
            this.btnInternar.IconRightVisible = true;
            this.btnInternar.IconRightZoom = 0D;
            this.btnInternar.IconVisible = true;
            this.btnInternar.IconZoom = 90D;
            this.btnInternar.IsTab = false;
            this.btnInternar.Location = new System.Drawing.Point(577, 448);
            this.btnInternar.Name = "btnInternar";
            this.btnInternar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInternar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnInternar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInternar.selected = false;
            this.btnInternar.Size = new System.Drawing.Size(211, 52);
            this.btnInternar.TabIndex = 58;
            this.btnInternar.Text = "       Internamiento";
            this.btnInternar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternar.Textcolor = System.Drawing.Color.White;
            this.btnInternar.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternar.Click += new System.EventHandler(this.btnInternar_Click);
            // 
            // CrudHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.btnInternar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.dgvHabi);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtID);
            this.Name = "CrudHabitaciones";
            this.Text = "CrudHabitaciones";
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnInsertar, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnRefrescar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtNum, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel1, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel3, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel4, 0);
            this.Controls.SetChildIndex(this.dgvHabi, 0);
            this.Controls.SetChildIndex(this.cbxTipo, 0);
            this.Controls.SetChildIndex(this.btnInternar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.DataGridView dgvHabi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtNum;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtPrecio;
        public Bunifu.Framework.UI.BunifuFlatButton btnInternar;
    }
}