using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            pizzadetail e1 = new pizzadetail { pizzaname = "AAA Pizza", type = "NonVeg", toppings = "Onion", size = 'L', price = 900 };
            pizzadetail e2 = new pizzadetail { pizzaname = "Chicken Pizza", type = "NonVeg", toppings = "Chicken", size = 'M', price = 800 };
            codeDBentities db = new codeDBentities();
            db.pizzadetails.Add(e1);
            db.pizzadetails.Add(e2);
            var reult = db.SaveChanges();
            if (reult > 0)
                Console.WriteLine("Data Inserted.");



        }
    }
}
