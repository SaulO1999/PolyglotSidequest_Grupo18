using System;
using System.Collections.Generic;
using System.Text;
//using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace PolyglotSidequest_Grupo18
{
    public class Math_tools
    {
        public void zeroes(ref Matrix<float> M, int n)
        {
            //Se crean n filas
            for (int i = 0; i < n; i++)
            {
                //Se crea una fila de n ceros
                Vector<float> row = Vector<float>.Build.Dense(n, (float)0.0);
                //Vector<float> row = new Vector<float>(zero,n);
                //Se ingresa la fila en la matriz
                M.SetRow(i, row);
//                Console.WriteLine(M.ToString());
            }
        }

        public void zeroes(ref Vector<float> v, int n)
        {
            //Se itera n veces
            for (int i = 0; i < n; i++)
            {
                //fill with zeroes
                v.Add((float)0.0);
            }
        }

        void copyMatrix(Matrix<float> A, ref Matrix<float> copy)
        {
            A.CopyTo(copy);
        }

        public void productMatrixVector(Matrix<float> A, Vector<float> v, ref Vector<float> R)
        {
            for (int f = 0; f < A.RowCount; f++)
            {
                //Se inicia un acumulador
                float cell = (float)0.0;
                //Se calcula el valor de la celda de acuerdo a la formulación
                for (int c = 0; c < v.Count; c++)
                {
                    cell += A.At(f, c) * v.At(c);
                }
                //Se coloca el valor calculado en su celda correspondiente en la respuesta
                R[f] += cell;
            }
        }

        void productRealMatrix(float real, Matrix<float> M, ref Matrix<float> R)
        {
            M.Multiply(real);
            M.CopyTo(R);
        }

        void getMinor(Matrix<float> M, int i, int j)
        {
            //Se elimina la fila i
            //M.erase(M.begin() + i); //Uso de begin para obtener un iterator a la posición de interés
            //Se recorren las filas restantes
            M.RemoveRow(i);
            M.RemoveColumn(j);
            //for (int i = 0; i < M.RowCount; i++)
            //En cada fila se elimina la columna j
            //M.at(i).erase(M.at(i).begin() + j);

        }
    }
}

