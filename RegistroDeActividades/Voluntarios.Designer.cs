namespace RegistroDeActividades.UI
{
    partial class Voluntarios
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            voluntarios_correo = new TextBox();
            voluntarios_importar = new Button();
            voluntarios_limpiarbtn = new Button();
            voluntarios_eliminiarbtn = new Button();
            voluntarios_actualizarbtn = new Button();
            voluntarios_agregarbtn = new Button();
            voluntarios_genero = new ComboBox();
            voluntarios_imagen = new PictureBox();
            label5 = new Label();
            voluntarios_nombre = new TextBox();
            label4 = new Label();
            voluntarios_numero = new TextBox();
            label3 = new Label();
            voluntario_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)voluntarios_imagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 191);
            panel1.TabIndex = 0;
            panel1.Paint += Panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(942, 139);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "Voluntarios";
            label1.Click += Label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(voluntarios_correo);
            panel2.Controls.Add(voluntarios_importar);
            panel2.Controls.Add(voluntarios_limpiarbtn);
            panel2.Controls.Add(voluntarios_eliminiarbtn);
            panel2.Controls.Add(voluntarios_actualizarbtn);
            panel2.Controls.Add(voluntarios_agregarbtn);
            panel2.Controls.Add(voluntarios_genero);
            panel2.Controls.Add(voluntarios_imagen);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(voluntarios_nombre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(voluntarios_numero);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(voluntario_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 191);
            panel2.TabIndex = 1;
            panel2.Paint += Panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(292, 53);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 17;
            label6.Text = "Correo Electrónico:";
            // 
            // voluntarios_correo
            // 
            voluntarios_correo.Location = new Point(423, 55);
            voluntarios_correo.Name = "voluntarios_correo";
            voluntarios_correo.Size = new Size(122, 23);
            voluntarios_correo.TabIndex = 16;
            // 
            // voluntarios_importar
            // 
            voluntarios_importar.BackColor = Color.FromArgb(0, 54, 107);
            voluntarios_importar.Cursor = Cursors.Hand;
            voluntarios_importar.FlatAppearance.BorderSize = 0;
            voluntarios_importar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_importar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_importar.FlatStyle = FlatStyle.Flat;
            voluntarios_importar.ForeColor = SystemColors.ControlLightLight;
            voluntarios_importar.Location = new Point(843, 119);
            voluntarios_importar.Name = "voluntarios_importar";
            voluntarios_importar.Size = new Size(100, 23);
            voluntarios_importar.TabIndex = 15;
            voluntarios_importar.Text = "Añadir";
            voluntarios_importar.UseVisualStyleBackColor = false;
            voluntarios_importar.Click += voluntarios_importar_Click;
            // 
            // voluntarios_limpiarbtn
            // 
            voluntarios_limpiarbtn.BackColor = Color.FromArgb(0, 54, 107);
            voluntarios_limpiarbtn.Cursor = Cursors.Hand;
            voluntarios_limpiarbtn.FlatAppearance.BorderSize = 0;
            voluntarios_limpiarbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_limpiarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_limpiarbtn.FlatStyle = FlatStyle.Flat;
            voluntarios_limpiarbtn.ForeColor = SystemColors.ControlLightLight;
            voluntarios_limpiarbtn.Location = new Point(583, 142);
            voluntarios_limpiarbtn.Name = "voluntarios_limpiarbtn";
            voluntarios_limpiarbtn.Size = new Size(82, 35);
            voluntarios_limpiarbtn.TabIndex = 14;
            voluntarios_limpiarbtn.Text = "Limpiar";
            voluntarios_limpiarbtn.UseVisualStyleBackColor = false;
            // 
            // voluntarios_eliminiarbtn
            // 
            voluntarios_eliminiarbtn.BackColor = Color.FromArgb(0, 54, 107);
            voluntarios_eliminiarbtn.Cursor = Cursors.Hand;
            voluntarios_eliminiarbtn.FlatAppearance.BorderSize = 0;
            voluntarios_eliminiarbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_eliminiarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_eliminiarbtn.FlatStyle = FlatStyle.Flat;
            voluntarios_eliminiarbtn.ForeColor = SystemColors.ControlLightLight;
            voluntarios_eliminiarbtn.Location = new Point(485, 142);
            voluntarios_eliminiarbtn.Name = "voluntarios_eliminiarbtn";
            voluntarios_eliminiarbtn.Size = new Size(82, 35);
            voluntarios_eliminiarbtn.TabIndex = 13;
            voluntarios_eliminiarbtn.Text = "Eliminar";
            voluntarios_eliminiarbtn.UseVisualStyleBackColor = false;
            // 
            // voluntarios_actualizarbtn
            // 
            voluntarios_actualizarbtn.BackColor = Color.FromArgb(0, 54, 107);
            voluntarios_actualizarbtn.Cursor = Cursors.Hand;
            voluntarios_actualizarbtn.FlatAppearance.BorderSize = 0;
            voluntarios_actualizarbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_actualizarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_actualizarbtn.FlatStyle = FlatStyle.Flat;
            voluntarios_actualizarbtn.ForeColor = SystemColors.ControlLightLight;
            voluntarios_actualizarbtn.Location = new Point(387, 142);
            voluntarios_actualizarbtn.Name = "voluntarios_actualizarbtn";
            voluntarios_actualizarbtn.Size = new Size(82, 35);
            voluntarios_actualizarbtn.TabIndex = 12;
            voluntarios_actualizarbtn.Text = "Actualizar";
            voluntarios_actualizarbtn.UseVisualStyleBackColor = false;
            // 
            // voluntarios_agregarbtn
            // 
            voluntarios_agregarbtn.BackColor = Color.FromArgb(0, 54, 107);
            voluntarios_agregarbtn.Cursor = Cursors.Hand;
            voluntarios_agregarbtn.FlatAppearance.BorderSize = 0;
            voluntarios_agregarbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_agregarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 54, 107);
            voluntarios_agregarbtn.FlatStyle = FlatStyle.Flat;
            voluntarios_agregarbtn.ForeColor = SystemColors.ControlLightLight;
            voluntarios_agregarbtn.Location = new Point(288, 142);
            voluntarios_agregarbtn.Name = "voluntarios_agregarbtn";
            voluntarios_agregarbtn.Size = new Size(82, 35);
            voluntarios_agregarbtn.TabIndex = 11;
            voluntarios_agregarbtn.Text = "Añadir";
            voluntarios_agregarbtn.UseVisualStyleBackColor = false;
            voluntarios_agregarbtn.Click += voluntario_agregarBtn_Click;
            // 
            // voluntarios_genero
            // 
            voluntarios_genero.FormattingEnabled = true;
            voluntarios_genero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            voluntarios_genero.Location = new Point(143, 93);
            voluntarios_genero.Name = "voluntarios_genero";
            voluntarios_genero.Size = new Size(118, 23);
            voluntarios_genero.TabIndex = 10;
            // 
            // voluntarios_imagen
            // 
            voluntarios_imagen.BackColor = SystemColors.ControlDark;
            voluntarios_imagen.BorderStyle = BorderStyle.FixedSingle;
            voluntarios_imagen.Location = new Point(843, 22);
            voluntarios_imagen.Name = "voluntarios_imagen";
            voluntarios_imagen.Size = new Size(100, 100);
            voluntarios_imagen.TabIndex = 8;
            voluntarios_imagen.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 93);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 6;
            label5.Text = "Género:";
            label5.Click += Label5_Click;
            // 
            // voluntarios_nombre
            // 
            voluntarios_nombre.Location = new Point(143, 54);
            voluntarios_nombre.Name = "voluntarios_nombre";
            voluntarios_nombre.Size = new Size(118, 23);
            voluntarios_nombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(291, 21);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 4;
            label4.Text = "Número Telefónico:";
            // 
            // voluntarios_numero
            // 
            voluntarios_numero.Location = new Point(423, 20);
            voluntarios_numero.Name = "voluntarios_numero";
            voluntarios_numero.Size = new Size(122, 23);
            voluntarios_numero.TabIndex = 9;
            voluntarios_numero.TextChanged += Voluntarios_Numero_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 54);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo:";
            // 
            // voluntario_id
            // 
            voluntario_id.Location = new Point(143, 22);
            voluntario_id.Name = "voluntario_id";
            voluntario_id.Size = new Size(118, 23);
            voluntario_id.TabIndex = 1;
            voluntario_id.TextChanged += voluntario_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 22);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            label2.Click += Label2_Click;
            // 
            // Voluntarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Voluntarios";
            Size = new Size(1002, 425);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)voluntarios_imagen).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox voluntarios_nombre;
        private Label label4;
        private TextBox voluntarios_numero;
        private Label label3;
        private TextBox voluntario_id;
        private Label label2;
        private PictureBox voluntarios_imagen;
        private Button voluntarios_agregarbtn;
        private ComboBox voluntarios_genero;
        private Button voluntarios_importar;
        private Button voluntarios_limpiarbtn;
        private Button voluntarios_eliminiarbtn;
        private Button voluntarios_actualizarbtn;
        private Label label6;
        private TextBox voluntarios_correo;
    }
}
