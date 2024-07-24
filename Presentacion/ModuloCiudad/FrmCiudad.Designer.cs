namespace Presentacion.ModuloCiudad
{
    partial class FrmCiudad
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
            this.pnlRciudad = new ReaLTaiizor.Controls.Panel();
            this.cmbProvincias = new Presentacion.btnpersonalizados.PersonComboBox();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtCiudad = new ReaLTaiizor.Controls.TextBoxEdit();
            this.btnGuardarciudad = new Presentacion.btnpersonalizados.Botonper();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.pnlRciudad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRciudad
            // 
            this.pnlRciudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRciudad.Controls.Add(this.cmbProvincias);
            this.pnlRciudad.Controls.Add(this.labelEdit3);
            this.pnlRciudad.Controls.Add(this.txtCiudad);
            this.pnlRciudad.Controls.Add(this.btnGuardarciudad);
            this.pnlRciudad.Controls.Add(this.labelEdit1);
            this.pnlRciudad.Controls.Add(this.labelEdit2);
            this.pnlRciudad.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlRciudad.Location = new System.Drawing.Point(25, 41);
            this.pnlRciudad.Name = "pnlRciudad";
            this.pnlRciudad.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRciudad.Size = new System.Drawing.Size(420, 315);
            this.pnlRciudad.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlRciudad.TabIndex = 93;
            this.pnlRciudad.Visible = false;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvincias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.cmbProvincias.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbProvincias.BorderRadius = 0;
            this.cmbProvincias.BorderSize = 0;
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbProvincias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cmbProvincias.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbProvincias.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.cmbProvincias.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbProvincias.Location = new System.Drawing.Point(116, 158);
            this.cmbProvincias.MinimumSize = new System.Drawing.Size(200, 42);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(256, 42);
            this.cmbProvincias.TabIndex = 96;
            this.cmbProvincias.Texts = "";
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(140, 30);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(208, 24);
            this.labelEdit3.TabIndex = 91;
            this.labelEdit3.Text = "Registrar nueva ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.Transparent;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCiudad.ForeColor = System.Drawing.Color.White;
            this.txtCiudad.Image = null;
            this.txtCiudad.Location = new System.Drawing.Point(116, 99);
            this.txtCiudad.MaxLength = 32767;
            this.txtCiudad.Multiline = false;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = false;
            this.txtCiudad.Size = new System.Drawing.Size(256, 42);
            this.txtCiudad.TabIndex = 90;
            this.txtCiudad.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCiudad.UseSystemPasswordChar = false;
            // 
            // btnGuardarciudad
            // 
            this.btnGuardarciudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardarciudad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardarciudad.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarciudad.BorderRadius = 20;
            this.btnGuardarciudad.BorderSize = 0;
            this.btnGuardarciudad.FlatAppearance.BorderSize = 0;
            this.btnGuardarciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarciudad.ForeColor = System.Drawing.Color.White;
            this.btnGuardarciudad.Location = new System.Drawing.Point(160, 237);
            this.btnGuardarciudad.Name = "btnGuardarciudad";
            this.btnGuardarciudad.Size = new System.Drawing.Size(138, 44);
            this.btnGuardarciudad.TabIndex = 25;
            this.btnGuardarciudad.Text = "Guardar";
            this.btnGuardarciudad.TextColor = System.Drawing.Color.White;
            this.btnGuardarciudad.UseVisualStyleBackColor = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(20, 109);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(63, 20);
            this.labelEdit1.TabIndex = 59;
            this.labelEdit1.Text = "Ciudad:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(20, 169);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(76, 20);
            this.labelEdit2.TabIndex = 56;
            this.labelEdit2.Text = "Provincia:";
            // 
            // FrmCiudad
            // 
            this.ClientSize = new System.Drawing.Size(737, 411);
            this.Controls.Add(this.pnlRciudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCiudad";
            this.pnlRciudad.ResumeLayout(false);
            this.pnlRciudad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private btnpersonalizados.Botonper btnGuardarc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.Panel pnlRciudad;
        private ReaLTaiizor.Controls.TextBoxEdit txtCiudad;
        private btnpersonalizados.Botonper btnGuardarciudad;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private btnpersonalizados.PersonComboBox cmbProvincias;
    }
}