using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RegistroDeActividades.Data;
using System.IO;

namespace RegistroDeActividades.UI
{
    public partial class Voluntarios : UserControl
    {
        private readonly string connectionString = "Server=DESKTOP-AA6ALA0\\SQLEXPRESS;Database=proyectofinal;Trusted_Connection=True;";

        public Voluntarios()
        {
            InitializeComponent();
            DisplayVoluntariosData();
        }

        private void voluntario_agregarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(voluntarios_nombre.Text) ||
                string.IsNullOrWhiteSpace(voluntarios_genero.Text) ||
                string.IsNullOrWhiteSpace(voluntarios_numero.Text) ||
                string.IsNullOrWhiteSpace(voluntarios_correo.Text) ||
                voluntarios_imagen.Image == null)
            {
                MessageBox.Show("Por favor, llena los espacios en blanco", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            // Verificar si el ID ya está en uso
                            string checkVoID = "SELECT COUNT(*) FROM voluntarios WHERE id = id";

                            using (SqlCommand checkVo = new SqlCommand(checkVoID, connect))
                            {

                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO voluntarios " +
                                    "(nombre, genero, numero, correo, imagen, insert_date) " +
                                    "VALUES ( @nombre, @genero, @numero, @correo, @imagen, @insertDate)";

                                string path = Path.Combine(@"C:\Users\epera\OneDrive\Escritorio\Proyecto Actualizado\RegistroDeActividades\Directory\"
                                    + voluntario_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(voluntarios_imagen.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@nombre", voluntarios_nombre.Text.Trim());
                                    cmd.Parameters.AddWithValue("@genero", voluntarios_genero.Text.Trim());
                                    cmd.Parameters.AddWithValue("@numero", voluntarios_numero.Text.Trim());
                                    cmd.Parameters.AddWithValue("@correo", voluntarios_correo.Text.Trim());
                                    cmd.Parameters.AddWithValue("@imagen", path);
                                    cmd.Parameters.AddWithValue("@insertDate", today);

                                    cmd.ExecuteNonQuery();

                                    DisplayVoluntariosData();

                                    MessageBox.Show("Añadido correctamente!", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        public void DisplayVoluntariosData()
        {
            VoluntariosData ed = new VoluntariosData();
            List<VoluntariosData> listData = ed.VoluntariosListData(); // Corregido aquí
            dataGridView1.DataSource = listData;
        }

        // Eventos no utilizados o placeholders
        private void Label1_Click(object sender, EventArgs e) { }
        private void Label2_Click(object sender, EventArgs e) { }
        private void Label5_Click(object sender, EventArgs e) { }
        private void Panel1_Paint(object sender, PaintEventArgs e) { }
        private void Panel2_Paint(object sender, PaintEventArgs e) { }
        private void Voluntarios_Numero_TextChanged(object sender, EventArgs e) { }

        private void voluntarios_importar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Imágenes (*.jpg; *.png)|*.jpg;*.png"; // Corregido el filtro
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    voluntarios_imagen.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void voluntario_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
