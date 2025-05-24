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
            label1 = new Label();
            label2 = new Label();
            TxtNombre = new TextBox();
            TxtContra = new TextBox();
            BtnIngresar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 134);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 215);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña :";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(311, 131);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(246, 27);
            TxtNombre.TabIndex = 2;
            // 
            // TxtContra
            // 
            TxtContra.Location = new Point(311, 208);
            TxtContra.Name = "TxtContra";
            TxtContra.Size = new Size(246, 27);
            TxtContra.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.Location = new Point(390, 295);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(94, 29);
            BtnIngresar.TabIndex = 4;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Location = new Point(390, 249);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "¿Registrarse?";
            // 
            // Loging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtnIngresar);
            Controls.Add(TxtContra);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Loging";
            Text = "Loging";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtNombre;
        private TextBox TxtContra;
        private Button BtnIngresar;
        private Label label3;
    }
}
