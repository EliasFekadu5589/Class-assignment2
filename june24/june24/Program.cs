using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace june24
{
    class student
    {
        public int id;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            student su = new student();
            su.id = 20;
            student su2 = su;
            su2.id = 30;
            Console.WriteLine(su.id);
            Console.WriteLine(su2.id);

            string name = Console.ReadLine();
            int id = int.Parse("11");
            */

            bool again = false;
            int answer = 0;

            Check obj = new Check();

            obj.ask();
            
            do
            {
                Console.WriteLine("Do you want to input again? ___ (0 for Yes, other for no) -> ");
                answer = Convert.ToInt32(Console.ReadLine());
                if(answer == 0)
                {
                    obj.ask();
                }
            }while (answer == 0);
            Console.ReadKey();


        }

        class Check
        {
            public void ask()
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (age <= 0 || age >= 100)
                    {
                        Console.WriteLine("Wrong input! please enter again");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                } while (age <= 0 || age >= 100);
                Console.WriteLine("ur age is: " + age);
            }
        }
    }
}
