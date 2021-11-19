using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios41a50
    {
        static double[] FormarArray(bool isDouble)
        {
            double[] arr;
            try
            {
                Console.WriteLine("Escreva o tamanho do array");
                int tamanho = Convert.ToInt32(Console.ReadLine());
                arr = new double[tamanho];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                }
                return arr;
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
        static int[] FormarArray()
        {
            int[] arr;
            try
            {
                Console.WriteLine("Escreva o tamanho do array");
                int tamanho = Convert.ToInt32(Console.ReadLine());
                arr = new int[tamanho];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                return arr;
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
            catch (ArgumentException)
            {
                return null;
            }

        }

        static void Exe41()
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
                int[] arr2 = new int[arr.Length];
                int n = 0;
                foreach (var item in arr)
                {
                    arr2[n] = item;
                    n++;
                }
                foreach (var item in arr2)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                throw new SystemException("Invalid operation ");
            }
        }

        static void Exe42Refazer()
        {
            int[] arr = FormarArray();
            int[] arrDuplicados = new int[arr.Length];
            int contagem = 0;
            for (int i = 0; i < arr.Length; i++)
            {




            }
            Console.WriteLine("Contagem de repertidos: " + contagem);
        }

        static void Exe43Refazer()
        {
            int[] arr = FormarArray();
            int[] distintos = arr.Distinct().ToArray();
            Console.WriteLine("Elementos distintos");
            foreach (var item in distintos)
            {
                Console.WriteLine(item);
            }

        }

        static void Exe44()
        {
            int[] arr = FormarArray();
            Console.WriteLine("-----");
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
        }

        static void Exe45()
        {
            try
            {

                int[] arr = FormarArray();
                int[] arrPares = arr.Where(x => x % 2 == 0).ToArray();
                int[] arrImpares = arr.Where(x => x % 2 == 1).ToArray();

                Console.WriteLine("Números pares");
                foreach (var item in arrPares)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Números Impares");
                foreach (var item in arrImpares)
                {
                    Console.WriteLine(item);
                }
            }
            catch (FormatException e)
            {

                Console.WriteLine("Parar programa");
            }
        }

        static void Exe46()
        {
            Console.WriteLine(DateTime.Today);
        }
        static void Exe47()
        {
            try
            {
                Console.WriteLine("Escreva uma data");
                DateTime data1 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Escreva uma data");
                DateTime data2 = DateTime.Parse(Console.ReadLine());

                if (data1 == data2)
                    Console.WriteLine("As datas são iguais ");
                else
                    Console.WriteLine("As datas são diferentes");
            }
            finally
            {
            }
        }
        static void Exe48()
        {
            try
            {

                Console.WriteLine("Escreva o mes e ano no formato MM/yy");
                IFormatProvider provider = new CultureInfo("pt-BR");
                DateTime mesAno = DateTime.ParseExact(Console.ReadLine(), "MM/yy", provider);


                Console.WriteLine(DateTime.DaysInMonth(mesAno.Year, mesAno.Month));
            }
            catch (FormatException)
            {

                throw;
            }
        }

        static void Exe49()
        {
            Console.WriteLine(String.Format("O dia de amanha sera o dia {0}", DateTime.Today.AddDays(1)));
        }

        static void Exe50()
        {
            DateTime dia40 = DateTime.Today.AddDays(40);
            Console.WriteLine(dia40.DayOfWeek);
        }
    }
}
