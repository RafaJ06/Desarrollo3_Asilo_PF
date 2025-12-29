namespace Interfaces
{
    partial class InicioCaja
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
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 0;
            label1.Text = "Monto Inicial:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(34, 120);
            label2.Name = "label2";
            label2.Size = new Size(151, 19);
            label2.TabIndex = 1;
            label2.Text = "Responsable de Caja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(32, 151);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 2;
            label3.Text = "Monto Final Anterior:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(34, 69);
            label4.Name = "label4";
            label4.Size = new Size(161, 19);
            label4.TabIndex = 3;
            label4.Text = "Monto Inicial Anterior:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(201, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 25);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(34, 190);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 5;
            button1.Text = "Dar inicio a Caja";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(157, 190);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 6;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(201, 120);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 7;
            label5.Text = "XXXXXXXXXXXXXX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(34, 96);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 8;
            label6.Text = "Sucursal:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(201, 96);
            label7.Name = "label7";
            label7.Size = new Size(17, 19);
            label7.TabIndex = 9;
            label7.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(201, 151);
            label8.Name = "label8";
            label8.Size = new Size(76, 19);
            label8.TabIndex = 10;
            label8.Text = "00000.00$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(201, 69);
            label9.Name = "label9";
            label9.Size = new Size(76, 19);
            label9.TabIndex = 11;
            label9.Text = "00000.00$";
            label9.Click += label9_Click;
            // 
            // InicioCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InicioCaja";
            Text = "InicioCaja";
            Load += InicioCaja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}