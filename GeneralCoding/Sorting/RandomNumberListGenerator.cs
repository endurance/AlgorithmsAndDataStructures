using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class RandomNumberListGenerator
    {
        public static IEnumerable<int> GenerateRandomNumbers(int seed, int count, int min, int max, Action<int> doThisAction)
        {
            Random random = new Random(seed);
            var list = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                var randomvalue = random.Next(min, max);
                list.Add(randomvalue);
                doThisAction(randomvalue);
            }
            return list;
        }

        public static IEnumerable<int> GenerateRandomNumbers(int count, Action<int> doThisActionPerThing)
        {
            Random random = new Random();
            return GenerateRandomNumbers(random.Next(), count, 0, Int32.MaxValue, doThisActionPerThing);
        }
    }
}
