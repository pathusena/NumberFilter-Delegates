using DelegateExample;

public class Program {
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        FilterDelegate evenFilter = FilterNumber.IsEven;
        FilterDelegate oddFilter = FilterNumber.IsOdd;

        List<int> evenNumbers = FilterNumber.Filter(numbers, evenFilter);
        List<int> oddNumbers = FilterNumber.Filter(numbers, oddFilter);

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));

        Console.ReadKey();
    }

}
