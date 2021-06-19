namespace CapaPresentacion
{
    partial class ConsultasBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasBase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvc = new System.Windows.Forms.DataGridView();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAtras = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvc)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(76)))), ((int)(((byte)(156)))));
            this.BtnCerrar.Location = new System.Drawing.Point(740, 12);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(76)))), ((int)(((byte)(156)))));
            this.btnMinimizar.Location = new System.Drawing.Point(701, 12);
            this.btnMinimizar.Size = new System.Drawing.Size(33, 33);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(784, 49);
            this.bunifuGradientPanel2.TabIndex = 20;
            this.bunifuGradientPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel2_MouseMove);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 590);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(784, 34);
            this.bunifuGradientPanel1.TabIndex = 21;
            // 
            // dgvc
            // 
            this.dgvc.AllowUserToAddRows = false;
            this.dgvc.AllowUserToDeleteRows = false;
            this.dgvc.AllowUserToResizeColumns = false;
            this.dgvc.AllowUserToResizeRows = false;
            this.dgvc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvc.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvc.Location = new System.Drawing.Point(43, 111);
            this.dgvc.Name = "dgvc";
            this.dgvc.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvc.Size = new System.Drawing.Size(665, 415);
            this.dgvc.TabIndex = 39;
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
            this.txtNombre.Location = new System.Drawing.Point(56, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(341, 39);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.BorderRadius = 0;
            this.btnImprimir.ButtonText = "            Imprimir";
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Iconimage")));
            this.btnImprimir.Iconimage_right = null;
            this.btnImprimir.Iconimage_right_Selected = null;
            this.btnImprimir.Iconimage_Selected = null;
            this.btnImprimir.IconMarginLeft = 0;
            this.btnImprimir.IconMarginRight = 0;
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconRightZoom = 0D;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.IconZoom = 90D;
            this.btnImprimir.IsTab = false;
            this.btnImprimir.Location = new System.Drawing.Point(79, 539);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImprimir.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimir.selected = false;
            this.btnImprimir.Size = new System.Drawing.Size(212, 45);
            this.btnImprimir.TabIndex = 42;
            this.btnImprimir.Text = "            Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Textcolor = System.Drawing.Color.White;
            this.btnImprimir.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAtras
            // 
            this.btnAtras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.BorderRadius = 0;
            this.btnAtras.ButtonText = "           Atras";
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.DisabledColor = System.Drawing.Color.Gray;
            this.btnAtras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAtras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAtras.Iconimage")));
            this.btnAtras.Iconimage_right = null;
            this.btnAtras.Iconimage_right_Selected = null;
            this.btnAtras.Iconimage_Selected = null;
            this.btnAtras.IconMarginLeft = 0;
            this.btnAtras.IconMarginRight = 0;
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconRightZoom = 0D;
            this.btnAtras.IconVisible = true;
            this.btnAtras.IconZoom = 90D;
            this.btnAtras.IsTab = false;
            this.btnAtras.Location = new System.Drawing.Point(482, 532);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAtras.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAtras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtras.selected = false;
            this.btnAtras.Size = new System.Drawing.Size(211, 52);
            this.btnAtras.TabIndex = 43;
            this.btnAtras.Text = "           Atras";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Textcolor = System.Drawing.Color.White;
            this.btnAtras.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // ConsultasBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 624);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvc);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultasBase";
            this.Text = "ConsultasBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultasBase_FormClosing);
            this.Controls.SetChildIndex(this.bunifuGradientPanel2, 0);
            this.Controls.SetChildIndex(this.bunifuGradientPanel1, 0);
            this.Controls.SetChildIndex(this.dgvc, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.BtnCerrar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuFlatButton btnImprimir;
        public System.Windows.Forms.DataGridView dgvc;
        public Bunifu.Framework.UI.BunifuFlatButton btnAtras;
    }
}