using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    public class Node : Item
    {
        public override void setIntFloat(int identifier, float coordinate)
        {
            id = identifier;
            x = coordinate;
        }
    }
}
