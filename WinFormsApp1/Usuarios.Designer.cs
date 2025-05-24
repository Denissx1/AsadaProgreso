namespace Vista
{
    partial class Usuarios
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
            gridUser = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtCorreo = new TextBox();
            txtcontra = new TextBox();
            txtTipo_Usuario = new TextBox();
            lblNombre = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnGuardar = new Button();
            BtnEditr = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridUser).BeginInit();
            SuspendLayout();
            // 
            // gridUser
            // 
            gridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUser.Location = new Point(310, 76);
            gridUser.Name = "gridUser";
            gridUser.RowHeadersWidth = 51;
            gridUser.Size = new Size(678, 269);
            gridUser.TabIndex = 0;
            gridUser.CellClick += gridUser_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(630, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(126, 132);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(163, 27);
            txtCedula.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(126, 197);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(163, 27);
            txtCorreo.TabIndex = 4;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(126, 263);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(163, 27);
            txtcontra.TabIndex = 5;
            // 
            // txtTipo_Usuario
            // 
            txtTipo_Usuario.Location = new Point(126, 318);
            txtTipo_Usuario.Name = "txtTipo_Usuario";
            txtTipo_Usuario.Size = new Size(163, 27);
            txtTipo_Usuario.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 139);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Cedula :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 204);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Correo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 266);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 10;
            label5.Text = "Contrasena :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 325);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 11;
            label6.Text = "Tipo Usuario :";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(310, 364);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 12;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnEditr
            // 
            BtnEditr.Location = new Point(616, 364);
            BtnEditr.Name = "BtnEditr";
            BtnEditr.Size = new Size(94, 29);
            BtnEditr.TabIndex = 13;
            BtnEditr.Text = "Editar";
            BtnEditr.UseVisualStyleBackColor = true;
            BtnEditr.Click += button1_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(894, 364);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 14;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += button2_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 514);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditr);
            Controls.Add(BtnGuardar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNombre);
            Controls.Add(txtTipo_Usuario);
            Controls.Add(txtcontra);
            Controls.Add(txtCorreo);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(gridUser);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)gridUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridUser;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtCorreo;
        private TextBox txtcontra;
        private TextBox txtTipo_Usuario;
        private Label lblNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnGuardar;
        private Button BtnEditr;
        private Button BtnEliminar;
    }
}