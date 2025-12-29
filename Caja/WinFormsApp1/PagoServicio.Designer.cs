namespace Interfaces
{
    partial class PagoServicio
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.36234F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.63766F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.77778F));
            tableLayoutPanel1.Size = new Size(701, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(328, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 227);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Cliente";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(14, 174);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 0;
            button2.Text = "Añadir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(107, 174);
            button3.Name = "button3";
            button3.Size = new Size(80, 29);
            button3.TabIndex = 1;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 121);
            label10.Name = "label10";
            label10.Size = new Size(46, 19);
            label10.TabIndex = 27;
            label10.Text = "Edad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 94);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 26;
            label9.Text = "Cédula:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(146, 94);
            label8.Name = "label8";
            label8.Size = new Size(109, 19);
            label8.TabIndex = 25;
            label8.Text = "000-4329432-2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(146, 68);
            label7.Name = "label7";
            label7.Size = new Size(105, 19);
            label7.TabIndex = 24;
            label7.Text = "Nombre Cliente";
           // label7.Click += this.label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 68);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 23;
            label6.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(146, 127);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 22;
            label5.Text = "85 años";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(150, 38);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 21;
            label4.Text = "Normal";
            //label4.Click += this.label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 38);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 20;
            label3.Text = "Tipo de Cliente:";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 444);
            panel1.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.Location = new Point(9, 152);
            label13.Name = "label13";
            label13.Size = new Size(88, 19);
            label13.TabIndex = 25;
            label13.Text = "Comentario";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(73, 121);
            label12.Name = "label12";
            label12.Size = new Size(47, 19);
            label12.TabIndex = 24;
            label12.Text = "Activo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(9, 121);
            label11.Name = "label11";
            label11.Size = new Size(57, 19);
            label11.TabIndex = 23;
            label11.Text = "Estado:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(9, 174);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 77);
            textBox2.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(9, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
            label1.TabIndex = 8;
            label1.Text = "Tipo de Servicio: ";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(179, 84);
            button1.Name = "button1";
            button1.Size = new Size(92, 25);
            button1.TabIndex = 4;
            button1.Text = "Buscar Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(9, 64);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 3;
            label2.Text = "Cédula Cliente";
            // 
            // PagoServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PagoServicio";
            Text = "Form1";
            Load += PagoServicio_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBox2;
    }
}