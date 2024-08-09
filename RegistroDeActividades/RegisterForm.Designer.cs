namespace RegistroDeActividades.UI
{
    partial class RegisterForm
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
            signup_btn = new Button();
            signup_password = new TextBox();
            label3 = new Label();
            signup_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            signup_singup = new Button();
            label4 = new Label();
            signup_showPasword = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(0, 54, 107);
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.Transparent;
            signup_btn.Location = new Point(400, 430);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(135, 48);
            signup_btn.TabIndex = 18;
            signup_btn.Text = "SINGUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(400, 300);
            signup_password.Margin = new Padding(4, 2, 4, 2);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(369, 39);
            signup_password.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(400, 273);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 16;
            label3.Text = "Password:";
            // 
            // signup_username
            // 
            signup_username.Location = new Point(400, 217);
            signup_username.Margin = new Padding(4, 2, 4, 2);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(369, 39);
            signup_username.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 14;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 13;
            label1.Text = "Register Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 70, 143);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(signup_singup);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 593);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LoginRegister;
            pictureBox1.Location = new Point(73, 49);
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
            label5.Location = new Point(26, 289);
            label5.Name = "label5";
            label5.Size = new Size(287, 22);
            label5.TabIndex = 2;
            label5.Text = "Registro De Actividades system 1.0";
            // 
            // signup_singup
            // 
            signup_singup.BackColor = Color.FromArgb(0, 54, 107);
            signup_singup.FlatAppearance.BorderSize = 0;
            signup_singup.FlatStyle = FlatStyle.Flat;
            signup_singup.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_singup.ForeColor = Color.White;
            signup_singup.Location = new Point(26, 523);
            signup_singup.Name = "signup_singup";
            signup_singup.Size = new Size(292, 43);
            signup_singup.TabIndex = 1;
            signup_singup.Text = "SIGN IN";
            signup_singup.UseVisualStyleBackColor = false;
            signup_singup.Click += signup_singup_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(116, 489);
            label4.Name = "label4";
            label4.Size = new Size(108, 18);
            label4.TabIndex = 0;
            label4.Text = "Inicia tu cuenta";
            // 
            // signup_showPasword
            // 
            signup_showPasword.AutoSize = true;
            signup_showPasword.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showPasword.Location = new Point(639, 344);
            signup_showPasword.Name = "signup_showPasword";
            signup_showPasword.Size = new Size(130, 22);
            signup_showPasword.TabIndex = 19;
            signup_showPasword.Text = "Show Password";
            signup_showPasword.UseVisualStyleBackColor = true;
            signup_showPasword.CheckedChanged += login_showPasword_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(808, 593);
            Controls.Add(signup_showPasword);
            Controls.Add(signup_btn);
            Controls.Add(signup_password);
            Controls.Add(label3);
            Controls.Add(signup_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_btn;
        private TextBox signup_password;
        private Label label3;
        private TextBox signup_username;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Button signup_singup;
        private Label label4;
        private CheckBox signup_showPasword;
    }
}