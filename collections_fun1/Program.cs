// using Seido.Utilities.SeedGenerator;

namespace collections_fun1;

class Program
{
    static void Main(string[] args)
    {
        var r = new Random();

        List<int> list = new List<int>();
        for (int i = 0; i <50; i++){
            list.Add(r.Next(0,100));
        }
        foreach (int i in list){
            System.Console.Write($"{i, 10}");
            if(i %10 == 0){
                System.Console.WriteLine();
            }
            
        }
        Console.WriteLine("Hello, World!");
    }
}
