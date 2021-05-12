using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    public class Item
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

        public virtual void setIntFloat(int n, float r) { }

        public virtual void setIntIntInt(int n1, int n2, int n3) { }
    }
}
