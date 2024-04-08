using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой день недели? (1-7)");
            int Day = Convert.ToInt32(Console.ReadLine());
            if (Day > 0 && Day <= 7)
            {
                Console.WriteLine("Какое время? (hh;mm)");
                string Time = Console.ReadLine().Trim();

                if (Time.IndexOf(';') == 2 && Time.Length == 5)
                {
                    if(Convert.ToInt32((Time.Substring(3)))<60 && Convert.ToInt32((Time.Substring(3))) >= 0)
                    {
                        Console.WriteLine($"Сейчас: {Enum.GetName(typeof(Weekday), Day)} {TimeHH(Convert.ToInt32((Time.Substring(0, 2))))}");
                    }
                    
                }
                else { Console.WriteLine("Неправильный формат времени"); }
            }
            else { Console.WriteLine("Такого дня недели нет"); }


            /*int delimiterIndex = Time.IndexOf(';');
            Console.WriteLine(delimiterIndex);

            Console.WriteLine(Convert.ToInt32((Time.Substring(0,2))));


            Console.WriteLine(Convert.ToString(TimeDay.Night));
            string ds = Enum.GetName(typeof(Weekday), 12);
            Console.WriteLine(Weekday.Thursday + " " + ds);*/
            Console.Read();

        






        }

        static string TimeHH(int Hh)
        {
            if (Hh >= 0)
            {
                if (Hh <= (int)TimeDay.Night) {return Convert.ToString(TimeDay.Night); }
                else if (Hh <= (int)TimeDay.Morning) {return Enum.GetName(typeof(TimeDay), 12); }
                else if (Hh <= (int)TimeDay.Afternoon) {return Enum.GetName(typeof(TimeDay), 18); }
                else if (Hh <= (int)TimeDay.Evening) {return Enum.GetName(typeof(TimeDay), 23); }
                else { return " Такого времени не существет"; }
            }
            else { return " Такого времени не существет"; }



        }

        enum Weekday
        {
            Monday = 1,
            Tuesday,
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum TimeDay
        {
            Morning = 12,
            Afternoon = 18,
            Evening = 23,
            Night = 6
        }
    }
}
