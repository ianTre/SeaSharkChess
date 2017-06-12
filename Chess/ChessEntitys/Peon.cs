using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEntitys
{
    public class Peon
    {
        public bool Blanco { get; set; }
        public bool PrimerMovimiento { get; set; }
        public Posicion PosicionActual { get; set; }
        
        public bool Movimiento(string nuevaPosicion)
        {
            int posFila;
            int posColumna;
            string[] posiciones = nuevaPosicion.Split('-');
            int.TryParse(posiciones[0],out posFila);
            int.TryParse(posiciones[1],out posColumna);

            if (posFila != PosicionActual.Fila + 1)
                return false;

            if (posColumna == PosicionActual.Columna)
                return true;

            if (PrimerMovimiento && (PosicionActual.Columna == posColumna + 1 || PosicionActual.Columna == posColumna - 1))
                return true;

            return false;
        }

    }
}
