using System.Collections;

namespace GarbageCollectionBenchmark.Models;

// Given a large ArrayList object we can improve the performance of code by re-using it and making this large object long-lived 
public class ReusableArrayList
{
    public void UseArrayList()
    {
        var arrayList = new ArrayList(85190);
        UseArrayList(arrayList);

        arrayList = new ArrayList(85190);
        UseArrayList(arrayList);
    }

    public void ReuseArrayList()
    {
        var arrayList = new ArrayList(85190);
        UseArrayList(arrayList);

        arrayList.Clear();
        UseArrayList(arrayList);
    }

    private void UseArrayList(ArrayList arrayList)
    {
        for (var i = 0; i < arrayList.Capacity; i++)
            arrayList.Add("Test");

        var finalString = string.Empty;
        foreach (var item in arrayList)
            finalString += item.ToString();
    }
}