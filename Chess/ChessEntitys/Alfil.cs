using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEntitys
{
    class Alfil : Ficha
    {

        public Alfil(Posicion posa , Color color):base(color,posa)
        {}

        public override bool Movimiento(Posicion PosNueva)
        {
            if (PosNueva.Columna > 8 || PosNueva.Fila > 8)
                return false;
            
            int difFilas, difColumnas;
            difFilas = PosNueva.Fila - PosActual.Fila;
            difColumnas = PosNueva.Columna - PosActual.Columna;

            if (difColumnas != difFilas)
                return false;

            return true;
        }

        public override Ficha.Color ObtenerColor()
        {
            return this.color;
        }
    }
}
