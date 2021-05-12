using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    public class Condition : Item
    {
        public override void setIntFloat(int id_node, float p_value)
        {
            node1 = id_node;
            value = p_value;
        }
    }
}
