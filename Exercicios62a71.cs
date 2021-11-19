using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios62a71
    {
        static void Exe64()
        {
            Console.WriteLine("Escreva o caminho do arquivo");
            string caminho = Console.ReadLine();
            string line = File.ReadLines(caminho).Last();
            Console.WriteLine(line);
        }
        static void Exe66()
        {
            Console.WriteLine("Escreva o caminho do arquivo");
            string caminho = Console.ReadLine();
            int qtd = File.ReadLines(caminho).Count();
            Console.WriteLine($"Quantidade de linhas do arquivo é ={qtd}");
        }
        static void Exe67(double altura, double largura)
        {
            double area = altura * largura;
            double perimetro = altura * 2 + largura * 2;
            Console.WriteLine(String.Format("O retangulo de altura {0} e largura {1} tem area {2} e perimetro {3}", altura, largura, area, perimetro));

        }
        static void Exe68(double lado)
        {
            double area = Math.Pow(lado, 2);
            double perimetro = 4 * lado;
            Console.WriteLine(String.Format("O quadrado de lado {0} tem area {1} e perimetro {2}", lado, area, perimetro));
        }
        static void Exe69(double raio)
        {
            double area = Math.PI * Math.Pow(raio, 2);
            double perimetro = 2 * Math.PI * raio;
            Console.WriteLine(String.Format("O circulo de raio {0} tem area {1} e perimetro {2}", raio, area, perimetro));

        }

        static void Exe70(double l1, double l2, double l3)
        {
            Console.WriteLine("O perimetro do triangulo é igual a " + (l1 + l2 + l3));
        }

        static void Exe71()
        {
            Console.WriteLine("Escreva um numero e te direi o sucessor");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero + 1);
        }
    }
}
