Random rand = new Random();
Console.Write("Укажите размер массива: ");
int n = 0;
Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(1, 20);
    for (int j = 0; j < n; j++)
    {
        if (array[i] == array[j])
        count++;    
    }
    Console.WriteLine("{0} - {1}", array[i], count);
    count = 0;
}