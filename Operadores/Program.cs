using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int Var1 = 10;
            int Var2 = 100;
            bool Var3 = true;
            bool Var4 = false;
            int varResultado = 0;

            Console.WriteLine("Operadores Aritméticos");
            Console.WriteLine();

            Console.WriteLine("var1 = {0}", Var1);
            Console.WriteLine("var2 = {0}", Var2);
            Console.WriteLine();

            Console.WriteLine("var1 + var2 = {0}", Var1 + Var2);
            Console.WriteLine("var1 - var2 = {0}", Var1 - Var2);
            Console.WriteLine("var1 * var2 = {0}", Var1 * Var2);
            Console.WriteLine("var1 / var2 = {0}", Var1 / Var2);
            Console.WriteLine("var1 % var2 = {0}", Var1 % Var2); //resto de la división
            Console.WriteLine();

            //Incrementos
            Var1 = Var1 + 1;
            Console.WriteLine("var1 = var1 + 1 = {0}", Var1);

            Var1++; //Equivale a la expresion anterior
            Console.WriteLine("var1++ = {0}", Var1);

            Var1 += 10; //Equivale a var1 = var1 + 10
            Console.WriteLine("var1 += 10 = {0}", Var1);

            Console.WriteLine();

            varResultado = Var1++; //Se asigna var1 a varResultado y luego se incrementa var1
            Console.WriteLine("varResultado = var1++; varResultado = {0}", varResultado);

            varResultado = ++Var1; //Se incrementa var1 en 1 y se asigna a varResultado
            Console.WriteLine("varResultado = ++var1; varResultado = {0}", varResultado);

            Console.WriteLine();
            Console.Write("Pulse una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Operadores relaciones");
            Console.WriteLine();

            Var1 = 20; //Asigno otros valores a las variables
            Var2 = 30;


        }
    }
}