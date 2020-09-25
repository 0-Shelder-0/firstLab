using System.Collections.Generic;
using System.Linq;

namespace firstLab
{
    public class TestMethods
    {
        public List<int> NewDistinct(IEnumerable<int> list)
        {
            var hashSet = new HashSet<int>();

            foreach (var element in list)
            {
                hashSet.Add(element);
            }

            return hashSet.ToList();
        }

        public List<int> DefaultDistinct(IEnumerable<int> list)
        {
            return list.Distinct().ToList();
        }
    }
}
