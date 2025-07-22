using System;

namespace MelodiasPerfectas
{
    public class GestionEstudiantes
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Instrumento { get; set; }
        public decimal CostoClase { get; set; }
        public int NumeroClases { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Propiedad calculada
        public decimal TotalPagar
        {
            get
            {
                return CostoClase * NumeroClases;
            }
        }


        public GestionEstudiantes()
        {
            FechaRegistro = DateTime.Today; // Por defecto, fecha actual
        }
    }
}

