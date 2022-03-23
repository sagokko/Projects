using System.Text.RegularExpressions;

class Program
{

    public static void Main(string[] args)
    {
        int n = 0;
        int[] arr = new int[n];
        Console.WriteLine("Укажите размер массива: ");
        Console.ReadLine(randomming(arr[n]), counting(arr[n]));
        // int n = 0;
        // string n1 = n.ToString(Console.ReadLine());
        // int[] array = new int[n];
        // int count = 0;
        Console.WriteLine();

        Console.ReadKey();
    }
    public class randomming
    {
        public static int randomm(string[] args)
        {
        Random rand = new Random();
        int n = 0;
        string n1 = n.ToString(Console.ReadLine());
        int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 20);
            }
            return arr;
        }
    }

    //static randomming(string[] array)
       // {
          //  Random rand = new Random();
           // int n = 0;
           // string n1 = n.ToString(Console.ReadLine());
           // int[] arr = new int[n];
           // for (int i = 0; i < n; i++)
           // {
           //     arr[i] = rand.Next(1, 20);
           // }
          //  return arr;
       // }

      //  static void counting(string[] array)
      //  {
         //   int n = 0;
         //   int[] arr = new int[n];
         //   int count = 0;
          //  for (int i = 0; i < n; i++)
          ////  {
            //    for (int j = 0; j < n; j++)
            //    {
              //      if (randomming == randomming)
              //          count++;
              //  }
               // Console.WriteLine("{0} - {1}", arr[i], count);
               // count = 0;
          //  }
       // }
        // for (int i = 0; i < n; i++)
       // {
            // array[i] = rand.Next(1, 20);
            //   for (int j = 0; j < n; j++)
            //    {
            //     if (array[i] == array[j])
            //        count++;
            //    }
            //   Console.WriteLine("{0} - {1}", array[i], count);
            //   count = 0;
       // }
}