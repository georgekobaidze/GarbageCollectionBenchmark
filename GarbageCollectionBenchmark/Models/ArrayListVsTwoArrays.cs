using System.Collections;

namespace GarbageCollectionBenchmark.Models;

// Making small long-lived object short-lived
public class ArrayListVsTwoArrays
{
    public void UseArrayList()
    {
        var arrayList = new ArrayList(85190); // Large object
        for (var i = 0; i < 10000; i++)
            arrayList.Add(new Tuple<int, int>(i, i + 1)); // Integers are being saved as objects in a large ArrayList, which is stored in large object heap, integers will be stored in gen 0 and will never be deallocated, hence eventually end up in gen 2
    }
    
    public void UseTwoArrays()
    {
        // Integers are stored in array. Because integer is a value-type they will be stored with the array in large object heap, so nothing will be stored in gen 0.
        var array1 = new int[85190];
        var array2 = new int[85190];

        for (var i = 0; i < 10000; i++)
        {
            array1[i] = i;
            array2[i] = i + 1;
        }
    }
}