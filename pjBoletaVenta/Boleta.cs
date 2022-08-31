using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjBoletaVenta
{
    public class Boleta
    {
        // Atributos
       
        public string numBoleta { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string cedula { get; set; }
        public string producto { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }

        // Métodos
        public double determinaPrecio()
        {
                       switch (producto)
            {
                case "PS5+ 1 MANDO DS5": return 500;
                case "PS4 (1TB) + 1 MANDO DS4": return 619;
                case "MANDO PS5/DS5": return 69;
                case "MANDO PS4/DS4": return 60;
            }
            return 0;
        }

        public double calcularImporte()
        {
            return cantidad * determinaPrecio();
        }
    }
}
