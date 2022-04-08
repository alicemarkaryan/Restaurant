using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class MyRes : Methods
    {
        public MyCaffee context;
        public void AddMenu(int Id, DruidClab d)
        {
            foreach (var item in context.context1)
            {
                if (item.Id == Id)
                {
                    throw new Exception("Invalid error");
                }
            }
            context.context1.Add(d);
        }

        public void DeleteMenu(int Id)
        {
           foreach(var item in context.context1)
            {
                if (item.Id == Id)
                {
                    context.context1.RemoveAt(Id);
                }
            }

        }

        public DruidClab GetMenu(int Id, DruidClab d)
        {
            foreach (var item in context.context1)
            {
                if (item.Id == Id)
                {
                    return d;
                }
                
            }
            return null;


        }


        public void RefOut(int CountFood, int KgFood, ref int sum1,ref int sum2 )
        {
            sum1 = CountFood * KgFood;
            sum2 = CountFood * KgFood+KgFood;
            
        }



       
    }
}
