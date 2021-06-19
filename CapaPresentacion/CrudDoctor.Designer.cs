namespace CapaPresentacion
{
    partial class CrudDoctor
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
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtExe = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEspecialidad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconVisible = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.IconRightVisible = true;
            this.btnInsertar.IconVisible = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconVisible = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconVisible = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.IconRightVisible = true;
            this.btnRefrescar.IconVisible = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconVisible = true;
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
            this.txtID.Location = new System.Drawing.Point(57, 550);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 39);
            this.txtID.TabIndex = 30;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.OnValueChanged += new System.EventHandler(this.txtID_OnValueChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
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
            this.txtNombre.Location = new System.Drawing.Point(156, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(341, 39);
            this.txtNombre.TabIndex = 31;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExe
            // 
            this.txtExe.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtExe.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtExe.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtExe.BorderThickness = 3;
            this.txtExe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExe.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExe.ForeColor = System.Drawing.Color.White;
            this.txtExe.isPassword = false;
            this.txtExe.Location = new System.Drawing.Point(156, 109);
            this.txtExe.Margin = new System.Windows.Forms.Padding(6);
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(341, 39);
            this.txtExe.TabIndex = 32;
            this.txtExe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtEspecialidad.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtEspecialidad.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtEspecialidad.BorderThickness = 3;
            this.txtEspecialidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEspecialidad.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.ForeColor = System.Drawing.Color.White;
            this.txtEspecialidad.isPassword = false;
            this.txtEspecialidad.Location = new System.Drawing.Point(156, 160);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(6);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(341, 39);
            this.txtEspecialidad.TabIndex = 33;
            this.txtEspecialidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 566);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 23);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(27, 125);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(120, 23);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Exequatur:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(53, 74);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(94, 23);
            this.bunifuCustomLabel3.TabIndex = 36;
            this.bunifuCustomLabel3.Text = "Nombre:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 176);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(145, 23);
            this.bunifuCustomLabel4.TabIndex = 37;
            this.bunifuCustomLabel4.Text = "Especialidad:";
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AllowUserToResizeColumns = false;
            this.dgvMedicos.AllowUserToResizeRows = false;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicos.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvMedicos.Location = new System.Drawing.Point(12, 218);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicos.Size = new System.Drawing.Size(560, 323);
            this.dgvMedicos.TabIndex = 38;
            // 
            // CrudDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtExe);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Name = "CrudDoctor";
            this.Text = "Form1";
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
            this.Controls.SetChildIndex(this.txtExe, 0);
            this.Controls.SetChildIndex(this.txtEspecialidad, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel1, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel3, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel4, 0);
            this.Controls.SetChildIndex(this.dgvMedicos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtExe;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtEspecialidad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.DataGridView dgvMedicos;
    }
}