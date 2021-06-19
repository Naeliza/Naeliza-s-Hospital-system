namespace CapaPresentacion
{
    partial class CrudAltaMedica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIDInternamiento = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dgvAltas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            this.btnAtras.Location = new System.Drawing.Point(872, 482);
            // 
            // btnInsertar
            // 
            this.btnInsertar.ButtonText = "            Alta";
            this.btnInsertar.IconRightVisible = true;
            this.btnInsertar.IconVisible = true;
            this.btnInsertar.Location = new System.Drawing.Point(872, 58);
            this.btnInsertar.Text = "            Alta";
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.Location = new System.Drawing.Point(872, 392);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconVisible = true;
            this.btnBorrar.Location = new System.Drawing.Point(872, 210);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.IconRightVisible = true;
            this.btnRefrescar.IconVisible = true;
            this.btnRefrescar.Location = new System.Drawing.Point(872, 301);
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.Location = new System.Drawing.Point(872, 136);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(1052, 12);
            this.BtnCerrar.Size = new System.Drawing.Size(31, 30);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(1001, 12);
            this.btnMinimizar.Size = new System.Drawing.Size(32, 30);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(121, 74);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(188, 23);
            this.bunifuCustomLabel2.TabIndex = 56;
            this.bunifuCustomLabel2.Text = "ID Internamiento:";
            // 
            // txtIDInternamiento
            // 
            this.txtIDInternamiento.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtIDInternamiento.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtIDInternamiento.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtIDInternamiento.BorderThickness = 3;
            this.txtIDInternamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDInternamiento.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDInternamiento.ForeColor = System.Drawing.Color.White;
            this.txtIDInternamiento.isPassword = false;
            this.txtIDInternamiento.Location = new System.Drawing.Point(318, 58);
            this.txtIDInternamiento.Margin = new System.Windows.Forms.Padding(6);
            this.txtIDInternamiento.Name = "txtIDInternamiento";
            this.txtIDInternamiento.Size = new System.Drawing.Size(341, 39);
            this.txtIDInternamiento.TabIndex = 54;
            this.txtIDInternamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDInternamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDInternamiento_KeyPress);
            // 
            // FechaSalida
            // 
            this.FechaSalida.CalendarFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSalida.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaSalida.Location = new System.Drawing.Point(561, 501);
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.Size = new System.Drawing.Size(155, 30);
            this.FechaSalida.TabIndex = 60;
            this.FechaSalida.ValueChanged += new System.EventHandler(this.FechaSalida_ValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(120, 508);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 23);
            this.bunifuCustomLabel1.TabIndex = 58;
            this.bunifuCustomLabel1.Text = "ID:";
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
            this.txtID.Location = new System.Drawing.Point(169, 498);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 39);
            this.txtID.TabIndex = 57;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.OnValueChanged += new System.EventHandler(this.txtID_OnValueChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // dgvAltas
            // 
            this.dgvAltas.AllowUserToAddRows = false;
            this.dgvAltas.AllowUserToDeleteRows = false;
            this.dgvAltas.AllowUserToResizeColumns = false;
            this.dgvAltas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAltas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAltas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAltas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAltas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAltas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAltas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAltas.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvAltas.Location = new System.Drawing.Point(12, 106);
            this.dgvAltas.Name = "dgvAltas";
            this.dgvAltas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAltas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAltas.Size = new System.Drawing.Size(843, 389);
            this.dgvAltas.TabIndex = 61;
            // 
            // CrudAltaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 577);
            this.Controls.Add(this.dgvAltas);
            this.Controls.Add(this.FechaSalida);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtIDInternamiento);
            this.Name = "CrudAltaMedica";
            this.Text = "CrudAltaMedica";
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnInsertar, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnRefrescar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtIDInternamiento, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel2, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel1, 0);
            this.Controls.SetChildIndex(this.FechaSalida, 0);
            this.Controls.SetChildIndex(this.dgvAltas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtIDInternamiento;
        private System.Windows.Forms.DateTimePicker FechaSalida;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private System.Windows.Forms.DataGridView dgvAltas;
    }
}