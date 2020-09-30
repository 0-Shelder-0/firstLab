using System.Collections.Generic;

namespace firstLab
{
    public interface IGeneratorCollection
    {
        List<List<int>> Generate(int itemsCount, int collectionCount);
    }
}
