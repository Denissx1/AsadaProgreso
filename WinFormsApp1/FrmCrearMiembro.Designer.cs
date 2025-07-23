namespace capa_Vista
{
    partial class FrmCrearMiembro
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
            button1 = new Button();
            DataGridMienbroJunta = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            dateTimeIngreso = new DateTimePicker();
            dateTimeSalida = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridMienbroJunta).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1, 476);
            button1.Name = "button1";
            button1.Size = new Size(97, 38);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DataGridMienbroJunta
            // 
            DataGridMienbroJunta.BackgroundColor = Color.Gainsboro;
            DataGridMienbroJunta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridMienbroJunta.Location = new Point(364, 75);
            DataGridMienbroJunta.Name = "DataGridMienbroJunta";
            DataGridMienbroJunta.RowHeadersWidth = 51;
            DataGridMienbroJunta.Size = new Size(930, 326);
            DataGridMienbroJunta.TabIndex = 2;
            DataGridMienbroJunta.CellContentClick += DataGridMienbroJunta_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(639, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 28);
            label1.TabIndex = 3;
            label1.Text = "Crear Miembro de Junta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(-3, 79);
            label2.Name = "label2";
            label2.Size = new Size(149, 18);
            label2.TabIndex = 4;
            label2.Text = "Nombre Mienbro:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(77, 126);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 5;
            label3.Text = "Cedula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(75, 174);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 6;
            label4.Text = "Puesto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 27);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(75, 224);
            label5.Name = "label5";
            label5.Size = new Size(70, 18);
            label5.TabIndex = 11;
            label5.Text = "Estado:";
            // 
            // dateTimeIngreso
            // 
            dateTimeIngreso.Location = new Point(152, 269);
            dateTimeIngreso.Name = "dateTimeIngreso";
            dateTimeIngreso.Size = new Size(206, 27);
            dateTimeIngreso.TabIndex = 12;
            // 
            // dateTimeSalida
            // 
            dateTimeSalida.Location = new Point(152, 320);
            dateTimeSalida.Name = "dateTimeSalida";
            dateTimeSalida.Size = new Size(206, 27);
            dateTimeSalida.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(-3, 275);
            label6.Name = "label6";
            label6.Size = new Size(156, 18);
            label6.TabIndex = 14;
            label6.Text = "Fecha de Ingreso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.Location = new Point(7, 329);
            label7.Name = "label7";
            label7.Size = new Size(141, 18);
            label7.TabIndex = 15;
            label7.Text = "Fecha de Salida:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 374);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 27);
            textBox5.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label8.Location = new Point(66, 378);
            label8.Name = "label8";
            label8.Size = new Size(87, 18);
            label8.TabIndex = 17;
            label8.Text = "Prevista: ";
            // 
            // button2
            // 
            button2.Location = new Point(1151, 407);
            button2.Name = "button2";
            button2.Size = new Size(143, 38);
            button2.TabIndex = 18;
            button2.Text = "Generar Reporte";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmCrearMiembro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1351, 514);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimeSalida);
            Controls.Add(dateTimeIngreso);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DataGridMienbroJunta);
            Controls.Add(button1);
            Name = "FrmCrearMiembro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Miembro";
            Load += FrmCrearMiembro_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridMienbroJunta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView DataGridMienbroJunta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private DateTimePicker dateTimeIngreso;
        private DateTimePicker dateTimeSalida;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Button button2;
    }
}