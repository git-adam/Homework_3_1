using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;// UTF8

            Console.Write("Podaj swoje imię: ");
            var name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Podaj swoje miejsce urodzenia: ");
            var city = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Podaj rok swojego urodzenia: ");
            var birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Podaj miesiąc swojego urodzenia: ");
            var birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Podaj dzień swojego urodzenia: ");
            var birthDay = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var birthDate = new DateTime(birthYear, birthMonth, birthDay);
            var presentDate = DateTime.Now;
            var age = 0;

            if (DateTime.Compare(birthDate, presentDate) < 0 )
            {
                if (birthDate.DayOfYear > presentDate.DayOfYear)
                    age = presentDate.Year - birthDate.Year - 1;
                else
                    age = presentDate.Year - birthDate.Year;

                Console.WriteLine($"Cześć {name}, urodziłeś się w {city} i masz {age} lat");
            }
            else if (DateTime.Compare(birthDate, presentDate) == 0)
            {
                Console.WriteLine($"Cześć {name}, urodziłeś się w {city} i masz {age} lat");
            }
            else
            {
                if (birthDate.DayOfYear > presentDate.DayOfYear)
                    age = presentDate.Year - birthDate.Year;
                else
                    age = presentDate.Year - birthDate.Year - 1;
                Console.WriteLine($"Cześć nie nazywasz się {name}, nie urodziłeś się w {city} i nie masz {age} lat");
            }       
        }
    }
}
