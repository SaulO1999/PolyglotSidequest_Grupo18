using System;
using System.Collections.Generic;
using System.Text;
using PolyglotSidequest_Grupo18.Clases;
//using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace PolyglotSidequest_Grupo18
{
    public class Sel
    {
        public Matrix<float> createLocalK(int element, ref Mesh m)
        {
            Matrix<float> K = Matrix<float>.Build.Dense(2,2);
            Vector<float> row1 = Vector<float>.Build.Dense(2);
            Vector<float> row2 = Vector<float>.Build.Dense(2);

            float k = m.getParameter(1);
            float l = m.getParameter(0);

            row1.Add(k / l);
            row1.Add(-k / l);
            row2.Add(-k / l);
            row2.Add(k / l);

            K.InsertRow(0, row1);
            K.InsertRow(0, row2);

            return K;
        }

        public Vector<float> createLocalB(int element, ref Mesh m)
        {
            Vector<float> b = Vector<float>.Build.Dense(2);

            float Q = m.getParameter(2);
            float l = m.getParameter(0);

            b.Add(Q * l / 2);
            b.Add(Q * l / 2);

            return b;
        }

        public void crearSistemaLocales(ref Mesh m, ref Matrix<float>[] localKs, ref Vector<float>[] localBs)
        {
            for(int i = 0; i < m.getSize(1); i++)
            {
                localKs[i] = createLocalK(i, ref m);
                localBs[i] = createLocalB(i, ref m);
            }
        }

        void assemblyK(Element e, Matrix<float> localK, ref Matrix<float> K)
        {
            int index1 = e.getNode1() - 1;
            int index2 = e.getNode2() - 1;

            K[index1,index1] += localK.At(0, 0);
            K[index1,index2] += localK.At(0, 1);
            K[index2,index1] += localK.At(1, 0);
            K[index2,index2] += localK.At(1, 1);
        }
        void assemblyb(Element e, Vector<float> localb, ref Vector<float> b)
        {
            int index1 = e.getNode1() - 1;
            int index2 = e.getNode2() - 1;

            b[index1] += localb.At(0);
            b[index2] += localb.At(1);
        }

        public void ensamblaje (ref Mesh m, ref Matrix<float>[] localKs, ref Vector<float>[] localBs, ref Matrix<float> K, ref Vector<float> b)
        {
            for(int i = 0; i < m.getSize(1); i++)
            {
                Element e = m.getElement(i);

                assemblyK(e, localKs[i], ref K);
                assemblyb(e, localBs[i], ref b);

            }
        }

        public void applyNeumann(ref Mesh m, ref Vector<float> b)
        {
            for (int i = 0; i < m.getSize(3); i++)
            {
                Condition c = m.getCondition(i, 3);

                b[c.getNode1() - 1] += c.getValue();
            }
        }

        public void applyDirichlet(ref Mesh m, ref Matrix<float> K, ref Vector<float> b)
        {
            for(int i = 0; i < m.getSize(2); i++)
            {
                Condition c = m.getCondition(i, 2);

                int index = c.getNode1() - 1;

                K.RemoveRow(index);

                if(index == 0)
                    b = b.SubVector(1, b.Count);
                else
                    b = b.SubVector(0, b.Count - 1);

                for(int row = 0; row < K.RowCount; row++)
                {
                    float cell = K.At(row, index);
                    b[row] += -1 * c.getValue() * cell;
                }
                    K.RemoveColumn(index);
            }
        }
    }
}
