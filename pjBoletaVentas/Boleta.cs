using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjBoletaVentas
{
    public class Boleta
    {
        public int NumeroBoleta { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CedulaCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescripcionProducto { get; set; }
        public int CantidadComprada { get; set; }

        //METODO PARA DETERMINAR EL PRECIO DEL PRODUCTO

        public double determinaPrecio()
        {

            switch (DescripcionProducto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "PS4(1TB) + 1 MANDO DS4": return 610;
                case "MANDO PS5 / DS5": return 69;
                case "MANDO PS4 / DS4": return 60;
            }
            return 0;
        }

        //METODO PARA DETERMINAR EL IMPORTE

        public double calculaImporte()
        {
            return CantidadComprada * determinaPrecio();
        }
    }
}
