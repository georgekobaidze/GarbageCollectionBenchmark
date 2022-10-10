using System.Collections;

namespace GarbageCollectionBenchmark.Models;

public class GenericVsArrayList
{
    public void StoreInArrayList()
    {
        var arrayList = new ArrayList();
        for (var i = 0; i < 10000; i++)
            arrayList.Add(i);
    }

    public void StoreInGenericList()
    {
        var list = new List<int>();
        for (var i = 0; i < 10000; i++)
            list.Add(i);
    }
}