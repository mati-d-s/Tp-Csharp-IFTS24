﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declara variables
            bool varBoolean; //Alias Boolean
            int varInt; //Alias Int32
            double varDouble; //Alias Double
            string varString; //Alias String
            DateTime varDateTime; //Alias DateTime


            //Asigna un nuevo valor a cada variable.
            varBoolean = true;
            varInt = 2147483647;
            varDouble = 13.78;
            varString = @"Abcdefghijklmnopqrstwxyz 1234567890 @ ' ¡ ! ? ¿ $ % & # / \ ( )";
            varDateTime = DateTime.Now; //Asigna la fecha y la hora actual

            Console.WriteLine("Variables y tipos de datos");
            Console.WriteLine();

            //Muestra el valor de la variable
            Console.WriteLine("Boolean = {0}", varBoolean);
            Console.WriteLine();

            Console.WriteLine("Int = {0}", varInt);
            Console.WriteLine("Double = {0}", varDouble);
            Console.WriteLine();

            Console.WriteLine("String = {0}", varString);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Pulse una tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); //Borra la consola

            Console.WriteLine("DateTime");
            Console.WriteLine();

            Console.WriteLine("DateTime = {0}", varDateTime);
            Console.WriteLine();

            //Muestra algunas de las propiedades disponibles en el tipo DateTime
            Console.WriteLine("DateTime.Date = {0}", varDateTime.Date);
            Console.WriteLine("DateTime.Day = {0}", varDateTime.Day);
            Console.WriteLine("DateTime.DayOfWeek = {0}", varDateTime.DayOfWeek);
            Console.WriteLine("DateTime.DayOfYear = {0}", varDateTime.DayOfYear);
            Console.WriteLine("DayTime.Month = {0}", varDateTime.Month);
            Console.WriteLine("DayTime.Year = {0}", varDateTime.Year);
            Console.WriteLine();

            Console.WriteLine("DateTime.TimeOfDay = {0}", varDateTime.TimeOfDay);
            Console.WriteLine("DateTime.Hour = {0}", varDateTime.Hour);
            Console.WriteLine("DateTime.Minute = {0}", varDateTime.Minute);
            Console.WriteLine("DateTime.Second = {0}", varDateTime.Second);
            Console.WriteLine("DateTime.Milisecond = {0}", varDateTime.Millisecond);
            Console.WriteLine("DateTime.Ticks = {0}", varDateTime.Ticks);
            Console.WriteLine("DateTime.Kind = {0}", varDateTime.Kind);

            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();

            Console.Clear();

        }
    }
}