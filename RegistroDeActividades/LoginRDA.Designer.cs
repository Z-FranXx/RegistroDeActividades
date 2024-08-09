namespace RegistroDeActividades
{
    partial class Form1
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            login_singup = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            login_username = new TextBox();
            label3 = new Label();
            login_password = new TextBox();
            login_btn = new Button();
            login_showPasword = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 70, 143);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(login_singup);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 593);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = UI.Properties.Resources.LoginRegister;
            pictureBox1.Location = new Point(73, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 277);
            label5.Name = "label5";
            label5.Size = new Size(287, 22);
            label5.TabIndex = 2;
            label5.Text = "Registro De Actividades system 1.0";
            // 
            // login_singup
            // 
            login_singup.BackColor = Color.FromArgb(0, 54, 107);
            login_singup.FlatAppearance.BorderSize = 0;
            login_singup.FlatStyle = FlatStyle.Flat;
            login_singup.ForeColor = Color.White;
            login_singup.Location = new Point(29, 528);
            login_singup.Name = "login_singup";
            login_singup.Size = new Size(292, 43);
            login_singup.TabIndex = 1;
            login_singup.Text = "SING UP";
            login_singup.UseVisualStyleBackColor = false;
            login_singup.Click += login_singup_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(114, 485);
            label4.Name = "label4";
            label4.Size = new Size(127, 18);
            label4.TabIndex = 0;
            label4.Text = "Registra tu cuenta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 2;
            label1.Text = "Login Account";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(401, 191);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // login_username
            // 
            login_username.Location = new Point(401, 218);
            login_username.Margin = new Padding(4, 2, 4, 2);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(369, 39);
            login_username.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(401, 274);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // login_password
            // 
            login_password.Location = new Point(401, 301);
            login_password.Margin = new Padding(4, 2, 4, 2);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.Size = new Size(369, 39);
            login_password.TabIndex = 10;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(0, 54, 107);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.Transparent;
            login_btn.Location = new Point(401, 431);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(135, 48);
            login_btn.TabIndex = 11;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // login_showPasword
            // 
            login_showPasword.AutoSize = true;
            login_showPasword.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPasword.Location = new Point(640, 345);
            login_showPasword.Name = "login_showPasword";
            login_showPasword.Size = new Size(130, 22);
            login_showPasword.TabIndex = 12;
            login_showPasword.Text = "Show Password";
            login_showPasword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(808, 593);
            Controls.Add(login_showPasword);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(label3);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Cursor = Cursors.Hand;
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de actividades";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox login_username;
        private Label label3;
        private TextBox login_password;
        private Button login_btn;
        private CheckBox login_showPasword;
        private Label label4;
        private Button login_singup;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
