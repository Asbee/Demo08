using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    class Dice
    {
      public  Random rand = new Random();
       public int randnumb;
        public void DiceThrow()
        {


            
                
                randnumb = rand.Next(1, 7);
                Console.WriteLine("You roll " + randnumb);
                

            
        }
           
                
        
            
        
        
    }
}
