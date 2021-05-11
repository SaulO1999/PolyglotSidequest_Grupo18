using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace PolyglotSidequest_Grupo18
{
    class Math_tools
    {
        readonly List<List<float>> list = new List<List<float>>();

        list
        void zeroes(ref Vector<Vector<float>> M, int n)
        {
            //Se crean n filas
            for (int i = 0; i < n; i++)
            {
                //Se crea una fila de n ceros
                Vector<float> row(n,0.0);
                //Se ingresa la fila en la matriz
                M.push_back(row);
                
            }
        }
    }
}

