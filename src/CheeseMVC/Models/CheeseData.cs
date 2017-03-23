using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {

        static private List<Cheese> cheeses = new List<Cheese>();
        
        //getall
       public static List<Cheese> GetAll()
        {
            return cheeses;

        }

        public static void Add(Cheese newCheese)
        {
            cheeses.Add(newCheese);
        }

        // remove

        public static void Remove(int id)
        {
            Cheese cheeseToRempve = GetById(id);


        }

        public static Cheese GetById(int id)
        {
            return cheeses.Single(x => x.CheeseId == id);

        }


    }
}
