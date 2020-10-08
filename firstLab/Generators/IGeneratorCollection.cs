using System.Collections.Generic;

namespace firstLab.Generators
{
    public interface IGeneratorCollection
    {
        List<List<int>> GenerateList(int itemsCount, int collectionCount);
    }
}
