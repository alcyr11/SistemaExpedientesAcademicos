namespace SistemaExpedientesAcademicos.Models
{
    public class Expediente
    {
        public int ExpedienteId { get; set; }

        public int AlumnoId { get; set; }

        public int MateriaId { get; set; }

        public decimal NotaFinal { get; set; }

        public string Observaciones { get; set; }

        // este conecta el expediente con un alumno
        public Alumno Alumno { get; set; }

        // este conecta el expediente con una materia
        public Materia Materia { get; set; }
    }
}