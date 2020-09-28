using System.Collections.Generic;
using System.Linq;

namespace firstLab
{
    public class TestMethods
    {
        [TestMethod]
        public List<int> NewDistinct(List<int> list)
        {
            if (list == null)
            {
                return null;
            }
            var hashSet = new HashSet<int>();

            foreach (var element in list)
            {
                hashSet.Add(element);
            }

            return hashSet.ToList();
        }

        [TestMethod]
        public List<int> DefaultDistinct(List<int> list)
        {
            return list?.Distinct().ToList();
        }

        [TestMethod]
        public List<int> DefaultIntersect(List<int> list)
        {
            return list?.Intersect(list).ToList();
        }

        public List<int> NewIntersect(List<int> list)
        {
            return null;
        }

        [TestMethod]
        public List<int> NewSorting(List<int> list)
        {
            return null;
        }

        [TestMethod]
        public List<int> DefaultSorting(List<int> list)
        {
            list?.Sort();
            return list;
        }
    }
}
