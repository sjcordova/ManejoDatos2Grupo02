using ManejoDatosGrupo02.Interfaces;
using ManejoDatosGrupo02.Models;

namespace ManejoDatosGrupo02.Repositories
{
    public class EstudianteUDLAAPIsRepository : IEstudianteUdlaRepository
    {
        public string urlEndpoint = "https://www.freetestapi.com/api/v1/students";
        public HttpClient _httpClient;

        public EstudianteUDLAAPIsRepository()
        {
            _httpClient = new HttpClient();
        }

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA DevuelveInfoEstudiante(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EstudianteUDLA>> DevuelveListadoEstudiantesUDLA()
        {
            List<EstudianteUDLA> estudiantesUDLA = new List<EstudianteUDLA>();

            try
            {
                using (_httpClient)
                {
                    var response = await _httpClient.GetAsync(urlEndpoint);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }
    }
}
