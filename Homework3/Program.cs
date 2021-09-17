using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = -1;
            int score = 0;


            while (true)
            {

                number = GetNumber();


                if (number >= 1 && number % 2 == 1)
                {
                    score = score + number;
                }


                if (number == 0) break;
            }


            Console.Clear();
            Console.WriteLine($"Сумма нечетных, положителных чисел = {score}");
            Console.ReadKey();



            Console.Clear();
            Complex a1 = new Complex(5, 5);
            Complex a2 = new Complex(2, 2);

            Complex a3 = a1.Minus(a2);
            Complex a4 = a1.Multi(a2);


            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());


            Console.WriteLine(a3.ToString());

            Console.WriteLine(a4.ToString());


            Console.ReadKey();
        }


        static int GetNumber()
        {

            int newNumber = 0;
            bool flag = false;


            while (!flag)
            {
                Console.Write("Введите число: ");


                try
                {
                    newNumber = Convert.ToInt32(Console.ReadLine());
                    if (newNumber >= 0 || newNumber <= 0) flag = true;

                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            if (newNumber == 0) Console.WriteLine($"Введен {newNumber}. Выход из цикла");

            else Console.WriteLine($"Введенное число: {newNumber}");

            return newNumber;
        }

        struct Complex
        {

            double im;
            double re;

            public Complex(double IM, double RE)
            {
                this.im = IM;
                this.re = RE;
            }


            public Complex Plus(Complex comp)
            {
                Complex param;
                param.im = this.im + comp.im;
                param.re = this.re + comp.re;
                return param;
            }


            public Complex Minus(Complex comp)
            {
                Complex param;
                param.im = this.im - comp.im;
                param.re = this.re - comp.re;
                return param;
            }


            public Complex Multi(Complex comp)
            {
                Complex param;
                param.im = this.re * comp.im + this.im * comp.re;
                param.re = this.re * comp.re - this.im * comp.im;
                return param;
            }


            public string ToString()
            {
                return $"{re} + {im}i";
            }
        }
    }
}
