﻿using HolaMundoHebra.Hebras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaMundoHebra
{
    class Program
    {
        static void ejecutar()
        {
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hola desde Hebra {0} rep {1}", i, Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }*/
            int i = Convert.ToInt32(Thread.CurrentThread.Name);
            Thread.Sleep(i * 1000);
            Console.WriteLine("Hola desde {0}", i);
        }

        static void ejecutarConParametro(object o)
        {
            int i = (int)o;
            Thread.Sleep(i * 1000);
            Console.WriteLine("Hola desde {0}", i);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Esto esta antes de la hebra");
            //Thread t = new Thread(new ThreadStart(ejecutar));
            //t.Name = "Hebra de Luis";
            //t.Start();
            //Thread t2 = new Thread(new ThreadStart(ejecutar));
            //t2.Name = "Hebre de Maria";
            //t2.Start();
            //Console.WriteLine("Esto se esta ejecuntando despues de la hebra");
            //Console.ReadKey();
            Console.WriteLine("Inciando Hebras");
            for (int i=1; i<7; i++)
            {
                HebraEjercicio he = new HebraEjercicio(i);

                //Thread t = new Thread(new ParameterizedThreadStart(ejecutarConParametro));
                Thread t = new Thread(new ThreadStart(he.ejecutar));
                t.Name = i.ToString();
                t.IsBackground = false;
                t.Start();
            }
            Console.WriteLine("Hebras iniciadas");
            Console.ReadKey();
        }
    }
}
