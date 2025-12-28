namespace Interfaces
{
    partial class Main
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
            lblSaldoInicial = new Label();
            label2 = new Label();
            lblNombreCajero = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            clmServicio = new DataGridViewTextBoxColumn();
            clmPrecio = new DataGridViewTextBoxColumn();
            clmITBIS = new DataGridViewTextBoxColumn();
            clmComentario = new DataGridViewTextBoxColumn();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label24 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label25 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button7 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblSaldoInicial
            // 
            lblSaldoInicial.AutoSize = true;
            lblSaldoInicial.Location = new Point(85, 57);
            lblSaldoInicial.Name = "lblSaldoInicial";
            lblSaldoInicial.Size = new Size(51, 15);
            lblSaldoInicial.TabIndex = 0;
            lblSaldoInicial.Text = "SdIXXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 31);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            label2.Click += label2_Click;
            // 
            // lblNombreCajero
            // 
            lblNombreCajero.AutoSize = true;
            lblNombreCajero.Location = new Point(58, 31);
            lblNombreCajero.Name = "lblNombreCajero";
            lblNombreCajero.Size = new Size(88, 15);
            lblNombreCajero.TabIndex = 2;
            lblNombreCajero.Text = "Nombre Cajero";
            lblNombreCajero.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 31);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "No. Suc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 31);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Sucursal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 57);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 5;
            label6.Text = "Saldo Inicial:";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 31);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 7;
            label8.Text = "Cajero/a:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(68, 25);
            label9.TabIndex = 8;
            label9.Text = "H.A.L.E";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(132, 36);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Pago Servicio";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(133, 71);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(99, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Salida de Efectivo";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(11, 98);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(80, 15);
            linkLabel3.TabIndex = 11;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Cierre de Caja";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(11, 36);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(78, 15);
            linkLabel4.TabIndex = 12;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Inicio de Caja";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(11, 71);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(108, 15);
            linkLabel5.TabIndex = 13;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Entrada de Efectivo";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(linkLabel3);
            groupBox1.Controls.Add(linkLabel5);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel4);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(18, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 141);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(label29);
            groupBox2.Controls.Add(label28);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(438, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 291);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Transacción";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmServicio, clmPrecio, clmITBIS, clmComentario });
            dataGridView1.Location = new Point(11, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(332, 118);
            dataGridView1.TabIndex = 23;
            // 
            // clmServicio
            // 
            clmServicio.HeaderText = "Servicio";
            clmServicio.Name = "clmServicio";
            clmServicio.ReadOnly = true;
            // 
            // clmPrecio
            // 
            clmPrecio.HeaderText = "Precio";
            clmPrecio.Name = "clmPrecio";
            clmPrecio.ReadOnly = true;
            // 
            // clmITBIS
            // 
            clmITBIS.HeaderText = "ITBIS";
            clmITBIS.Name = "clmITBIS";
            clmITBIS.ReadOnly = true;
            // 
            // clmComentario
            // 
            clmComentario.HeaderText = "Comentario";
            clmComentario.Name = "clmComentario";
            clmComentario.ReadOnly = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(143, 211);
            label32.Name = "label32";
            label32.Size = new Size(34, 15);
            label32.TabIndex = 45;
            label32.Text = "0.00$";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(103, 249);
            label31.Name = "label31";
            label31.Size = new Size(34, 15);
            label31.TabIndex = 44;
            label31.Text = "0.00$";
            label31.Click += label31_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(11, 264);
            label30.Name = "label30";
            label30.Size = new Size(84, 15);
            label30.TabIndex = 43;
            label30.Text = "Total Servicios:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(11, 248);
            label29.Name = "label29";
            label29.Size = new Size(89, 15);
            label29.TabIndex = 42;
            label29.Text = "Monto Pagado:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(248, 264);
            label28.Name = "label28";
            label28.Size = new Size(49, 15);
            label28.TabIndex = 41;
            label28.Text = "Efectivo";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(11, 228);
            label27.Name = "label27";
            label27.Size = new Size(52, 15);
            label27.TabIndex = 40;
            label27.Text = "Importe:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(71, 211);
            label26.Name = "label26";
            label26.Size = new Size(34, 15);
            label26.TabIndex = 39;
            label26.Text = "0.00$";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(36, 57);
            label24.Name = "label24";
            label24.Size = new Size(103, 15);
            label24.TabIndex = 37;
            label24.Text = "NOMBRE CLIENTE";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 31);
            label19.Name = "label19";
            label19.Size = new Size(47, 15);
            label19.TabIndex = 32;
            label19.Text = "Cliente:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(143, 248);
            label18.Name = "label18";
            label18.Size = new Size(56, 15);
            label18.TabIndex = 31;
            label18.Text = "Devuelta:";
            label18.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(103, 264);
            label17.Name = "label17";
            label17.Size = new Size(34, 15);
            label17.TabIndex = 30;
            label17.Text = "0.00$";
            label17.Click += label17_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(71, 228);
            label16.Name = "label16";
            label16.Size = new Size(34, 15);
            label16.TabIndex = 29;
            label16.Text = "0.00$";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 213);
            label15.Name = "label15";
            label15.Size = new Size(35, 15);
            label15.TabIndex = 28;
            label15.Text = "Total:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(181, 31);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 27;
            label14.Text = "In.Fecha";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(134, 31);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 23;
            label10.Text = "Fecha:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(61, 31);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 24;
            label11.Text = "IN.CEDULA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(205, 248);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 25;
            label12.Text = "0.00$";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(143, 264);
            label13.Name = "label13";
            label13.Size = new Size(98, 15);
            label13.TabIndex = 26;
            label13.Text = "Método de pago:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lblSaldoInicial);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lblNombreCajero);
            groupBox3.Location = new Point(12, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(411, 134);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de Caja";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 83);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 17;
            label7.Text = "Total en Caja:";
            label7.Click += label7_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(338, 31);
            label25.Name = "label25";
            label25.Size = new Size(51, 15);
            label25.TabIndex = 38;
            label25.Text = "In.Fecha";
            // 
            // button1
            // 
            button1.Location = new Point(20, 345);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 17;
            button1.Text = "Nueva Transacción";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(438, 374);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 18;
            button2.Text = "Eliminar servicio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(578, 345);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 19;
            button3.Text = "Cancelar transacción";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(712, 345);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "Imprimir";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(438, 345);
            button5.Name = "button5";
            button5.Size = new Size(134, 23);
            button5.TabIndex = 21;
            button5.Text = "Procesar transacción";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(150, 345);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 22;
            button6.Text = "Ir a Inicio";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(578, 374);
            button7.Name = "button7";
            button7.Size = new Size(128, 23);
            button7.TabIndex = 23;
            button7.Text = "Editar servicio";
            button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 83);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 24;
            label1.Text = "totalCaja";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Inicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaldoInicial;
        private Label label2;
        private Label lblNombreCajero;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label13;
        private Button button6;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label24;
        private Label label19;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label32;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn clmServicio;
        private DataGridViewTextBoxColumn clmPrecio;
        private DataGridViewTextBoxColumn clmITBIS;
        private DataGridViewTextBoxColumn clmComentario;
        private Button button7;
        private Label label1;
    }
}