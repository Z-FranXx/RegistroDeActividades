using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistroDeActividades.UI
{
    public partial class RegisterForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-AA6ALA0\\SQLEXPRESS;Database=proyectofinal;Trusted_Connection=True;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Código para el evento Paint del panel si es necesario
        }

        private void signup_singup_Click(object sender, EventArgs e)
        {
            Form1 LoginRDA = new Form1();
            LoginRDA.Show();
            this.Hide();
        }

        private void login_showPasword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPasword.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signup_username.Text) || string.IsNullOrWhiteSpace(signup_password.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos en blanco", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Verifica si el usuario ya existe
                    string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";
                    using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                        int count = (int)checkUser.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show(signup_username.Text + " ya está en uso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Inserta el nuevo usuario
                    DateTime Today = DateTime.Today;
                    string insertData = "INSERT INTO users (username, password, date_register) VALUES (@username, @password, @dateReg)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim()); // Considera usar una función de hash para la contraseña
                        cmd.Parameters.AddWithValue("@dateReg", Today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Registrado exitosamente!", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 loginRDA = new Form1();
                        loginRDA.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Código para el evento Load del formulario si es necesario
        }

        private void login_showPasword_CheckedChanged_1(object sender, EventArgs e)
        {
            // Código para el evento CheckedChanged del checkbox si es necesario
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Código para el evento Click del label si es necesario
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}