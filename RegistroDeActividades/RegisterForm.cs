using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace RegistroDeActividades.UI
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            if (signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    { 
                        connect.Open();
                        //Comprueba si el usuario ya existe
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        { 
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int) checkUser.ExecuteScalar();

                            if (count >= 1) 
                            {
                                MessageBox.Show(signup_username.Text + " is already taken",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                            }
                        }

                        DateTime Today = DateTime.Today;

                        string insertData = "INSERT INTO users " +
                            "(username, password, date_register) " +
                            "VALUES(@username, @password, @dateReg)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateReg", Today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registered successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 loginRDA = new Form1();
                            loginRDA.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}