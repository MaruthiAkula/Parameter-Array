using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 3;//
            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            // parameterarray(array);
            parameterarray(1, 2, 3,y);


        }
        public static void parameterarray(params int[] array)
        {
            Console.WriteLine("Elments Are {0}", array.Length);
            foreach(int i in array)
            {
                Console.WriteLine(i);
                    
            }
        }
    }
}
