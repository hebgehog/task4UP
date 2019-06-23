using System;

namespace task4UP
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum, i, e = 0, sl;
            Console.WriteLine("Введите точность e > 0 : ");
            while (e <= 0){
                e = wwww();
                if (e > 0)
                {
                    sum = 0;
                    i = 1;
                    sl = 1 / (Math.Pow(4, i) + Math.Pow(5, i + 2));
                    while (Math.Abs(sl) > e){
                        sum += sl;
                        i++;
                        sl = 1 / (Math.Pow(4, i) + Math.Pow(5, i + 2));
                    }
                    Console.WriteLine("Сумма ряда = " + sum);
                }
                else{Console.WriteLine("Введите e больше нуля!");}
            }
            Console.ReadKey();
        }
        static double wwww()
        {
            while (true){
                double number;
                if (double.TryParse(Console.ReadLine(), out number))
                    return number;
                else
                    Console.WriteLine("Ошибка, введите еще раз");
            }
        }
    }
}