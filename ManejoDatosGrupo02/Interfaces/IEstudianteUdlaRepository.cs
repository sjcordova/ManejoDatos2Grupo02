using ManejoDatosGrupo02.Models;

namespace ManejoDatosGrupo02.Interfaces
{
    public interface IEstudianteUdlaRepository
    {
        bool CrearEstudianteUDLA(EstudianteUDLA estudiante);
        bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        bool EliminarEstudianteUDLA(int id);
        Task<IEnumerable<EstudianteUDLA>> DevuelveListadoEstudiantesUDLA();
        EstudianteUDLA DevuelveInfoEstudiante(int id);
    }
}
