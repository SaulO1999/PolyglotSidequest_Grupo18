using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    class Node : Item
    {
        public override void setIntFloat(int identifier, float coordiante)
        {
            id = identifier;
            x = coordiante;
        }
    }
}
