namespace CapaPresentacion
{
    partial class CrudCita
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
            this.dgvCita = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDoctor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtIDPaciente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Hora = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).BeginInit();
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
            // dgvCita
            // 
            this.dgvCita.AllowUserToAddRows = false;
            this.dgvCita.AllowUserToDeleteRows = false;
            this.dgvCita.AllowUserToResizeColumns = false;
            this.dgvCita.AllowUserToResizeRows = false;
            this.dgvCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCita.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCita.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCita.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCita.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvCita.Location = new System.Drawing.Point(12, 163);
            this.dgvCita.Name = "dgvCita";
            this.dgvCita.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCita.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCita.Size = new System.Drawing.Size(561, 323);
            this.dgvCita.TabIndex = 45;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(34, 125);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(113, 23);
            this.bunifuCustomLabel4.TabIndex = 44;
            this.bunifuCustomLabel4.Text = "ID Doctor:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 74);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(131, 23);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Text = "ID Paciente:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 529);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 23);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // txtDoctor
            // 
            this.txtDoctor.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtDoctor.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtDoctor.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtDoctor.BorderThickness = 3;
            this.txtDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctor.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor.ForeColor = System.Drawing.Color.White;
            this.txtDoctor.isPassword = false;
            this.txtDoctor.Location = new System.Drawing.Point(156, 109);
            this.txtDoctor.Margin = new System.Windows.Forms.Padding(6);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(341, 39);
            this.txtDoctor.TabIndex = 41;
            this.txtDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctor_KeyPress);
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
            this.txtIDPaciente.Location = new System.Drawing.Point(156, 58);
            this.txtIDPaciente.Margin = new System.Windows.Forms.Padding(6);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(341, 39);
            this.txtIDPaciente.TabIndex = 40;
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
            this.txtID.Location = new System.Drawing.Point(57, 513);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 39);
            this.txtID.TabIndex = 39;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.OnValueChanged += new System.EventHandler(this.txtID_OnValueChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(208, 522);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(155, 30);
            this.Fecha.TabIndex = 46;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            // 
            // Hora
            // 
            this.Hora.CalendarFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora.Location = new System.Drawing.Point(369, 523);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(151, 30);
            this.Hora.TabIndex = 47;
            this.Hora.ValueChanged += new System.EventHandler(this.Hora_ValueChanged);
            // 
            // CrudCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.dgvCita);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.txtID);
            this.Name = "CrudCita";
            this.Text = "CrudCita";
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnInsertar, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnRefrescar, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtIDPaciente, 0);
            this.Controls.SetChildIndex(this.txtDoctor, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel1, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel2, 0);
            this.Controls.SetChildIndex(this.bunifuCustomLabel4, 0);
            this.Controls.SetChildIndex(this.dgvCita, 0);
            this.Controls.SetChildIndex(this.Fecha, 0);
            this.Controls.SetChildIndex(this.Hora, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCita;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtDoctor;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtIDPaciente;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.DateTimePicker Hora;
    }
}