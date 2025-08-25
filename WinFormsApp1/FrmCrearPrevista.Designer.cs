namespace capa_Vista
{
    partial class FrmCrearPrevista
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearPrevista));
            label1 = new Label();
            dataGridPrevistas = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtAbonado = new TextBox();
            TxtCedula = new TextBox();
            TxtPrevista = new TextBox();
            TxtDireccion = new TextBox();
            comboEstado = new ComboBox();
            comboPueblo = new ComboBox();
            BtnAtras = new Button();
            BtnGuadar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPrevistas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(669, 23);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 4;
            label1.Text = "Crear Previstas";
            // 
            // dataGridPrevistas
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPrevistas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPrevistas.BackgroundColor = SystemColors.GradientActiveCaption;
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
            dataGridPrevistas.Location = new Point(367, 83);
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
            dataGridPrevistas.Size = new Size(881, 362);
            dataGridPrevistas.TabIndex = 5;
            dataGridPrevistas.CellContentClick += dataGridPrevistas_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 6;
            label2.Text = "Abonado : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            label3.Location = new Point(32, 147);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 7;
            label3.Text = "Cedula : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            label4.Location = new Point(17, 204);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 8;
            label4.Text = "Prevista :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            label5.Location = new Point(32, 257);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 9;
            label5.Text = "Pueblo :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            label6.Location = new Point(8, 319);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 10;
            label6.Text = "Direccion :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            label7.Location = new Point(32, 425);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 11;
            label7.Text = "Estado :";
            // 
            // TxtAbonado
            // 
            TxtAbonado.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtAbonado.Location = new Point(122, 83);
            TxtAbonado.Name = "TxtAbonado";
            TxtAbonado.Size = new Size(223, 28);
            TxtAbonado.TabIndex = 12;
            // 
            // TxtCedula
            // 
            TxtCedula.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCedula.Location = new Point(122, 140);
            TxtCedula.Name = "TxtCedula";
            TxtCedula.Size = new Size(223, 28);
            TxtCedula.TabIndex = 13;
            // 
            // TxtPrevista
            // 
            TxtPrevista.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPrevista.Location = new Point(122, 197);
            TxtPrevista.Name = "TxtPrevista";
            TxtPrevista.Size = new Size(223, 28);
            TxtPrevista.TabIndex = 14;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtDireccion.Location = new Point(122, 292);
            TxtDireccion.Multiline = true;
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(223, 91);
            TxtDireccion.TabIndex = 16;
            // 
            // comboEstado
            // 
            comboEstado.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstado.Location = new Point(122, 417);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(223, 28);
            comboEstado.TabIndex = 17;
            // 
            // comboPueblo
            // 
            comboPueblo.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboPueblo.FormattingEnabled = true;
            comboPueblo.Items.AddRange(new object[] { "Brisas", "Lirios", "Caribe", "Calle Hernadez", "Garba", "Frutera" });
            comboPueblo.Location = new Point(125, 249);
            comboPueblo.Name = "comboPueblo";
            comboPueblo.Size = new Size(223, 28);
            comboPueblo.TabIndex = 20;
            // 
            // BtnAtras
            // 
            BtnAtras.AutoSize = true;
            BtnAtras.Cursor = Cursors.Hand;
            BtnAtras.FlatAppearance.BorderSize = 0;
            BtnAtras.FlatStyle = FlatStyle.Flat;
            BtnAtras.Image = (Image)resources.GetObject("BtnAtras.Image");
            BtnAtras.Location = new Point(-3, 506);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(53, 46);
            BtnAtras.TabIndex = 21;
            BtnAtras.UseVisualStyleBackColor = true;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // BtnGuadar
            // 
            BtnGuadar.AutoSize = true;
            BtnGuadar.Cursor = Cursors.Hand;
            BtnGuadar.FlatAppearance.BorderSize = 0;
            BtnGuadar.FlatStyle = FlatStyle.Flat;
            BtnGuadar.Image = Properties.Resources.Insertar;
            BtnGuadar.Location = new Point(1195, 451);
            BtnGuadar.Name = "BtnGuadar";
            BtnGuadar.Size = new Size(53, 46);
            BtnGuadar.TabIndex = 22;
            BtnGuadar.UseVisualStyleBackColor = true;
            BtnGuadar.Click += BtnGuadar_Click;
            // 
            // FrmCrearPrevista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1361, 552);
            Controls.Add(BtnGuadar);
            Controls.Add(BtnAtras);
            Controls.Add(comboPueblo);
            Controls.Add(comboEstado);
            Controls.Add(TxtDireccion);
            Controls.Add(TxtPrevista);
            Controls.Add(TxtCedula);
            Controls.Add(TxtAbonado);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridPrevistas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearPrevista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Prevista";
            Load += FrmCrearPrevista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPrevistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridPrevistas;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtAbonado;
        private TextBox TxtCedula;
        private TextBox TxtPrevista;
        private TextBox textBox4;
        private TextBox TxtDireccion;
        private ComboBox comboEstado;
        private ComboBox comboPueblo;
        private Button BtnAtras;
        private Button BtnGuadar;
    }
}