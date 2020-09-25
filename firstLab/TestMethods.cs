using System.Collections.Generic;
using System.Linq;

namespace firstLab
{
    public class TestMethods
    {
        public List<int> Distinct(List<int> list)
        {
            var hashSet = new HashSet<int>();

            foreach (var element in list)
            {
                hashSet.Add(element);
            }

            return hashSet.ToList();
        }
    }
}
