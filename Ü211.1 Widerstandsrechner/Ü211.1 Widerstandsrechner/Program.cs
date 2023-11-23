using System;

namespace Ü211._1_Widerstandsrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("***Widerstandrechner***");
            Console.WriteLine("Wollen sie (S)eriellen oder (P)aralellen Gesamtwiderstand berechnen");
            double Widerstand1, Widerstand2, Widerstand3, Seriell, Parallel;
            char berechnung = Console.ReadKey().KeyChar;
             string Antwort = Convert.ToString(Console.ReadKey());



            if (berechnung == 's' || berechnung == 'S')
            {

                do
                {


                    do
                    {


                        Console.Write("Geben Sie bitte den Widerstand1 ein: ");
                        Widerstand1 = Convert.ToDouble(Console.ReadLine());
                        if (Widerstand1 < 0)
                        {
                            Console.WriteLine("Der radius muss größer als 0 sein.");
                        }
                    }
                    while (Widerstand1 < 0);
                    do
                    {
                        Console.Write("Geben Sie bitte den Widerstand2 ein: ");
                        Widerstand2 = Convert.ToDouble(Console.ReadLine());
                        if (Widerstand2 < 0)
                        {
                            Console.WriteLine("Die Breite muss größer als 0 sein.");
                        }
                    }
                    while (Widerstand2 < 0);
                    do
                    {
                        Console.Write("Geben Sie bitte den Widerstand3 ein: ");
                        Widerstand3 = Convert.ToDouble(Console.ReadLine());
                        if (Widerstand3 < 0)
                        {
                            Console.WriteLine("Die Breite muss größer als 0 sein.");
                        }
                    }
                    while (Widerstand3 < 0);
                    Seriell = Widerstand1 + Widerstand2 + Widerstand3;

                    Console.WriteLine("Der serielle Gesamtwiderstand beträgt " + Seriell + "Ohm");



                    if (berechnung == 'p' || berechnung == 'P')
                    {

                        do
                        {

                            Console.Write("Geben Sie bitte den Widerstand1 ein: ");
                            Widerstand1 = Convert.ToDouble(Console.ReadLine());
                            if (Widerstand1 < 0)
                            {
                                Console.WriteLine("Der radius muss größer als 0 sein.");
                            }
                        }

                        while (Widerstand1 < 0);
                        do
                        {
                            Console.Write("Geben Sie bitte den Widerstand2 ein: ");
                            Widerstand2 = Convert.ToDouble(Console.ReadLine());
                            if (Widerstand2 < 0)
                            {
                                Console.WriteLine("Die Breite muss größer als 0 sein.");
                            }
                        }
                        while (Widerstand2 < 0);
                        do
                        {
                            Console.Write("Geben Sie bitte den Widerstand3 ein: ");
                            Widerstand3 = Convert.ToDouble(Console.ReadLine());
                            if (Widerstand3 < 0)
                            {
                                Console.WriteLine("Die Breite muss größer als 0 sein.");
                            }
                        }
                        while (Widerstand3 < 0);
                    }


                    Parallel = 1 / (1 / Widerstand1 + 1 / Widerstand2 + 1 / Widerstand3);

                    Console.WriteLine("Der parallele Gesamtwiderstand beträgt " + Parallel + "Ohm");
                    Console.WriteLine("Möchten Sie eine weitere Widerstandechner durchführen? (ja/nein)");
                } while (Console.ReadLine() == "ja");
         
                    Antwort = Antwort.ToUpper();
             


            }
        }

    }
}
