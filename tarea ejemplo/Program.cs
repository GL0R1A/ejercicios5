using System;
using System.Threading;

namespace tarea_ejemplo
{
    class Program
    {
        public static string Mid(string parametro, int startindex, int Length)
        {
            string result = parametro.Substring(startindex, Length);
            return result;
        }
        static void Main(string[] args)
        {
            string NOMBRE;
            string CARACTER;
            int MOVI= 0;
            int INICIAR = 0;
            int CADENA = 0;
            int LIM = 0;
            Console.Write("Ingrese su nombre: ");
            NOMBRE = Console.ReadLine();
            Console.SetCursorPosition(1, 12); 
            Console.Write(NOMBRE);
            CADENA = NOMBRE.Length;
            LIM = 60;
            NOMBRE = NOMBRE.ToUpper();
            for (INICIAR= NOMBRE.Length; INICIAR >= 1; INICIAR--)
            {
                CARACTER = Mid(NOMBRE, INICIAR - 1, 1);
                for (MOVI = CADENA; MOVI <= LIM; MOVI++)
                {
                    Console.SetCursorPosition(MOVI, 12);
                    Console.Write(" " + CARACTER);
                        Thread.Sleep(50);
                }
                LIM = LIM - 1;
                CADENA = CADENA - 1;
            }
        }
    }
}
        











