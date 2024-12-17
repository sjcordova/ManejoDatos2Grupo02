using SQLite;

namespace ManejoDatosGrupo02.Models
{
    public class EstudianteUDLA
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Carrera { get; set; }
    }
}
