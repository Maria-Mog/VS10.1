using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS10._1
{
    class Program
    {
        // Считаем, что угол не больше 360град., в противном случае нужно убрать ограничения расчета радиан. 
        // Вопрос: Как сделать прерывание программы, если вводится отрицательное значение мин. или сек. (при вводе положительного значения угла и отр-го зан. мин./сек. программа расчитает радианы)
        static void Main(string[] args)
        {
            Console.Write("Ввелите ед.измерения угла\n - градусы = ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("- минуты = ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("- секунды = ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec);
            angle.ToRadians();
            Console.ReadKey();
        }
        class Angle
        {
            private int gradus;
            private int min;
            private int sec;

            public int Gradus
            {

                get
                {
                    return gradus;
                }
                set
                {
                    if (value >= 0)
                    {
                        gradus = value;
                    }

                    else
                    {
                        Console.WriteLine("Введите положительное значение");                       
                    }                    
                }
            }
            public int Min
            {
                get
                {
                    return min;
                }
                set
                {
                    if (value >= 0)
                    {
                        min = value;
                    }

                    else
                    {
                        Console.WriteLine("Введите положительное значение");
                    }
                    
                }

            }
            public int Sec
            {
                get
                {
                    return sec;
                }
                set
                {
                    if (value >= 0)
                    {
                        sec = value;
                    }

                    else
                    {
                        Console.WriteLine("Введите положительное значение");
                    }
                    
                }

            }
            public Angle(int gradus, int min, int sec)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;
            }

            public void ToRadians()
            {
                double radians = (Gradus + Min / 60 + Sec / 3600) * (Math.PI) / 180;
                if (radians >= 0 && radians < 6.2832)
                {
                    Console.WriteLine("Угол равен {0:0.0000} радиан", radians);
                }
                else
                {
                    Console.WriteLine("Введенные значения превышают допустимые");
                }

            }
        }
    }
}
