using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate bool FilterDelegate(int numb);
    public static class FilterNumber
    {
        public static List<int> Filter(List<int> numbers, FilterDelegate filterDelegate) { 
            List<int> results = new List<int>();
            foreach (int num in numbers)
            {
                if (filterDelegate(num)) { 
                    results.Add(num);
                }
            }
            return results;
        }

        public static bool IsEven(int n) { 
            return n%2 == 0;
        }

        public static bool IsOdd(int n)
        {
            return n%2 != 0;
        }
    }
}
