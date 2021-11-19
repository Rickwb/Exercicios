using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios72a81
    {
        static void Exe72()
        {
            Console.WriteLine("Escreva um número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro numero");
            int num2 = int.Parse(Console.ReadLine());
            int resto = num2 % num1;
            decimal quociente1 = num2 / num1;
            int quociente = (int)Math.Ceiling(quociente1);
            Console.WriteLine("Resto= " + resto + "Quociente= " + quociente);

        }

        static void Exe73Refazer()
        {
            Console.WriteLine("Escreva sua idade em dias");
            int dias = int.Parse(Console.ReadLine());
            DateTime data = DateTime.Now.AddDays(-dias);
            TimeSpan diff = DateTime.Now - data;
            Console.WriteLine();
        }
        static void Exe74()
        {
            Console.WriteLine("Digite a temperatura em fahrenhait");
            double temp = int.Parse(Console.ReadLine());
            double tempCel = (temp - 32) * 5 / 9;
            Console.WriteLine("Temperatura em celsius é " + tempCel);

        }

        static void Exe75(double altura, double raio)
        {
            double volume = altura * Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("O volume é igual a " + volume.ToString("0.00"));
        }
        static void Exe76()
        {
            Console.WriteLine("Escreva suas notas do primiero bimestre");
            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escreva suas notas do segundo bimestre");
            decimal n3 = decimal.Parse(Console.ReadLine());
            decimal n4 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Média" + (n1 + n2 + n3 + n4) / 4);

        }
        static void Exe77()
        {
            Console.WriteLine("Escreva sua velociadade em m/s");
            float vel = float.Parse(Console.ReadLine()) * 3.6f;
            Console.WriteLine("A valocidade em km/h : " + vel.ToString("0.0"));
        }
        static void Exe78()
        {
            Console.WriteLine("Escreva o valor de R1");
            double r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de R3");
            double r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de R2");
            double r3 = double.Parse(Console.ReadLine());
            double rTotal = 1 / (1 / r1 + 1 / r2) + r3;
            Console.WriteLine("A resistencia equivalente é igual a " + rTotal.ToString());
        }
        static void Exe79Refazer()
        {
            Console.WriteLine("Escreva um numero de tres algarismos");
            int num = int.Parse(Console.ReadLine());
            char[] numS = num.ToString().ToCharArray();
            Console.WriteLine(numS[2] + numS[1] + numS[0]);


        }
        static void Exe80()
        {
            Console.WriteLine("Escreva um numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva um numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int variavel = num1;
            num1 = num2;
            num2 = variavel;

            Console.WriteLine(num1 + " " + num2);

        }
        static void Exe81()
        {
            Console.WriteLine("Digite o preço da mercadoria");
            double preco = double.Parse(Console.ReadLine());
            double parcelas = Math.Floor(preco / 3);
            double resto = preco % 3;
            Console.WriteLine("O preço da entrada é de {0} e o preço das parcelas é de {1}", parcelas + resto, parcelas);
        }
    }
}
