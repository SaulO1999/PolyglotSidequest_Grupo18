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
    }
}
