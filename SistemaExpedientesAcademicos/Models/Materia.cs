using System.Collections.Generic;

namespace SistemaExpedientesAcademicos.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }

        public string NombreMateria { get; set; }

        public string Docente { get; set; }

        // aquí guardo todos los expedientes donde aparece esta materia
        public List<Expediente> Expedientes { get; set; }
    }
}