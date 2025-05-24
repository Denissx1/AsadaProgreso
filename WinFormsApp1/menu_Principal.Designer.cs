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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            juntaToolStripMenuItem = new ToolStripMenuItem();
            previstasToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            saliToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha y Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(683, 126);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "tipo_Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 66);
            label3.Name = "label3";
            label3.Size = new Size(350, 20);
            label3.TabIndex = 2;
            label3.Text = "Bienvenido Asociasion Acueducto Rural El Progreso";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reportesToolStripMenuItem, juntaToolStripMenuItem, previstasToolStripMenuItem, mantenimientoToolStripMenuItem, saliToolStripMenuItem, salirToolStripMenuItem, salirToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.ForeColor = Color.Blue;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // juntaToolStripMenuItem
            // 
            juntaToolStripMenuItem.ForeColor = Color.Blue;
            juntaToolStripMenuItem.Name = "juntaToolStripMenuItem";
            juntaToolStripMenuItem.Size = new Size(57, 24);
            juntaToolStripMenuItem.Text = "Junta";
            // 
            // previstasToolStripMenuItem
            // 
            previstasToolStripMenuItem.ForeColor = Color.Blue;
            previstasToolStripMenuItem.Name = "previstasToolStripMenuItem";
            previstasToolStripMenuItem.Size = new Size(80, 24);
            previstasToolStripMenuItem.Text = "Previstas";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.ForeColor = Color.Blue;
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(124, 24);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // saliToolStripMenuItem
            // 
            saliToolStripMenuItem.ForeColor = Color.Blue;
            saliToolStripMenuItem.Name = "saliToolStripMenuItem";
            saliToolStripMenuItem.Size = new Size(59, 24);
            saliToolStripMenuItem.Text = "Roles";
            saliToolStripMenuItem.Click += saliToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.ForeColor = Color.Blue;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(79, 24);
            salirToolStripMenuItem.Text = "¿Ayuda?";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.ForeColor = Color.Blue;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(52, 24);
            salirToolStripMenuItem1.Text = "Salir";
            // 
            // menu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "menu_Principal";
            Text = "menu_Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem juntaToolStripMenuItem;
        private ToolStripMenuItem previstasToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem saliToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}