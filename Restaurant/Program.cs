using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Program
    {
        delegate int delg(int count);
        public class CountDelegate
        {
             delg CountDel;
            public static int Func1(int count)
            {
                if (count > 100)
                {
                    return count;
                }
                else
                {
                    return 100;
                }
            }



            static void Main(string[] args)
            {

                MyRes m = new MyRes();
                int Count = 10; int FoodKg = 1020;
                int sum1 = 0; int sum2 = 0;
                m.RefOut(Count, FoodKg, ref sum1, ref sum2);
                Console.WriteLine("We need this kg and count of food for 1 restoran "
                    +sum1 + "kg and for 2nd " + sum2+"kg");

                //Delegate

                CountDelegate count = new CountDelegate();

                count.CountDel = new delg(Func1);
                Console.WriteLine("Count of food is "+count.CountDel(120));

                MyCaffee my = new MyCaffee();
                
                    Console.WriteLine(my);
                Console.Write("Menu is => ");

                foreach(var item in my.context1)
                {
                    Console.WriteLine("Name: "+item.Name+" Id: "+item.Id+" price: "+item.Price);
                }
                

            }
        }
    }
}
