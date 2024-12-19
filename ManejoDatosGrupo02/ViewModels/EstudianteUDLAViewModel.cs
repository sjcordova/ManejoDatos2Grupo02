using ManejoDatosGrupo02.Interfaces;
using ManejoDatosGrupo02.Models;
using ManejoDatosGrupo02.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ManejoDatosGrupo02.ViewModels
{
    public class EstudianteUDLAViewModel : INotifyPropertyChanged
    {
        private List<EstudianteUDLA> _estudiantes;
        private EstudianteUDLA _estudiante;
        private string _resultado;

        private IEstudianteUdlaRepository _repositorio;
        public ICommand CommandGuardaInformacion { get; }

        public List<EstudianteUDLA> estudiantes
        {
            get => _estudiantes;
            set
            {
                if (_estudiantes != value)
                {
                    _estudiantes = value;
                    OnPropertyChanged();
                }
            }
        }
        public EstudianteUDLA estudiante
        {
            get => _estudiante;
            set
            {
                if (_estudiante != value)
                {
                    _estudiante = value;
                    OnPropertyChanged();
                }
            }
        }
        public string resultado
        {
            get=>_resultado;
            set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public EstudianteUDLAViewModel()
        {
            _repositorio = new EstudianteUDLASQLiteRepository();
            estudiante = new EstudianteUDLA();
            CommandGuardaInformacion = new Command(GuardarEstudianteUDLA);
        }


        public void GuardarEstudianteUDLA()
        {
            var guardar= _repositorio.CrearEstudianteUDLA(estudiante);
            if (guardar)
            {
                resultado = "Guardado Correctamente";
            }
            else
            {
                resultado = "No se pudo guardar";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
