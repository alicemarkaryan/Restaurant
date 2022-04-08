using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal interface Methods
    {
        DruidClab GetMenu(int Id,DruidClab d);
        
        void AddMenu(int Id, DruidClab d);

        void DeleteMenu(int Id);


    }
}
