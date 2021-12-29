using System;
using System.Collections.Generic;

namespace ifSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            if (num < 5)
            {
                Console.WriteLine("Hello!");
            }
            else
            {
                Console.WriteLine("GoodBye!");
            }


            if (num < 5 && num > 0)
            {
                Console.WriteLine("Num>0");
            }
            else
            {
                Console.WriteLine("Num<0");
            }

            // && and , || or , ! not


            int input = int.Parse(Console.ReadLine());

            string sw = input == 10 ? "да" : "нет";



            switch (input)  //switch case
            {
                case 1: Console.WriteLine("gachimuchi"); break;
                case 2: Console.WriteLine("van darkholme"); break;
                case 3: Console.WriteLine("billy harington"); break;
                case 4: Console.WriteLine("ricardo milos"); break;
                default:
                    break;
            }


            string s = "Привет";
            if (s.Equals("привет", StringComparison.CurrentCultureIgnoreCase))//сравнивать строку с аргументами, игнор кейса
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

            Console.WriteLine(sw);



            var list = new List<string>();
            var rnd = new Random();


            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0,100).ToString());
            }

            foreach (var item in list)
            {
                Console.Write(item+" ");
            }

        }
    }
}
