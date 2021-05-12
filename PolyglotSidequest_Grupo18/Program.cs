﻿using System;
//using System.Numerics;
using PolyglotSidequest_Grupo18.Clases;
using MathNet.Numerics.LinearAlgebra;

namespace PolyglotSidequest_Grupo18
{
/*    public enum LINES { NOLINE, SINGLELINE, DOUBLELINE };
    public enum MODES { NOMODE, INT_FLOAT, INT_INT_INT };
    public enum PARAMETERS { ELEMENT_LENGTH, THERMAL_CONDUCTIVITY, HEAT_SOURCE };
    public enum SIZES { NODES, ELEMENTS, DIRICHLET, NEUMANN };
*/
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<float>[] localKs;
            Vector<float>[] localBs;

            Matrix<float> K;
            Vector<float> b;
            Vector<float> T;

            Console.WriteLine("Implementacion MEF 1D Transferencia Calor con Pesos de Galerkin");

            Mesh m = new Mesh();
            Tools t = new Tools();
            Math_tools mt = new Math_tools();
            Sel s = new Sel();

            t.leerMallayCondiciones(ref m);
            
            localKs = new Matrix<float>[m.getElements().Length];
            localBs = new Vector<float>[m.getElements().Length];
            K = Matrix<float>.Build.Dense(m.getNodes().Length, m.getNodes().Length);
            b = Vector<float>.Build.Dense(m.getNodes().Length);

            s.crearSistemaLocales(ref m, ref localKs, ref localBs);

            mt.zeroes(ref K, m.getSize(0));
            mt.zeroes(ref b, m.getSize(0));
            //Matrix<float> m = Matrix<float>.Build.Random(4,4);
            //Math_tools tool = new Math_tools();

            //tool.zeroes(ref m, 4);
        }
    }
}
