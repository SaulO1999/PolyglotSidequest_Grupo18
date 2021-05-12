using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PolyglotSidequest_Grupo18.Clases;

namespace PolyglotSidequest_Grupo18
{
    public class Tools
    {
        private const string FILE_NAME = "problem.msh";

        public void obtenerDatos(ref StreamReader file, int itemcase, int n, int mode, ref Node[] item_list)
        {
            //Se prepara una variable string para leer las líneas a omitir
            string line = "";
            string[] lineArray;
            //Siempre se omite al menos una línea
            //file >> line;
            Console.WriteLine("empiezanreadlines");

            switch (itemcase)
            {
                case 0:
                    while (line != "Coordinates")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                        break;
                case 1:
                    while (line != "Elements")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 2:
                    while (line != "Dirichlet")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 3:
                    while (line != "Neumann")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
            }

                //Se itera una cantidad de veces igual a la cantidad de datos a extraer
                //que será igual a la cantidad de objetos a instanciar
                for (int i = 0; i < n; i++)
            {
                //Se verifica la cantidad y tipos de datos a extraer por fila
                switch (mode)
                {
                    //Se extrae un entero y un real por fila
                    case 1:
                        int e; float r;
                        line = file.ReadLine();
                        lineArray = line.Split('\t');
                        Console.WriteLine(lineArray);
                        e = int.Parse(lineArray[0]);
                        r = float.Parse(lineArray[1]);
                        foreach (string item in lineArray)
                        {
                            Console.WriteLine(item);
                        }
                        //file >> e >> r;
                        //Se instancian el entero y el real del objeto actual
                        item_list[i].setIntFloat(e, r);
                        break;
                    //Se extraen tres enteros
                    case 2:
                        int e1, e2, e3;
                        line = file.ReadLine();
                        lineArray = line.Split(' ');
                        e1 = int.Parse(lineArray[0]);
                        e2 = int.Parse(lineArray[1]);
                        e3 = int.Parse(lineArray[2]);
                        foreach (string item in lineArray)
                        {
                            Console.WriteLine(item);
                        }
                        //file >> e1 >> e2 >> e3;
                        //Se instancia los tres enteros en el objeto actual
                        item_list[i].setIntIntInt(e1, e2, e3);
                        break;
                }
            }
        }

        public void obtenerDatos(ref StreamReader file, int itemcase, int n, int mode, ref Element[] item_list)
        {
            //Se prepara una variable string para leer las líneas a omitir
            string line = "";
            string[] lineArray;
            //Siempre se omite al menos una línea
            //file >> line;
            Console.WriteLine("empiezanreadlines");

            switch (itemcase)
            {
                case 0:
                    while (line != "Coordinates")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 1:
                    while (line != "Elements")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 2:
                    while (line != "Dirichlet")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 3:
                    while (line != "Neumann")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
            }

            //Se itera una cantidad de veces igual a la cantidad de datos a extraer
            //que será igual a la cantidad de objetos a instanciar
            for (int i = 0; i < n; i++)
            {
                //Se verifica la cantidad y tipos de datos a extraer por fila
                switch (mode)
                {
                    //Se extrae un entero y un real por fila
                    case 1:
                        int e; float r;
                        line = file.ReadLine();
                        lineArray = line.Split('\t');
                        Console.WriteLine(lineArray);
                        e = int.Parse(lineArray[0]);
                        r = float.Parse(lineArray[1]);
                        foreach (string item in lineArray)
                        {
                            Console.WriteLine(item);
                        }
                        //file >> e >> r;
                        //Se instancian el entero y el real del objeto actual
                        item_list[i].setIntFloat(e, r);
                        break;
                    //Se extraen tres enteros
                    case 2:
                        int e1, e2, e3;
                        line = file.ReadLine();
                        lineArray = line.Split(' ');
                        e1 = int.Parse(lineArray[0]);
                        e2 = int.Parse(lineArray[1]);
                        e3 = int.Parse(lineArray[2]);
                        foreach (string item in lineArray)
                        {
                            Console.WriteLine(item);
                        }
                        //file >> e1 >> e2 >> e3;
                        //Se instancia los tres enteros en el objeto actual
                        item_list[i].setIntIntInt(e1, e2, e3);
                        break;
                }
            }
        }

        public void obtenerDatos(ref StreamReader file, int itemcase, int n, int mode, ref Condition[] item_list)
        {
            //Se prepara una variable string para leer las líneas a omitir
            string line = "";
            string[] lineArray;
            //Siempre se omite al menos una línea
            //file >> line;
            Console.WriteLine("empiezanreadlines");

            switch (itemcase)
            {
                case 0:
                    while (line != "Coordinates")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 1:
                    while (line != "Elements")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 2:
                    while (line != "Dirichlet")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                case 3:
                    while (line != "Neumann")
                    {
                        line = file.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
            }

            //Se itera una cantidad de veces igual a la cantidad de datos a extraer
            //que será igual a la cantidad de objetos a instanciar
            for (int i = 0; i < n; i++)
            {
                //Se verifica la cantidad y tipos de datos a extraer por fila
                switch (mode)
                {
                    //Se extrae un entero y un real por fila
                    case 1:
                        int e; float r;
                        line = file.ReadLine();
                        lineArray = line.Split('\t');
                        Console.WriteLine(lineArray);
                        e = int.Parse(lineArray[0]);
                        r = float.Parse(lineArray[1]);
                        foreach (string item in lineArray)
                        {
                            Console.WriteLine(item);
                        }
                        //file >> e >> r;
                        //Se instancian el entero y el real del objeto actual
                        item_list[i].setIntFloat(e, r);
                        break;
                    //Se extraen tres enteros
                    case 2:
                        int e1, e2, e3;
                        line = file.ReadLine();
                        lineArray = line.Split(' ');
                        e1 = int.Parse(lineArray[0]);
                        e2 = int.Parse(lineArray[1]);
                        e3 = int.Parse(lineArray[2]);
                        foreach (string item in lineArray)
                        {
                            Console.WriteLine(item);
                        }
                        //file >> e1 >> e2 >> e3;
                        //Se instancia los tres enteros en el objeto actual
                        item_list[i].setIntIntInt(e1, e2, e3);
                        break;
                }
            }
        }

        public void leerMallayCondiciones(ref Mesh m)
        {
            

            //Se preparan variables para extraer los parámetros del problema y las cantidades de
            //datos en la malla (nodos, elementos, condiciones de Dirichlet, condiciones de Neumann)
            float l, k, Q;
            int nnodes, neltos, ndirich, nneu;

            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine($"{FILE_NAME} does not exist!");
                return;
            }

            FileStream fsIn = new FileStream(FILE_NAME, FileMode.Open,
                FileAccess.Read, FileShare.Read);
            // Create an instance of StreamReader that can read
            // characters from the FileStream.
            StreamReader sr = new StreamReader(fsIn);
                
            string unalinea;
            string[] lineastring;
            // While not at the end of the file, read lines from the file.

                unalinea = sr.ReadLine();
                lineastring = unalinea.Split(' ');

            l = float.Parse(lineastring[0]);
            k = float.Parse(lineastring[1]);
            Q = float.Parse(lineastring[2]);

            foreach (string item in lineastring)
            {
                Console.WriteLine(item);
            }

            unalinea = sr.ReadLine();
            lineastring = unalinea.Split(' ');

            nnodes = int.Parse(lineastring[0]);
            neltos = int.Parse(lineastring[1]);
            ndirich = int.Parse(lineastring[2]);
            nneu = int.Parse(lineastring[3]);

            foreach (string item in lineastring){
                Console.WriteLine(item);
            }

            m.setParameters(l, k, Q);
            m.setSizes(nnodes, neltos, ndirich, nneu);
            m.createData();
            Node[] misnodos = m.getNodes();
            //Console.WriteLine("before");
            for(int i = 0; i < misnodos.Length; i++)
            {
                Node item = new Node();
                misnodos[i] = item;
                misnodos[i].setIntFloat(0, (float)0.0);
                //Console.WriteLine(misnodos[i]);
            }
            //Console.WriteLine("after");
            Element[] miselementos = m.getElements();
            for (int i = 0; i < miselementos.Length; i++)
            {
                Element item = new Element();
                miselementos[i] = item;
                miselementos[i].setIntIntInt(0,0,0);
                //Console.WriteLine(misnodos[i]);
            }
            Condition[] misdirichlet = m.getDirichlet();
            //Console.WriteLine("before");
            for (int i = 0; i < misdirichlet.Length; i++)
            {
                Condition item = new Condition();
                misdirichlet[i] = item;
                misdirichlet[i].setIntFloat(0, (float)0.0);
                //Console.WriteLine(misnodos[i]);
            }
            Condition[] misneumann = m.getNeumann();
            //Console.WriteLine("before");
            for (int i = 0; i < misneumann.Length; i++)
            {
                Condition item = new Condition();
                misneumann[i] = item;
                misneumann[i].setIntFloat(0, (float)0.0);
                //Console.WriteLine(misnodos[i]);
            }

            obtenerDatos(ref sr, 0, nnodes, 1, ref misnodos);
            obtenerDatos(ref sr, 1, neltos, 2, ref miselementos);
            obtenerDatos(ref sr, 2, ndirich, 1, ref misdirichlet);
            obtenerDatos(ref sr, 3, nneu, 1, ref misneumann);

            /*



                Console.WriteLine(input[0]);
                //while (sr.Peek() > -1)
                //{
                //input = sr.ReadLine();
                //Console.WriteLine(input);
                //Console.WriteLine(input.Split(' ')[1]);




                //}
            

            //Se prepara un arreglo para el nombre del archivo
            char filename[15];
            //Se prepara un flujo para el archivo
            ifstream file;
            
            

            //Se obliga al usuario a ingresar correctamente el nombre del archivo
            do
            {
                cout << "Ingrese el nombre del archivo que contiene los datos de la malla: ";
                cin >> filename;
                //Se intenta abrir el archivo
                file.open(filename);
            } while (!file); //Si no fue posible abrir el archivo, se intenta de nuevo

            //Se leen y guardan los parámetros y cantidades
            file >> l >> k >> Q;
            file >> nnodes >> neltos >> ndirich >> nneu;

            //Se instancian los parámetros y cantidades en el objeto mesh
            m.setParameters(l, k, Q);
            m.setSizes(nnodes, neltos, ndirich, nneu);
            //En base a las cantidades, se preparan arreglos de objetos para guardar
            //el resto de la información
            m.createData();

            //Se extraen, siguiendo el formato del archivo, la información de:
            //- Los nodos de la malla
            //- Los elementos de la malla
            //- Las condiciones de Dirichlet impuestas
            //- Las condiciones de Neumann impuestas
            obtenerDatos(file, SINGLELINE, nnodes, INT_FLOAT, m.getNodes());
            obtenerDatos(file, DOUBLELINE, neltos, INT_INT_INT, m.getElements());
            obtenerDatos(file, DOUBLELINE, ndirich, INT_FLOAT, m.getDirichlet());
            obtenerDatos(file, DOUBLELINE, nneu, INT_FLOAT, m.getNeumann());

            //Se cierra el archivo antes de terminar
            file.close();
        */
        }
    }
}
