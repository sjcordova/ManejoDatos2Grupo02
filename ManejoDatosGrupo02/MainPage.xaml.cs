using ManejoDatosGrupo02.Interfaces;
using ManejoDatosGrupo02.Models;
using ManejoDatosGrupo02.Repositories;

namespace ManejoDatosGrupo02
{
    public partial class MainPage : ContentPage
    {
        public IEstudianteUdlaRepository _estudianteUdlaRepository;
        public EstudianteUDLA estudiante = new EstudianteUDLA();

        public MainPage()
        {
            InitializeComponent();
            _estudianteUdlaRepository = new EstudianteUDLAFilesRepository();

            estudiante = _estudianteUdlaRepository.DevuelveInfoEstudiante(1);

            BindingContext = estudiante;
        }



        private async void btn_guardar_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = Int32.Parse(editor_id.Text),
                Nombre = editor_nombre.Text,
                Carrera = editor_carrera.Text
            };

            bool guardar = _estudianteUdlaRepository.CrearEstudianteUDLA(estudiante);

            if (guardar)
            {
                await DisplayAlert("Alerta", "Guardado correctamente", "OK");
            }
            else{
                await DisplayAlert("Alerta", "Error al guardar", "OK");
            }
            Navigation.PushAsync(new MainPage());
        }
    }

}
