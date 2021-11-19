using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios31a40
    {
        static void Exe31()
        {
            try
            {
                Console.WriteLine("Escreva um número");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("É Par");
                }
                else
                {

                    Console.WriteLine("É impar");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
        }
        static void Exe32()
        {
            Console.WriteLine("Escreva um número");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if ((num >= 100 && num <= 200) || (num2 >= 100 && num2 <= 200))
            {
                Console.WriteLine("Ao menos um deles esta no intervalo");
            }
            else
            {
                Console.WriteLine("Nenhum deles esta no intervalo");
            }

        }
        static void Exe33()
        {

            Console.WriteLine("Escreva um número");
            int num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                Console.WriteLine(num > 0 ? "numero positivo" : "número negativo ");

            }
            else
            {
                Console.WriteLine("0");
            }
        }
        static void Exe34ValidarEntrada()
        {
            try
            {
                Console.WriteLine("Escreva um ano");
                int ano = DateTime.Parse(Console.ReadLine()).Year;
                DateTime dt = new DateTime();
                Console.WriteLine(ano % 4 == 0 ? "Este ano é bixesto" : "Este ano não é bixesto");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro ao inserir valor");
            }
            finally
            {
                Console.WriteLine("Obrigado por participar");
            }
        }
        static void Exe35()
        {
            Console.WriteLine("Escreva sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(idade >= 16 ? "Esta qualificado" : "Nao esta qualificado");

        }
        static void Exe36()
        {
            Console.WriteLine("Escreva sua altura em centimetros");
            double altura = Double.Parse(Console.ReadLine()) / 100;
            switch (altura)
            {
                case <= 1.40:
                    Console.WriteLine("Anão");
                    break;
                case <= 1.60:
                    Console.WriteLine("Baixo");
                    break;
                case <= 1.80:
                    Console.WriteLine("Alto");
                    break;
                case > 1.80:
                    Console.WriteLine("Gigante");
                    break;
            }
        }
        static void Exe37()
        {
            try
            {
                Console.WriteLine("Escreva um número ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva um número ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva um número ");
                int num3 = int.Parse(Console.ReadLine());



                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine("O maior número é " + num1);
                }
                else if (num2 > num3)
                {
                    Console.WriteLine("O maior número é " + num2);
                }
                else
                {
                    Console.WriteLine("O maior número é " + num3);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Deu erro");
            }
            finally
            {
                Console.WriteLine("Obrigado por usar o programa");
            }
        }

        static void Exe38()
        {
            try
            {
                Random rdm = new Random();
                int num = rdm.Next(1, 10);
                int[] array = new int[num];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Escreva o " + (i + 1) + " do array");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("-------");
                for (int a = 0; a < array.Length; a++)
                {
                    Console.WriteLine(array[a]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erro ao usar o array");
            }
        }

        static void Exe39RefazerSemRandom()
        {
            Random rdm = new Random();
            Console.WriteLine("Quantos numeros deseja ler");
            int num = int.Parse(Console.ReadLine());
            int[] numeros = new int[num];
            for (int i = 0; i < num; i++)
            {
                numeros[i] = rdm.Next(0, 100);
            }
            Console.WriteLine("Lendo os numeros ao contrario ");
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        static void Exe40()
        {

            Console.WriteLine("Escreva um número");
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[numero];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Escreva um numero para o arrray ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int soma = 0;
                foreach (var item in arr)
                {
                    soma += item;
                }
                Console.WriteLine($"A soma dos números do array é {soma}");
            }
            catch (FormatException)
            {

            }
            catch (IndexOutOfRangeException)
            {

            }

        }
    }
}
