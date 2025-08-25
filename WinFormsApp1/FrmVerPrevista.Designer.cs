

namespace capa_Vista
{
    partial class FrmVerPrevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerPrevista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            txtBuscar = new TextBox();
            BtnAtras = new Button();
            BtnBuscar = new Button();
            dataGridPrevistas = new DataGridView();
            BtnRefrescar = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPrevistas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(581, 27);
            label1.Name = "label1";
            label1.Size = new Size(226, 22);
            label1.TabIndex = 0;
            label1.Text = "Previstas Ingresadas";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(511, 76);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(329, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // BtnAtras
            // 
            BtnAtras.AutoSize = true;
            BtnAtras.Cursor = Cursors.Hand;
            BtnAtras.FlatAppearance.BorderSize = 0;
            BtnAtras.FlatStyle = FlatStyle.Flat;
            BtnAtras.Image = (Image)resources.GetObject("BtnAtras.Image");
            BtnAtras.Location = new Point(-1, 498);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(53, 46);
            BtnAtras.TabIndex = 22;
            BtnAtras.UseVisualStyleBackColor = true;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.AutoSize = true;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Image = (Image)resources.GetObject("BtnBuscar.Image");
            BtnBuscar.Location = new Point(817, 62);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(70, 54);
            BtnBuscar.TabIndex = 23;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // dataGridPrevistas
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPrevistas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPrevistas.BackgroundColor = SystemColors.ControlLight;
            dataGridPrevistas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPrevistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPrevistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridPrevistas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridPrevistas.GridColor = Color.LightSkyBlue;
            dataGridPrevistas.Location = new Point(201, 122);
            dataGridPrevistas.Name = "dataGridPrevistas";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridPrevistas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridPrevistas.RowHeadersWidth = 51;
            dataGridPrevistas.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridPrevistas.Size = new Size(913, 362);
            dataGridPrevistas.TabIndex = 24;
            // 
            // BtnRefrescar
            // 
            BtnRefrescar.AutoSize = true;
            BtnRefrescar.Cursor = Cursors.Hand;
            BtnRefrescar.FlatAppearance.BorderSize = 0;
            BtnRefrescar.FlatStyle = FlatStyle.Flat;
            BtnRefrescar.Image = (Image)resources.GetObject("BtnRefrescar.Image");
            BtnRefrescar.Location = new Point(940, 71);
            BtnRefrescar.Name = "BtnRefrescar";
            BtnRefrescar.Size = new Size(70, 36);
            BtnRefrescar.TabIndex = 25;
            BtnRefrescar.UseVisualStyleBackColor = true;
            BtnRefrescar.Click += BtnRefrescar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(872, 81);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 26;
            label2.Text = "Buscar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(997, 81);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 27;
            label3.Text = "Refrescar";
            // 
            // FrmVerPrevista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1270, 542);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnRefrescar);
            Controls.Add(dataGridPrevistas);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnAtras);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVerPrevista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVerPrevista";
            Load += FrmVerPrevista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPrevistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private DataGridView dataGridVerPrevista;
        private Button BtnAtras;
        private Button BtnBuscar;
        private DataGridView dataGridPrevistas;
        private Button BtnRefrescar;
        private Label label2;
        private Label label3;
    }
}