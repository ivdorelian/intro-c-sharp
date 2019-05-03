using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class Program
    {
        static void ChangeReferenceFieldByValue(Pisica pParam)
        {
            pParam.Nume = "modificat";
        }
        static void ChangeReferenceByValue(Pisica pParam)
        {
            // Transmitere de referinta prin valoare
            pParam = new Pisica { Nume = "modificat" };
        }
        static void ChangeReferenceByReference(ref Pisica pParam)
        {
            // Transmitere de referinta prin referinta
            pParam = new Pisica { Nume = "modificat" };
        }
        static void ChangeValueFieldByValue(Caine cParam)
        {
            cParam.Nume = "modificat";
        }
        static void ChangeValueByValue(Caine cParam)
        {
            cParam = new Caine { Nume = "modificat" };
        }
        static void ChangeValueByReference(ref Caine cParam)
        {
            cParam = new Caine { Nume = "modificat" };
        }
        static void Main(string[] args)
        {
            //Pisica p1 = new Pisica { Nume = "fifi" };
            //ChangeReferenceFieldByValue(p1);
            //Console.WriteLine(p1.Nume);

            //Pisica p2 = new Pisica { Nume = "fifi" };
            //ChangeReferenceByValue(p2);
            //Console.WriteLine(p2.Nume);

            //Pisica p3 = new Pisica { Nume = "fifi" };
            //ChangeReferen ceByReference(ref p3);
            //Console.WriteLine(p3.Nume);

            //Caine c1 = new Caine { Nume = "rex" };
            //ChangeValueFieldByValue(c1);
            //Console.WriteLine(c1.Nume);

            //Caine c2 = new Caine { Nume = "rex" };
            //ChangeValueByValue(c2);
            //Console.WriteLine(c2.Nume);

            Caine c3 = new Caine { Nume = "rex" };
            ChangeValueByReference(ref c3);
            Console.WriteLine(c3.Nume);

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (var i = 1; i <= n; ++i)
            //{
            //    Console.WriteLine(i);
            //}

            //string nume = Console.ReadLine();
            ////Pisica p = new Pisica(nume);
            //Pisica p = new Pisica { Nume = nume };
            ////Console.WriteLine("Numele pisicii este " + p.Nume);
            //Console.WriteLine($"Numele pisicii este {p.Nume}");


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
