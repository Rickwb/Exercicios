using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicios1a10cs
    {
        static void Exe1()
        {
            Console.WriteLine("Escreva um valor");
            int i;
            try
            {
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine("Digito foi escrito");
                }
                else
                {
                    Console.WriteLine("Não é um digito");
                }
            }
            catch (ArgumentException e)
            {

            }
        }
        static void Exe2()
        {
            Console.WriteLine("Escreva um digito");
            char letra = Console.ReadLine()[0];
            Console.WriteLine(letra != null ? letra : "Valor nulo");
        }

        static void Exe3()
        {
            Console.WriteLine("Escreva um digito");
            try
            {
                int? num = int.Parse(Console.ReadLine());
                if (num != null)
                {
                    char codigo = (char)num;
                    Console.WriteLine(codigo);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Erro encontrado");
            }

        }

        static void Exe4()
        {
            try
            {
                Console.WriteLine("Escreva um caracter");
                char caracter = Console.ReadLine()[0];

                Console.WriteLine(char.ToUpper(caracter) == caracter ? $"O caracter {caracter} é minusculo" : $"O caracter {caracter} não é minusculo");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Erro de valor nulo");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Erro de valor nulo");
            }

        }

        static void Exe5()
        {
            Console.WriteLine("Escreva um caracter");
            char caracter = Console.ReadLine()[0];

            Console.WriteLine(char.ToLower(caracter) == caracter ? $"O caracter {caracter} é minusculo" : $"O caracter {caracter} não é minusculo");
        }

        static void Exe6()
        {
            try
            {
                Console.WriteLine("Escreva um caracter");
                char caract = Console.ReadLine().ToLower()[0];
                Console.WriteLine(caract);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro no programa, refazer");
            }

        }

        static void Exe7()
        {
            try
            {
                Console.WriteLine("Escreva um caracter");
                char caract = Console.ReadLine().ToUpper()[0];
                Console.WriteLine(caract);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro no programa, refazer");
            }
        }

        static void Exe8()
        {
            try
            {
                Console.WriteLine("Digite um número");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro ao inserir valor");
            }
        }

        public  void Exe9e10(string Tamanho)
        {
            try
            {
                if (Tamanho.ToLower() == "minusculo")
                {
                    Console.WriteLine("Escreva uma frase");
                    string input = Console.ReadLine().ToUpper();
                    Console.WriteLine(input);

                }
                else if (Tamanho.ToLower() == "maiusculo")
                {
                    Console.WriteLine("Escreva uma frase");
                    string input = Console.ReadLine().ToUpper();
                    Console.WriteLine(input);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro no programa, refazer");
            }
        }
    }
}
