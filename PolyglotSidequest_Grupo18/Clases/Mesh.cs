using System;
using System.Collections.Generic;
using System.Text;

namespace PolyglotSidequest_Grupo18.Clases
{
    class Mesh
    {
        protected float[] parameters = new float[3];
        protected int[] sizes = new int[4];
        protected Node[] node_list;
        protected Element[] element_list;
        protected Condition[] dirichlet_list;
        protected Condition[] neumann_list;

        public void setParameters(float L, float k, float Q)
        {
            parameters[PARAMETERS.ELEMENT_LENGTH] = L; //ELEMNT_LENGHT = 0
            parameters[PARAMETERS.THERMAL_CONDUCTIVITY] = k;
            parameters[PARAMETERS.HEAT_SOURCE] = Q;
        }

        public void setSizes(int num_nodes, int num_elements, int num_dirich, int num_neu)
        {
            sizes[SIZES.NODES] = num_nodes;
            sizes[SIZES.ELEMENTS] = num_elements;
            sizes[SIZES.DIRICHLET] = num_dirich;
            sizes[SIZES.NEUMANN] = num_neu;
        }

        int getSize(int s)
        {
            return sizes[s];
        }

        float getParameter(int p)
        {
            return parameters[p];
        }

        void createData()
        {
            node_list = new Node[sizes[SIZES.NODES]];
            element_list = new Element[sizes[SIZES.ELEMENTS]];
            dirichlet_list = new Condition[sizes[SIZES.DIRICHLET]];
            neumann_list = new Condition[sizes[SIZES.NEUMANN]];
        }

        Node[] getNodes()
        {
            return node_list;
        }
        Element[] getElements()
        {
            return element_list;
        }
        Condition[] getDirichlet()
        {
            return dirichlet_list;
        }
        Condition[] getNeumann()
        {
            return neumann_list;
        }

        Node getNode(int i)
        {
            return node_list[i];
        }

        Element getElement(int i)
        {
            return element_list[i];
        }

        Condition getCondition(int i, int type)
        {
            if (type == SIZES.DIRICHLET) return dirichlet_list[i];
            else return neumann_list[i];
        }
    }
}
