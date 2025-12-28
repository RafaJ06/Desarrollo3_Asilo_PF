namespace WinFormsApp1
{
    partial class LogIn
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
            tbUser = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(310, 181);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(310, 138);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(186, 31);
            tbUser.TabIndex = 1;
            tbUser.TextChanged += tbUser_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(310, 209);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(186, 31);
            tbPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(310, 110);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(333, 261);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(137, 34);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Iniciar Sesión";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogIn);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUser;
        private TextBox tbPassword;
        private Label label2;
        private Button btnLogIn;
    }
}
