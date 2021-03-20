using System;
using System.Threading;

namespace segundo_ejemplo
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int FILAB = 35;
            int COLUMF = 25;
            int INTERNO = 5;
            int COLUMI = 5;
            int F, C, A;

            for (A = 1; A <= Cantidad; A++)
            {
                for (F = COLUMI; F <= COLUMF; F++)
                {
                    Console.SetCursorPosition(F, FILAB); Console.Write("$");
                    Console.SetCursorPosition(F, INTERNO); Console.Write("#");
                }
                for (C = COLUMI; C <= FILAB; C++)
                {
                    Console.SetCursorPosition(COLUMI, C); Console.Write("***");
                    Console.SetCursorPosition(COLUMF, C); Console.Write("XXX");
                }
                INTERNO = INTERNO + 1; 
                FILAB = FILAB - 1;
                COLUMI = COLUMI + 1;
                COLUMF = COLUMF - 1;
            }
        }

        static void Main(string[] args)
        {
            for (int tam = 1; tam < 5; tam++)
            {
                dibuja(tam);
                Thread.Sleep(50); 
            }

        }
    } 
}


 






