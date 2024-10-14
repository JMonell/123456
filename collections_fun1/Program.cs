using Seido.Utilities.SeedGenerator;

namespace collections_fun1;

class Program
{
    static void Main(string[] args)
    {
        var r = new csSeedGenerator();

        List<int> list = new List<int>();
        for (int i = 0; i <50; i++){
            list.Add(r.Next(0,100));
        }
        WriteList("header", list);
        list.Sort();
        WriteList("header", list);
        for(int i = 0; i <50; i++){
            var idx1 = r.Next(0, list.Count);
            var idx2 = r.Next(0, list.Count);

            var t = list[idx1];
            list[idx1] = list[idx2];
            list[idx2] = t;
        }   
        WriteList("shuffled", list);

        var uniqueInts = new SortedSet<int>(list);
        WriteList("asd", uniqueInts.ToList());

        System.Console.WriteLine(list.Count > uniqueInts.Count);


        
    }

    static void WriteList(string header, List<int> list){
        int c= 0;
        foreach (int i in list){
        
            System.Console.Write($"{i} ");
            if(i %10 == 0){
                System.Console.WriteLine();
            }
            c++;
        }
        Console.WriteLine($"nr of elements {list.Count}");
    }
}
