using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChessEntitys
{
    public class Tablero
    {
        public int[][] Casilleros{ get; set; }
        List<Ficha> FichasB = new List<Ficha>();
        List<Ficha> FichasN = new List<Ficha>();

        
        //public bool EstaOcupado(Posicion nuevaPos)
        //{
        //    if (FichasB.Exists(x => x.PosActual.Columna == nuevaPos.Columna && x.PosActual.Fila == nuevaPos.Fila))
        //        return true;
        //    if (FichasN.Exists(x => x.PosActual.Columna == nuevaPos.Columna && x.PosActual.Fila == nuevaPos.Fila))
        //        return true;
        //    return false;
        //}

        public int EstaOcupado(Posicion nuevaPos)
        {
            Ficha ficha = FichasB.Find(x => x.PosActual.Columna == nuevaPos.Columna && x.PosActual.Fila == nuevaPos.Fila);
            if (!Object.Equals(null, ficha))
                return ficha.ID;
            ficha = FichasN.Find(x => x.PosActual.Columna == nuevaPos.Columna && x.PosActual.Fila == nuevaPos.Fila);
            if (!Object.Equals(null, ficha))
                return ficha.ID;
            return 0;
        }

        

        

    }
}
