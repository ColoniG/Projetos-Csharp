using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x;    // De float para double é automático  (conversão implicita)

            double v;
            float w;

            v = 5.1;
            w = (float)v;   // Para converter de flooat para double  (Casting conversão explicita)

            int z;
            z = (int)v;

            int d = 5;
            int e = 2;

            double f = (double)d / e;
            Console.WriteLine("          Início >>>");
            Console.WriteLine(y);
            Console.WriteLine(w);
            Console.WriteLine(z);
            Console.WriteLine(f);

            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine("Formula de Baskara");
                        
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - (4 * a * c);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("O valor de delta é {0:F2}.", delta);
            Console.WriteLine("As duas raizes da equação são " + x1 + " e " + x2 + "!");
            Console.WriteLine($"Delta {delta:F2}, raiz 1 --> {x1:F2} e raiz 2 --> {x2:F2}!");
            Console.WriteLine();



            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine(" Digite uma frase! \n x\n y\n z\n a  b  c");
            string frase3 = Console.ReadLine();
            string x3 = Console.ReadLine();
            string y3 = Console.ReadLine();
            string z3 = Console.ReadLine();


            string []vet = Console.ReadLine().Split(' ');
            string a3 = vet[0];
            string b3 = vet[1];
            string c3 = vet[2];

            
            Console.WriteLine();
            Console.WriteLine($" Você digitou:\n {frase3}\n {x3}\n {y3}\n {z3}\n   {a3}\n     {b3}\n        {c3}");
            Console.WriteLine();
        }
    }
}