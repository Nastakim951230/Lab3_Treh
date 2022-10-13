using System;

namespace Lab3 
{
  
    internal class Program
    {
        double mycos(double x)
        {
            double eps = 0.00000001;
            double s, an;
            int n;
            n = 0;
            an = 1;
            s = 0;
            while (Math.Abs(an) > eps)
            {
                s += an;
                n++;
                an *= -x * x / (2* n - 1.0) / (2.0 * n);
            }
            return s;
        }
        double mysin(double x)
        {
            double eps = 0.00000001;
            double s, an;
            int n;
            n = 1;
            an = x;
            s = 0;
            while (Math.Abs(an) > eps)
            {
                s += an;
                n++;
                an *= -x * x / (2* n - 1.0) / (2.0 * n - 2.0);
            }
            return s;
        }
        static void Main()
        {
            Console.Write("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите погрешность:");
            double eps= Convert.ToDouble(Console.ReadLine());
            //double eps = 5.5511151231* Math.Pow(10,-16);


            //Cos
            double s, an;
            int n;
            n = 0;
            an = 1;
            s = 0;
            while (Math.Abs(an) > eps)
            {
                s += an;
                n++;
                an *= -x * x / (2 * n - 1.0) / (2.0 * n);
            }

            double cos = s;

           //Sin
            n = 1;
            an = x;
            s = 0;
            while (Math.Abs(an) > eps)
            {
                s += an;
                n++;
                an *= -x * x / (2 * n - 1.0) / (2.0 * n - 2.0);
            }
           
            double sin = s;

            Console.WriteLine("Sin: {0}  Cos {1}", Math.Sin(x), Math.Cos(x));

            Console.WriteLine("Sin: {0}  Cos {1}", sin, cos);

        }
    }
}
//x = x / 180 * math.pi
//    # для проверки выведем результат, который посчитает компьютер
//    print(str(math.sin(x)) + " — результат вычислений встроенного синуса")

//    # сразу берём x как первое слагаемое ряда Тейлора
//q = x
//    # сумма ряда на старте равна нулю
//    s = 0
//    # порядковый номер слагаемого в ряду Тейлора
//    i = 1

//    # пока очередное слагаемое больше погрешности — цикл работает
//while abs(q) > n:
//        # добавляем слагаемое к общей сумме
//        s = s + q
//        # вычисляем следующее слагаемое
//        q = q * (-1) * (x * x) / ((2 * i + 1) * (2 * i))
//        # увеличиваем порядковый номер слагаемого в ряду Тейлора
//        i = i + 1
//    # возвращаем сумму как результат работы функции
//    return s