using System.Data;
using System.Data.SqlClient;
using RegistroDeActividades.UI;

namespace RegistroDeActividades
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Server=DESKTOP-AA6ALA0\\SQLEXPRESS;Database=proyectofinal;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_singup_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_username.Text) || string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            string selectData = "SELECT * FROM users WHERE username = @username " +
                                "AND password = @password";

                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    MessageBox.Show("Ha iniciado sesion correctamente!", "Mensaje de informacion",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    MainForm mForm = new MainForm();
                                    mForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o Contrasena incorrecta", "Mensaje de Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }

        }

        private void login_showPasword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPasword.Checked ? '\0' : '*';
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
