using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RegistroDeActividades.Data
{
    public class VoluntariosData
    {
        public int ID { get; set; }
        public string VoluntarioID { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Numero { get; set; }
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
                            ed.VoluntarioID = reader["voluntarios_id"].ToString();
                            ed.Nombre = reader["nombre"].ToString();
                            ed.Genero = reader["genero"].ToString();
                            ed.Numero = reader["numero"].ToString();
                            ed.Imagen = reader["imagen"].ToString();

                            listdata.Add(ed);
                        }
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close(); // Cerrar la conexión adecuadamente
                }
            }

            return listdata;
        }
    }
}
