using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var ans1 = solution.Question1(new int[] { 2, 7, 11, 15 }, 9);
            var ans2 = solution.Question1(new int[] { 3, 2, 4 }, 6);
            var ans3 = solution.Question1(new int[] { 3, 3 }, 6);
        }

        

    }

    public class Solution
    {
        public int[] Question1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                        return new int[2] { i, j };
                }
            }
            //no exist
            return new int[0];
        }
    }
}
