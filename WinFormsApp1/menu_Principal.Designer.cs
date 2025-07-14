namespace capa_Vista
{
    partial class menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_Principal));
            label2 = new Label();
            label3 = new Label();
            PbLogo = new PictureBox();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1085, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "tipo_Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(349, 44);
            label3.Name = "label3";
            label3.Size = new Size(593, 25);
            label3.TabIndex = 2;
            label3.Text = "Bienvenido Asociasion Acueducto Rural El Progreso";
            // 
            // PbLogo
            // 
            PbLogo.Image = (Image)resources.GetObject("PbLogo.Image");
            PbLogo.Location = new Point(231, 86);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(748, 430);
            PbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PbLogo.TabIndex = 9;
            PbLogo.TabStop = false;
            // 
            // BtnSalir
            // 
            BtnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Image = Properties.Resources.Cerrar;
            BtnSalir.Location = new Point(1, 483);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(54, 33);
            BtnSalir.TabIndex = 10;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // menu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1206, 518);
            Controls.Add(BtnSalir);
            Controls.Add(PbLogo);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = SystemColors.GradientActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu_Principal";
            Load += menu_Principal_Load;
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private PictureBox PbLogo;
        private Button BtnSalir;
    }
}