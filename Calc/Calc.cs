using System;

namespace Calc
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.Write("Введіть перше число: ");
            string input1 = Console.ReadLine();
            
            Console.Write("Введіть друге число: ");
            string input2 = Console.ReadLine();
            
            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double sum = number1 + number2;
                Console.WriteLine($"Сума {number1} і {number2} дорівнює: {sum}");
            }
            else
            {
                Console.WriteLine("Некоректний ввід. Будь ласка, введіть числа коректно.");
            }

            Console.ReadKey();
        }
    }
}