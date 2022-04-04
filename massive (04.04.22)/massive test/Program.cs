class Program
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.Write("Укажите размер массива: ");
            bool done = int.TryParse(Console.ReadLine(), out n);
            if (done)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите именно число");
                Console.ReadKey();
                Console.Clear();
            }
        }
        int[] array = new int[n];
        DublicateFinder dublicateFinder = new DublicateFinder();
        dublicateFinder.Randomming(array);
        dublicateFinder.CopyCheck(array);
    }
}
class DublicateFinder
{
public void Randomming(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 20);
}
}

public void CopyCheck(int[] array)
{
List <Element> elements = new List <Element>();
bool is_found;
Element element1 = new Element();


foreach (int number in array)
{
    is_found = false;
    for (int i = 0; i < elements.Count; i++)
    {
        if (elements[i].Value == number) 
        {
            element1 = elements[i];
            element1.countAdd();
            elements[i] = element1;
            is_found = true;
            break;
        }
    }

    if (!is_found)                           
    {
        elements.Add(new Element(number));  
    }
}

elements = elements.OrderBy(element => element.Value).ToList();

foreach (Element element in elements)
{
    Console.WriteLine(element.Value + " - " + element.Count);
}
}
}
    struct Element
{

    public Element(int n1)
    {
        value = n1;
        count = 1;
    }

    public void countAdd()
    {
        count++;
    }

    public int Value
    {
        get { return value; }
    }

    public uint Count
    {
        get { return count; }
    }

    private int value = 0;

    private uint count = 0;
}