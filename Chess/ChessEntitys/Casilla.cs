using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEntitys
{
    public class Casilla
    {
        public bool Blanco { get; set; }
        public bool TieneFicha { get; set; }
        public bool EsUltimo { get; set; }
        public string ID { get; set; }
    }
}
