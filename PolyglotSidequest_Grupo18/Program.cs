using System;
using System.Numerics;
using PolyglotSidequest_Grupo18.Clases;

namespace PolyglotSidequest_Grupo18
{
    public enum LINES { NOLINE, SINGLELINE, DOUBLELINE };
    public enum MODES { NOMODE, INT_FLOAT, INT_INT_INT };
    public enum PARAMETERS { ELEMENT_LENGTH, THERMAL_CONDUCTIVITY, HEAT_SOURCE };
    public enum SIZES { NODES, ELEMENTS, DIRICHLET, NEUMANN };

    class Program
    {
        static void Main(string[] args)
        {
            float[,] localKs;
            Vector<float> localBs;

            float[,] K;
            Vector<float> b;
            Vector<float> T;

            Console.WriteLine("Implementacion MEF 1D Transferencia Calor con Pesos de Galerkin");

            Mesh m;
        }
    }
}
