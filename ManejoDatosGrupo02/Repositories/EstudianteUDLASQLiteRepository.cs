using ManejoDatosGrupo02.Interfaces;
using ManejoDatosGrupo02.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatosGrupo02.Repositories
{
    public class EstudianteUDLASQLiteRepository : IEstudianteUdlaRepository
    {
        private string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "EstudiantesUDLA.db3");
        private SQLiteConnection _connection;

        public EstudianteUDLASQLiteRepository()
        {
            Init();
        }

        public void Init()
        {
            _connection = new SQLiteConnection(_dbPath);
            _connection.CreateTable<EstudianteUDLA>();
        }

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                int actualizar = _connection.Update(estudiante);
                if (actualizar > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                int insertar= _connection.Insert(estudiante);
                if (insertar > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EstudianteUDLA DevuelveInfoEstudiante(int id)
        {
            var estudiantes = DevuelveListadoEstudiantesUDLA();
            
            if (estudiantes.Any(item => item.Id == id))
            {
                var estudiante = estudiantes.First(item => item.Id == id);
                return estudiante;
            }

            return new EstudianteUDLA();
        }

        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantesUDLA()
        {
            List<EstudianteUDLA> listadoEstudiantes = new List<EstudianteUDLA>();
            listadoEstudiantes = _connection.Table<EstudianteUDLA>().ToList();

            return listadoEstudiantes;
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            try
            {
                //EstudianteUDLA estudiante = DevuelveInfoEstudiante(id);
                int actualizar = _connection.Delete<EstudianteUDLA>(id);
                if (actualizar > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
