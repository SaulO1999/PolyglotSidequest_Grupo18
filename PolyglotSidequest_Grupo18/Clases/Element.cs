using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    class Element : Item
    {
        public override void setIntIntInt(int identifier, int firstnode, int secondnode)
        {
            id = identifier;
            node1 = firstnode;
            node2 = secondnode;
        }
    }
}
