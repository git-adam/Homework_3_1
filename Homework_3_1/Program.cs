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
            var presentDate = DateTime.Now;

            Console.Write("Podaj swoje imię: ");
            var name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Podaj swoje miejsce urodzenia: ");
            var city = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Podaj rok swojego urodzenia: ");
            var birthYear = GetYear(presentDate.Year);
            Console.WriteLine();
            Console.Write("Podaj miesiąc swojego urodzenia: ");
            var birthMonth = GetMonth();
            Console.WriteLine();
            Console.Write("Podaj dzień swojego urodzenia: ");
            var birthDay = GetDay(birthYear, birthMonth);
            Console.WriteLine();

            var birthDate = new DateTime(birthYear, birthMonth, birthDay);
            var age = presentDate.Year - birthDate.Year;

            if (birthDate.DayOfYear > presentDate.DayOfYear)
                    age--;

            Console.WriteLine($"Cześć {name}, urodziłeś się w {city} i masz {age} lat");

       
        }
        private static int GetDay(int birthYear, int birthMonth)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day)
                    || day > DateTime.DaysInMonth(birthYear, birthMonth) || day < 1)
                {
                    Console.WriteLine("Wprowadziłeś nieprawidłowe dane, spróbuj ponownie.");
                    continue;
                }

                return day;
            }

        }

        private static int GetMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
                {
                    Console.WriteLine("Wprowadziłeś nieprawidłowe dane, spróbuj ponownie.");
                    continue;
                }

                return month;
            }
        }

        private static int GetYear(int presentYear)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year > presentYear)
                {
                    Console.WriteLine("Wprowadziłeś nieprawidłowe dane, spróbuj ponownie.");
                    continue;
                }

                return year;
            }
        }
    }
}
