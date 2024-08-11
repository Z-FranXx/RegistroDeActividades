using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeActividades.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Estas seguro de que quieres salir?"
                , "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();

            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            eventos1.Visible = false;
            voluntarios1.Visible = false;
        }

        private void eventos_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            eventos1.Visible = true;
            voluntarios1.Visible = false;
        }

        private void voluntarios_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            eventos1.Visible = false;
            voluntarios1.Visible = true;
        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
