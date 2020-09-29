using System.Collections.Generic;
using System.Linq;

namespace firstLab
{
    public class TestMethods
    {
        [TestMethod]
        public List<int> NewDistinct(List<int> items)
        {
            return items?.ToHashSet()
                         .ToList();
        }

        [TestMethod]
        public List<int> DefaultDistinct(List<int> items)
        {
            return items?.Distinct()
                         .ToList();
        }

        [TestMethod]
        public List<int> DefaultIntersect(List<int> first, List<int> second)
        {
            return first?.Intersect(second)
                         .ToList();
        }

        [TestMethod]
        public List<int> NewIntersect(List<int> first, List<int> second)
        {
            if (first == null || second == null)
            {
                return null;
            }
            var hashSet = new HashSet<int>(second);

            return first.Where(item => hashSet.Remove(item))
                        .ToList();
        }

        [TestMethod]
        public List<int> DefaultSorting(List<int> items)
        {
            items?.Sort();
            return items;
        }
    }
}
