using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace assignment5_2
{
    class codeDBentities:DbContext
    { 
    
        public DbSet<pizzadetail> pizzadetails { get; set; }
        public codeDBentities():base("mypizza")
        {

    }
    }
}
