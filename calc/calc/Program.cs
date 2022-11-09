using System;
using System.Diagnostics.Contracts;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод первого числа
            Console.WriteLine("Enter a number: ");
            bool cheak = true;
            cheak = double.TryParse(Console.ReadLine(), out double num1);

            //Проверка введённого числа
            if (cheak == false)
            {
                Console.WriteLine("Вы ввели не число!");
                Console.ReadKey();
                return;
            }

            //ввод второго числа
            Console.WriteLine("Enter another number: ");
            cheak = double.TryParse(Console.ReadLine(), out double num2);

            //Проверка введённого числа
            if (cheak == false)
            {
                Console.WriteLine("Вы ввели не число!");
                Console.ReadKey();
                return;
            }

            //ввод операции
            Console.WriteLine("Enter operation(+, -, *, /, >, <)");
            string conv = Console.ReadLine();


            //Валидация входящих парамтеров
            if (conv != "+" && conv != "-" && conv != "*" && conv != "/" && conv != ">" && conv != "<")
            {
                Console.WriteLine("Вы ввели неправильный знак!");
                Console.ReadKey();
                return;
            }

            //выполнение операций
            if (conv.Equals("+")) //сложение
            {
                Console.Write(num1 + num2);
            }
            else if (conv.Equals("-")) //вычитание
            {
                Console.Write(num1 - num2);
            }
            else if (conv.Equals("*")) //умножение
            {
                Console.Write(num1 * num2);
            }
            else if (conv.Equals("/")) //деление
            {
                Console.Write(num1 / num2);
            }
            else if (conv.Equals(">")) //найти наибольшее число
            {
                if (num1 > num2)

                {
                    Console.Write(num1);
                }

                else
                {
                    Console.Write(num2);
                }
            }

            else if (conv.Equals("<")) //найти наименьшее число
            {
                if (num1 < num2)

                {
                    Console.Write(num1);
                }

                else
                {
                    Console.Write(num2);
                }
            }
            else
            {
                Console.Write("Invalid operation");
            }

            Console.ReadLine();
        }
    }
}