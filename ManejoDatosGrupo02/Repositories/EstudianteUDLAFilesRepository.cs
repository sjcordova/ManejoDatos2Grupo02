using ManejoDatosGrupo02.Interfaces;
using ManejoDatosGrupo02.Models;
using Newtonsoft.Json;

namespace ManejoDatosGrupo02.Repositories
{
    public class EstudianteUDLAFilesRepository : IEstudianteUdlaRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public EstudianteUDLA DevuelveInfoEstudiante(int id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();
            try
            {
                if (File.Exists(_fileName))
                {
                    string json_data= File.ReadAllText(_fileName);
                    estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(json_data);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }

        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantesUDLA()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }
    }
}
