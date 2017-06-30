using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEntitys
{
    public class Torre : Ficha
    {

        public Torre(Color color , Posicion posicion) : base(color,posicion)
        {}

        public override bool Movimiento(Posicion PosNueva)
        {
            if (PosNueva.Columna > 8 || PosNueva.Fila > 8)
                return false;

            if (PosNueva.Fila != PosActual.Fila && PosNueva.Columna != PosActual.Columna)
                return false;

            return true;

        }

        public override Ficha.Color ObtenerColor()
        {
            return this.color;
        }
    }
}
