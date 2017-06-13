using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEntitys
{
    public abstract class Ficha
    {
        public Posicion PosActual { get; set; }
        public enum Color { Blanco, Negro };
        private Color color;
        public Ficha(Color col,Posicion pos)
        {
            this.PosActual = pos;
            this.color = col;
        }
        public abstract bool Movimiento(Posicion PosNueva);
        public Color ObtenerColor()
        {
            return this.color;
        }
    }
}
