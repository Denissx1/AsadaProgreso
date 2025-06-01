namespace WinFormsApp1
{
    partial class Loging
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loging));
            lblUsuario = new Label();
            lblContra = new Label();
            TxtNombre = new TextBox();
            TxtContra = new TextBox();
            BtnIngresar = new Button();
            LblRegistrarse = new Label();
            BtnSalir = new Button();
            lblhora = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            PbLogo = new PictureBox();
            PbPassword = new PictureBox();
            HorayFecha = new System.Windows.Forms.Timer(components);
            lblFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPassword).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsuario.Location = new Point(305, 217);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(91, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario :";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblContra.Location = new Point(273, 286);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(123, 25);
            lblContra.TabIndex = 1;
            lblContra.Text = "Contraseña :";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxtNombre.Location = new Point(402, 215);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(246, 27);
            TxtNombre.TabIndex = 2;
            // 
            // TxtContra
            // 
            TxtContra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TxtContra.Location = new Point(402, 284);
            TxtContra.Name = "TxtContra";
            TxtContra.PasswordChar = '*';
            TxtContra.Size = new Size(246, 27);
            TxtContra.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            BtnIngresar.AutoSize = true;
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Image = (Image)resources.GetObject("BtnIngresar.Image");
            BtnIngresar.Location = new Point(475, 362);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(94, 72);
            BtnIngresar.TabIndex = 4;
            BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // LblRegistrarse
            // 
            LblRegistrarse.AutoSize = true;
            LblRegistrarse.Cursor = Cursors.Hand;
            LblRegistrarse.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblRegistrarse.Location = new Point(339, 334);
            LblRegistrarse.Name = "LblRegistrarse";
            LblRegistrarse.Size = new Size(389, 25);
            LblRegistrarse.TabIndex = 5;
            LblRegistrarse.Text = "¿Desea Registrarse o olvido su contraseña?";
            // 
            // BtnSalir
            // 
            BtnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Image = capa_Vista.Properties.Resources.Cerrar;
            BtnSalir.Location = new Point(1, 453);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(54, 33);
            BtnSalir.TabIndex = 6;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BrnSalir_Click;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblhora.Location = new Point(792, 9);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(57, 25);
            lblhora.TabIndex = 7;
            lblhora.Text = "Hora";
            lblhora.Click += lblhora_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // PbLogo
            // 
            PbLogo.Image = capa_Vista.Properties.Resources.Logo;
            PbLogo.Location = new Point(437, 9);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(183, 191);
            PbLogo.TabIndex = 8;
            PbLogo.TabStop = false;
            // 
            // PbPassword
            // 
            PbPassword.Cursor = Cursors.Hand;
            PbPassword.Image = capa_Vista.Properties.Resources.Ojo;
            PbPassword.Location = new Point(654, 286);
            PbPassword.Name = "PbPassword";
            PbPassword.Size = new Size(33, 25);
            PbPassword.TabIndex = 9;
            PbPassword.TabStop = false;
            PbPassword.Click += PbPassword_Click;
            // 
            // HorayFecha
            // 
            HorayFecha.Enabled = true;
            HorayFecha.Tick += HorayFecha_Tick;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFecha.Location = new Point(749, 49);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 25);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "Fecha";
            // 
            // Loging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(956, 489);
            Controls.Add(lblFecha);
            Controls.Add(PbPassword);
            Controls.Add(PbLogo);
            Controls.Add(lblhora);
            Controls.Add(BtnSalir);
            Controls.Add(LblRegistrarse);
            Controls.Add(BtnIngresar);
            Controls.Add(TxtContra);
            Controls.Add(TxtNombre);
            Controls.Add(lblContra);
            Controls.Add(lblUsuario);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loging";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loging";
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContra;
        private TextBox TxtNombre;
        private TextBox TxtContra;
        private Button BtnIngresar;
        private Label LblRegistrarse;
        private Button BtnSalir;
        private Label lblhora;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox PbLogo;
        private PictureBox PbPassword;
        private System.Windows.Forms.Timer HorayFecha;
        private Label lblFecha;
    }
}
