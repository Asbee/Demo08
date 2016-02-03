using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int x;
            double y = 0;
            double avg;
            int[] nums = new int[7];

            Console.Write("How many times you want to roll dice? ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x;i++)
            {
                
                dice.DiceThrow();
                nums[dice.randnumb]++;

                
                

                y = (y + dice.randnumb);
                
            }
            avg = y / x;
            Console.WriteLine("Average = " + avg);
            Console.WriteLine("Number one: " + nums[1] + "\nNumber Two: " + nums[2] + "\nNumber three: " +
                nums[3] + "\nNumber Four: " + nums[4] + "\nNumber Five: " + nums[5] + "\nNumber Six: " + nums[6]);
            
            
            
           
        }
    }
}
