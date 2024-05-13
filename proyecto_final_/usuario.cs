using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_
{
    public class usuario
    {
        public int id { get; set; }
        public string Usuario_ { get; set; }
        public int Password { get; set; }
        public int Rol { get; set; }
    }

    public class paciente
    {
        public int IDcarnet { get; set; }
        public string Nombre_paciente { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public int Edad { get; set; }
        public string Tipo_sangre { get; set; }
        public int Contacto_paciente { get; set; }
        public int Contacto_emergencia { get; set; }
        public string Medicinas_administradas { get; set; }
        public string Dosis_medicinas { get; set; }
        public string Alergias { get; set; }
        public string Enfermedad_cronic { get; set; }
        public string Antecedentes_fam { get; set; }
        public DateTime ultima_cita { get; set; }

    }
    public class pruebas_med
    {
        public int ID { get; set; }
        public int no_carnet { get; set; }
        public string Nombre_paciente { get; set; }
        public string Tipo_prueba { get; set; }
        public int Contacto_paciente { get; set; }
        public string Resultados { get; set; }
    }
    public class citas_med
    {
        public int ID { get; set; }
        public int no_carnet { get; set; }
        public string Nombre_paciente { get; set; }
        public int Contacto_paciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre_doctor { get; set; }
        public string asunto { get; set; }
    }
}
