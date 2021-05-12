using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    public class Mesh
    {
        protected float[] parameters = new float[3];
        protected int[] sizes = new int[4];
        protected Node[] node_list;
        protected Element[] element_list;
        protected Condition[] dirichlet_list;
        protected Condition[] neumann_list;

        public void setParameters(float L, float k, float Q)
        {
            parameters[0] = L; //ELEMNT_LENGHT = 0
            parameters[1] = k;
            parameters[2] = Q;
        }

        public void setSizes(int num_nodes, int num_elements, int num_dirich, int num_neu)
        {
            sizes[0] = num_nodes;
            sizes[1] = num_elements;
            sizes[2] = num_dirich;
            sizes[3] = num_neu;
        }

        public int getSize(int s)
        {
            return sizes[s];
        }

        public float getParameter(int p)
        {
            return parameters[p];
        }

        public void createData()
        {
            node_list = new Node[sizes[0]];
            element_list = new Element[sizes[1]];
            dirichlet_list = new Condition[sizes[2]];
            neumann_list = new Condition[sizes[3]];
        }

        public Node[] getNodes()
        {
            return node_list;
        }
        public Element[] getElements()
        {
            return element_list;
        }
        public Condition[] getDirichlet()
        {
            return dirichlet_list;
        }
        public Condition[] getNeumann()
        {
            return neumann_list;
        }

        public Node getNode(int i)
        {
            return node_list[i];
        }

        public Element getElement(int i)
        {
            return element_list[i];
        }

        public Condition getCondition(int i, int type)
        {
            if (type == 2) return dirichlet_list[i];
            else return neumann_list[i];
        }
    }
}
