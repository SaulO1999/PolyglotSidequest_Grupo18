using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    public class Node : Item
    {
        public override void setIntFloat(int identifier, float coordinate)
        {
            this.id = identifier;
            this.x = coordinate;
        }
    }
}
