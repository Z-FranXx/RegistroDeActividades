using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RegistroDeActividades.Data
{
    public class VoluntariosData
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Numero { get; set; }
        public string Correo { get; set; }
        public string Imagen { get; set; }

        private readonly string connectionString = "Server=DESKTOP-AA6ALA0\\SQLEXPRESS;Database=proyectofinal;Trusted_Connection=True;";

        public List<VoluntariosData> VoluntariosListData()
        {
            List<VoluntariosData> listdata = new List<VoluntariosData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM voluntarios WHERE delete_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            VoluntariosData ed = new VoluntariosData();
                            ed.ID = (int)reader["id"];
                            ed.Nombre = reader["nombre"].ToString();
                            ed.Genero = reader["genero"].ToString();
                            ed.Numero = reader["numero"].ToString();
                            ed.Correo = reader["correo"].ToString();  // Corregido
                            ed.Imagen = reader["imagen"].ToString();

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close(); // Cerrar la conexión adecuadamente
                }
            }

            // Imprimir los resultados para depuración
            foreach (var voluntario in listdata)
            {
                Console.WriteLine($"ID: {voluntario.ID}, Nombre: {voluntario.Nombre}, Genero: {voluntario.Genero}, Numero: {voluntario.Numero}, Correo: {voluntario.Correo}, Imagen: {voluntario.Imagen}");
            }

            return listdata;
        }
    }
}
