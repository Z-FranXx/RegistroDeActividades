namespace RegistroDeActividades.Services
{
    public class ActividadService
    {
        private readonly ActividadRepository _actividadRepository;

        public ActividadService()
        {
            _actividadRepository = new ActividadRepository();
        }

        public void RegistrarActividad(string nombre, DateTime fecha, string descripcion)
        {
            var actividad = new Actividad
            {
                Nombre = nombre,
                Fecha = fecha,
                Descripcion = descripcion
            };

            _actividadRepository.AddActividad(actividad);
        }

        // Métodos adicionales para la lógica de negocio
    }
}
