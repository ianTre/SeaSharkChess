using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEntitys
{
    public class Peon:Ficha
    {

        public Peon(Color color , Posicion pos) :  base(color,pos)
        {}
        public bool PrimerMovimiento { get; set; }
        public Posicion PosicionActual { get; set; }
        
        override public bool Movimiento(Posicion nuevaPosicion)
        {
            if (nuevaPosicion.Fila != PosicionActual.Fila + 1)
                return false;

            if (nuevaPosicion.Columna != nuevaPosicion.Columna)
            {
                if(!PrimerMovimiento)
                    return false;
                if (nuevaPosicion.Columna != PosActual.Columna + 1 || nuevaPosicion.Columna != PosActual.Columna - 1)
                    return false;
            }

            if (nuevaPosicion.Columna > 8 || nuevaPosicion.Fila > 8)
                return false;

            return true;
        }

        public override Ficha.Color ObtenerColor()
        {
            return this.color;
        }



    }
}
