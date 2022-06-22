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
            //沒寫完
            Solution solution = new Solution();
            var ans1 = solution.Question5(6);
            var ans2 = solution.Question5(8);
            var ans3 = solution.Question5(14);
            var ans4 = solution.Question5(1);
        }

        

    }

    public class Solution
    {
        public int Question2(string s)
        {
            int ans = 0;
            Dictionary<Char, int> data= new Dictionary<Char, int>();
            data.Add('I',1);
            data.Add('V', 5);
            data.Add('X', 10);
            data.Add('L', 50);
            data.Add('C', 100);
            data.Add('D', 500);
            data.Add('M', 1000);

            foreach (var _tmp in s.Split()) { 
                //tmp in  sum
            }

          
            return ans;
        }

        public bool Question5(int n)
        {
            bool ans= n% 2 == 0 && n % 3 == 0 && n % 5 == 0; //no
            if (n == 1) return true;

            
            return ans;
        }

        /*
        public bool Question6(int num)
        {
            
            return false;
        }*/
    }
}
