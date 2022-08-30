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
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
        public string cdlCliente { get; set; }
        public string descriProducto { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int cantidad { get; set; }

        // Métodos
        public double determinaPrecio()
        {
                       switch (descriProducto)
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
            if (descriProducto == "PS5+ 1 MANDO DS5")
                return 500 * cantidad;
            else if (descriProducto == "PS4 (1TB) + 1 MANDO DS4")
                return 619 * cantidad;
            else if (descriProducto == "MANDO PS5/DS5")
                return 69 * cantidad;
            return 0;
        }
    }
}
