using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18
{
    class Clases
    {
        enum LINES { NOLINE, SINGLELINE, DOUBLELINE };
        enum MODES { NOMODE, INT_FLOAT, INT_INT_INT };
        enum PARAMETERS { ELEMENT_LENGTH, THERMAL_CONDUCTIVITY, HEAT_SOURCE };
        enum SIZES { NODES, ELEMENTS, DIRICHLET, NEUMANN };
        class item
        {
            protected int id;
            protected float x;
            protected int node1;
            protected int node2;
            protected float value;

            public int getId()
            {
                return id;
            }
            public float getX()
            {
                return x;
            }

            public int getNode1()
            {
                return node1;
            }

            public int getNode2()
            {
                return node2;
            }

            public float getValue()
            {
                return value;
            }
        }
    }
}
