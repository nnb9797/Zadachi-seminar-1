using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_к_семинару_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha2()
            {
                //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

                if (args is null)
                {
                    throw new ArgumentNullException(nameof(args));
                }

                Console.WriteLine("Введите целое число А: ");
                int a = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Введите целое число Б: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("Большее число это А=" + Convert.ToString(a));
                    Console.WriteLine("Меньшее число это Б=" + Convert.ToString(b));
                }
                else
                {
                    Console.WriteLine("Большее число это Б=" + Convert.ToString(b));
                    Console.WriteLine("Меньшее число это А=" + Convert.ToString(a));

                }
                    Console.Write("Для продолжения нажмите " + "любую клавишу >");
                    Console.ReadKey();
                }

            void Zadacha4()
            {
                //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

                Console.WriteLine("Введите целое число А: ");
                int arg1 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Введите целое число Б: ");
                int arg2 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Введите целое число В: ");
                int arg3 = Convert.ToInt32(Console.ReadLine());
                
                int max = Math.Max(arg1, Math.Max(arg2, arg3));
                Console.WriteLine("Максимальное число это:" + Convert.ToString(max));
                
                Console.Write("Для продолжения нажмите " + "любую клавишу >");
                Console.ReadKey();
            }
           void Zadacha6()
            {
                //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
               
                int a;
                Console.WriteLine("Введите число:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("Число " + a + " - чётное");
                }
                else
                {
                    Console.WriteLine("Число " + a + " - нечётное");
                }
                Console.ReadKey();
            }
            void Zadacha8()
            {
                //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
                
                Console.WriteLine("Введите цело число: ");
                string a = Console.ReadLine();
                if (int.TryParse(a, out var n))
                {
                    Console.WriteLine("Все четные числа до указанного числа <" + a + ">, включительно:");
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    if ((n == 0) || (n == 1)) Console.Write("Не обнаружены");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, нужно ввести число");
                }
                Console.ReadKey();
            }
            Zadacha8();
            }
        }
    }
