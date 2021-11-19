using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios11a20
    {
        static void Exe11()
        {
            Console.WriteLine("Escreva algo");
            string input1 = Console.ReadLine();
            Console.WriteLine("Escreva algo denovo");
            string input2 = Console.ReadLine();

            Console.WriteLine(input1 + " " + input2);

        }

        static void Exe12()
        {
            try
            {
                Console.WriteLine("Escreva algo");
                string input = Console.ReadLine();

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.Write(input[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erro no input ");
            }

        }

        static void Exe13()
        {
            try
            {
                Console.WriteLine("Escreva algo");
                string input = Console.ReadLine();

                input = input.Remove(input.Length - 5);
                Console.WriteLine(input);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erro no input ");
            }
        }

        static void Exe14()
        {
            try
            {
                Console.WriteLine("Escreva algo");
                string input = Console.ReadLine();

                input = input.Replace('a', 'b');
                Console.WriteLine(input);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Erro no input ");
            }
        }

        static void Exe15Duvida()
        {
            try
            {
                Console.WriteLine("Escreva algo");
                string input = Console.ReadLine();
                input = input.Replace(" ", ",");
                string[] palavras = input.Split(","); ;
                Console.WriteLine(palavras[0]);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Erro no input ");
            }
        }
        static void Exe16()
        {
            try
            {
                Console.WriteLine("Escreva algo");
                string input = Console.ReadLine();
                input = input.TrimEnd().TrimStart();
                Console.WriteLine(input);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Erro no input ");
            }
        }

        static void Exe17Refazer()
        {
            try
            {
                Console.WriteLine("Escreva algo");
                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length - 1; j++)
                    {
                        if (i != j)
                        {
                            if (input[i] == input[j])
                            {
                                input.Replace(input[i], ' ');
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine(input);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Erro no input ");
            }
        }

        static void Exe18()
        {
            try
            {
                Console.WriteLine("Escreva uma frase ");
                string frase = Console.ReadLine();
                frase = System.Text.RegularExpressions.Regex.Replace(frase, "[aeiouAEIOU]", "");
                Console.WriteLine(frase);

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro");
            }
        }
        static void Exe19()
        {
            Console.WriteLine("Escreva o que quiser");
            string palavras = Console.ReadLine();
            string[] arrayPalavras = palavras.Split(' ');
            Console.WriteLine(arrayPalavras.Length + " total de palavras");
        }
        static void Exe20()
        {
            Console.WriteLine("Escreva o que quiser e te digo se começa com C#");
            string palavras = Console.ReadLine();

            Console.WriteLine(palavras.StartsWith("C#") || palavras.StartsWith("c#") ? "SIM" : "NÃO");
        }
    }
}
