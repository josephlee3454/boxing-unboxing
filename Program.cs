using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
             List<object> box = new List<object>();
  
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");
            int sum=0;  
            foreach (var item in box)

                if(item is int)
                {   
                    int IsInt = (int)item;
                    sum += IsInt;
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine("hey yo item aant no number ");
                }

        }
    }
}
