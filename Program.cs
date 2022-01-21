using System;
using System.Collections.Generic;

namespace CodeCal
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = new int[]  { 1,  3, 2, 2, 5,2,3,7};
            List<int> sbs = new List<int>();
            int vc=1;
           int v = (nums[nums.Length-1]) ;
           if( v - nums[nums.Length-2] == vc)
           {
               sbs.Add(vc);
           }
           else if(nums[nums.Length-2] - nums[nums.Length-3] == vc)
           {
               sbs.Add(vc);
           }
           else if (nums[nums.Length-2] - nums[nums.Length-3] == vc)
           {
               sbs.Add(vc);
           }
           else if (nums[nums.Length-3] -nums[nums.Length-4] == vc)
           {
               sbs.Add(vc);
           }
           else if(nums[nums.Length-4]-nums[nums.Length-5]==vc)
           {
               sbs.Add(vc);
           }
        else if(nums[nums.Length-5]-nums[nums.Length-6]==vc)
           {
               sbs.Add(vc);
           }
           else if(nums[nums.Length-6]-nums[nums.Length-7]==vc)
           {
               sbs.Add(vc);
           }
           int [] backToArray = sbs.ToArray();
           int b = backToArray.Length;
         Console.WriteLine(b);
            }
            
        }
    
}
