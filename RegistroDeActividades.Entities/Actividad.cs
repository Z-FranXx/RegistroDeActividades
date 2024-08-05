using System.Data;

namespace RegistroDeActividades.Entities
{
    public class Actividad
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public DataSetDateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
