using Google.Protobuf.WellKnownTypes;

namespace Presentacion.ModuloLogin
{
    partial class FrmRecuperarContrasena
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
            this.btnGuardarPass = new Presentacion.btnpersonalizados.Botonper();
            this.btnCancelarpass = new Presentacion.btnpersonalizados.Botonper();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chnpass = new System.Windows.Forms.CheckBox();
            this.chcpass = new System.Windows.Forms.CheckBox();
            this.txtCiudad = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.textBoxEdit1 = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.SuspendLayout();
            // 
            // btnGuardarPass
            // 
            this.btnGuardarPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardarPass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardarPass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarPass.BorderRadius = 20;
            this.btnGuardarPass.BorderSize = 0;
            this.btnGuardarPass.FlatAppearance.BorderSize = 0;
            this.btnGuardarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPass.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPass.Location = new System.Drawing.Point(66, 261);
            this.btnGuardarPass.Name = "btnGuardarPass";
            this.btnGuardarPass.Size = new System.Drawing.Size(138, 36);
            this.btnGuardarPass.TabIndex = 28;
            this.btnGuardarPass.Text = "Actualizar";
            this.btnGuardarPass.TextColor = System.Drawing.Color.White;
            this.btnGuardarPass.UseVisualStyleBackColor = false;
            this.btnGuardarPass.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarpass
            // 
            this.btnCancelarpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnCancelarpass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnCancelarpass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelarpass.BorderRadius = 20;
            this.btnCancelarpass.BorderSize = 0;
            this.btnCancelarpass.FlatAppearance.BorderSize = 0;
            this.btnCancelarpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarpass.ForeColor = System.Drawing.Color.White;
            this.btnCancelarpass.Location = new System.Drawing.Point(290, 261);
            this.btnCancelarpass.Name = "btnCancelarpass";
            this.btnCancelarpass.Size = new System.Drawing.Size(121, 36);
            this.btnCancelarpass.TabIndex = 27;
            this.btnCancelarpass.Text = "Cancelar";
            this.btnCancelarpass.TextColor = System.Drawing.Color.White;
            this.btnCancelarpass.UseVisualStyleBackColor = false;
            this.btnCancelarpass.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 49);
            this.panel1.TabIndex = 35;
            // 
            // chnpass
            // 
            this.chnpass.AutoSize = true;
            this.chnpass.ForeColor = System.Drawing.Color.White;
            this.chnpass.Location = new System.Drawing.Point(178, 137);
            this.chnpass.Name = "chnpass";
            this.chnpass.Size = new System.Drawing.Size(61, 17);
            this.chnpass.TabIndex = 36;
            this.chnpass.Text = "Mostrar";
            this.chnpass.UseVisualStyleBackColor = true;
            this.chnpass.CheckedChanged += new System.EventHandler(this.chnpass_CheckedChanged);
            // 
            // chcpass
            // 
            this.chcpass.AutoSize = true;
            this.chcpass.ForeColor = System.Drawing.Color.White;
            this.chcpass.Location = new System.Drawing.Point(178, 217);
            this.chcpass.Name = "chcpass";
            this.chcpass.Size = new System.Drawing.Size(61, 17);
            this.chcpass.TabIndex = 37;
            this.chcpass.Text = "Mostrar";
            this.chcpass.UseVisualStyleBackColor = true;
            this.chcpass.CheckedChanged += new System.EventHandler(this.chcpass_CheckedChanged);
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.Transparent;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCiudad.ForeColor = System.Drawing.Color.White;
            this.txtCiudad.Image = null;
            this.txtCiudad.Location = new System.Drawing.Point(174, 90);
            this.txtCiudad.MaxLength = 32767;
            this.txtCiudad.Multiline = false;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = false;
            this.txtCiudad.Size = new System.Drawing.Size(256, 42);
            this.txtCiudad.TabIndex = 92;
            this.txtCiudad.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCiudad.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(30, 100);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(142, 20);
            this.labelEdit1.TabIndex = 91;
            this.labelEdit1.Text = "Nueva contraseña:";
            // 
            // textBoxEdit1
            // 
            this.textBoxEdit1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEdit1.ForeColor = System.Drawing.Color.White;
            this.textBoxEdit1.Image = null;
            this.textBoxEdit1.Location = new System.Drawing.Point(178, 169);
            this.textBoxEdit1.MaxLength = 32767;
            this.textBoxEdit1.Multiline = false;
            this.textBoxEdit1.Name = "textBoxEdit1";
            this.textBoxEdit1.ReadOnly = false;
            this.textBoxEdit1.Size = new System.Drawing.Size(256, 42);
            this.textBoxEdit1.TabIndex = 94;
            this.textBoxEdit1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEdit1.UseSystemPasswordChar = false;
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(30, 180);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(142, 20);
            this.labelEdit2.TabIndex = 93;
            this.labelEdit2.Text = "Nueva contraseña:";
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(152, 35);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(202, 24);
            this.labelEdit3.TabIndex = 95;
            this.labelEdit3.Text = "Recuperar contraseña:";
            // 
            // FrmRecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(509, 329);
            this.ControlBox = false;
            this.Controls.Add(this.labelEdit3);
            this.Controls.Add(this.textBoxEdit1);
            this.Controls.Add(this.labelEdit2);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.labelEdit1);
            this.Controls.Add(this.chcpass);
            this.Controls.Add(this.chnpass);
            this.Controls.Add(this.btnGuardarPass);
            this.Controls.Add(this.btnCancelarpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecuperarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRecuperarContrasena";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnpersonalizados.Botonper btnCancelarpass;
        private btnpersonalizados.Botonper btnGuardarPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chnpass;
        private System.Windows.Forms.CheckBox chcpass;
        private ReaLTaiizor.Controls.TextBoxEdit txtCiudad;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.TextBoxEdit textBoxEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
    }
}