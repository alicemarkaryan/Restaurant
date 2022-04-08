using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class MyCaffee
    {
        public List<DruidClab> context1;
        public MyCaffee()
        {
            context1 = new List<DruidClab>();
            context1.Add(new DruidClab { Name="Pizza",  Id=1,   Price=3400});
            context1.Add(new DruidClab { Name = "Cofe", Id = 2, Price = 1400 });
            context1.Add(new DruidClab { Name = "Lunch", Id = 3, Price = 5400 });
           
         }
    }
}
