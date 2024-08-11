namespace RegistroDeActividades.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            exit = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            logout_btn = new Button();
            dashboard_btn = new Button();
            eventos_btn = new Button();
            voluntarios_btn = new Button();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            eventos1 = new Eventos();
            voluntarios1 = new Voluntarios();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 54, 107);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 41);
            panel1.TabIndex = 0;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ControlLightLight;
            exit.Location = new Point(1167, 7);
            exit.Name = "exit";
            exit.Size = new Size(20, 21);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIG2_Logo_fotor_bg_remover_20240808221534;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 14);
            label1.Name = "label1";
            label1.Size = new Size(220, 14);
            label1.TabIndex = 0;
            label1.Text = "Registro De Actividade System 1.0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 54, 107);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(eventos_btn);
            panel2.Controls.Add(voluntarios_btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 41);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 425);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(39, 127);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 6;
            label3.Text = "¡Bienvenido/a!";
            label3.Click += label3_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.research;
            pictureBox2.Location = new Point(38, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(53, 388);
            label2.Name = "label2";
            label2.Size = new Size(86, 14);
            label2.TabIndex = 4;
            label2.Text = "Cerrar sesión";
            label2.Click += label2_Click;
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 54, 107);
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 54, 107);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            logout_btn.FlatStyle = FlatStyle.Popup;
            logout_btn.ForeColor = SystemColors.ButtonHighlight;
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.Location = new Point(12, 377);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(35, 35);
            logout_btn.TabIndex = 3;
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(0, 54, 107);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderColor = Color.White;
            dashboard_btn.FlatAppearance.CheckedBackColor = Color.White;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 70, 100);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Image = Properties.Resources.dashboard;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 179);
            dashboard_btn.Margin = new Padding(3, 2, 3, 2);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(175, 30);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // eventos_btn
            // 
            eventos_btn.BackColor = Color.FromArgb(0, 54, 107);
            eventos_btn.Cursor = Cursors.Hand;
            eventos_btn.FlatAppearance.BorderColor = Color.White;
            eventos_btn.FlatAppearance.CheckedBackColor = Color.White;
            eventos_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 70, 100);
            eventos_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            eventos_btn.FlatStyle = FlatStyle.Flat;
            eventos_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventos_btn.ForeColor = Color.White;
            eventos_btn.Image = (Image)resources.GetObject("eventos_btn.Image");
            eventos_btn.ImageAlign = ContentAlignment.MiddleLeft;
            eventos_btn.Location = new Point(12, 226);
            eventos_btn.Margin = new Padding(3, 2, 3, 2);
            eventos_btn.Name = "eventos_btn";
            eventos_btn.Size = new Size(175, 30);
            eventos_btn.TabIndex = 1;
            eventos_btn.Text = "EVENTOS";
            eventos_btn.UseVisualStyleBackColor = false;
            eventos_btn.Click += eventos_btn_Click;
            // 
            // voluntarios_btn
            // 
            voluntarios_btn.BackColor = Color.FromArgb(0, 54, 107);
            voluntarios_btn.Cursor = Cursors.Hand;
            voluntarios_btn.FlatAppearance.BorderColor = Color.White;
            voluntarios_btn.FlatAppearance.CheckedBackColor = Color.White;
            voluntarios_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 70, 100);
            voluntarios_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_btn.FlatStyle = FlatStyle.Flat;
            voluntarios_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            voluntarios_btn.ForeColor = Color.White;
            voluntarios_btn.Image = (Image)resources.GetObject("voluntarios_btn.Image");
            voluntarios_btn.ImageAlign = ContentAlignment.MiddleLeft;
            voluntarios_btn.Location = new Point(12, 272);
            voluntarios_btn.Margin = new Padding(3, 2, 3, 2);
            voluntarios_btn.Name = "voluntarios_btn";
            voluntarios_btn.Size = new Size(175, 30);
            voluntarios_btn.TabIndex = 0;
            voluntarios_btn.Text = "VOLUNTARIOS";
            voluntarios_btn.UseVisualStyleBackColor = false;
            voluntarios_btn.Click += voluntarios_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(eventos1);
            panel3.Controls.Add(voluntarios1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(197, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(1002, 425);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1002, 425);
            dashboard1.TabIndex = 2;
            dashboard1.Load += dashboard1_Load_1;
            // 
            // eventos1
            // 
            eventos1.Location = new Point(0, 0);
            eventos1.Name = "eventos1";
            eventos1.Size = new Size(1002, 425);
            eventos1.TabIndex = 1;
            // 
            // voluntarios1
            // 
            voluntarios1.Location = new Point(0, 0);
            voluntarios1.Name = "voluntarios1";
            voluntarios1.Size = new Size(1002, 425);
            voluntarios1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1199, 466);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label2;
        private Label exit;
        private Panel panel3;
        private Button dashboard_btn;
        private Button eventos_btn;
        private Button voluntarios_btn;
        private Dashboard dashboard1;
        private Eventos eventos1;
        private Voluntarios voluntarios1;
        private Button logout_btn;
        private Label label3;
        private PictureBox pictureBox2;
    }
}