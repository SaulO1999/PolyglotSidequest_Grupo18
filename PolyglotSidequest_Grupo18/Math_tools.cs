using System;
using System.Collections.Generic;
using System.Text;
//using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace PolyglotSidequest_Grupo18
{
    public class Math_tools
    {
        //List<List<float>> list = new List<List<float>>();

        
        public void zeroes(ref Matrix<float> M, int n)
        {
            //Se crean n filas
            for (int i = 0; i < n; i++)
            {
                //Se crea una fila de n ceros
                Vector<float> row = Vector<float>.Build.Dense(n, float.Parse("0.0"));
                //Vector<float> row = new Vector<float>(zero,n);
                //Se ingresa la fila en la matriz
                M.SetRow(i, row);
                Console.WriteLine(M.ToString());
            }
        }
    }
}

