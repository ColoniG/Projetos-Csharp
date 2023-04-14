using System;
using System.Globalization;

namespace CourseDataInput 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um Caracter:");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número com ponto flutuante:");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um 'Nome', um 'Caracter', 'Idade' e 'Altura' (Separados por um espaço)");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]); 
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();
            Console.WriteLine("<<  Desafio  >>");
            Console.WriteLine();

            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa:");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');
            double alt = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(alt.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
