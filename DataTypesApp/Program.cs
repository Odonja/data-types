using System.Runtime.ConstrainedExecution;

namespace DataTypesApp;

class Program
{

    private static readonly int[] integersForSummation = [54, 38, 47, 92, 648];
    private static readonly string[] stringsForSummingTheLength = ["Mochi", "Boefje", "Bammetje", "Eitje", "Nugget"];
    private static readonly string[] arrayWith2Strings = ["Zisco", "Marlo"];
    private static readonly string[] arrayWith3Strings = ["Anneke", "Linne", "Patje"];
    private static readonly List<Car> listOfCars = [new Car("Valve", 800), new Car("Toyota", 750), new Car("Kia", 700)];
    static void Main(string[] args)
    {
        PrintSumOfIntegers();
        PrintSumOfLengthOfStrings();
        Combine2ArraysAndPrintTheNewArray();
        PrintTheAverageWeightOfCars();
    }

    private static void PrintTheAverageWeightOfCars()
    {
        int carWeightSum = 0;
        foreach (Car car in listOfCars)
        {
            carWeightSum += car.Weight;
        }
        double averageWeight = carWeightSum / (double)listOfCars.Count;
        Console.WriteLine($"The average weight of cars is {averageWeight}");
    }

    private static void Combine2ArraysAndPrintTheNewArray()
    {
        var concatenatedArray = arrayWith2Strings.Concat(arrayWith3Strings).ToArray();
        Console.WriteLine("[{0}]", string.Join(", ", concatenatedArray));
    }

    private static void PrintSumOfLengthOfStrings()
    {
        int sumOfLengthOfStrings = stringsForSummingTheLength.Select(str => str.Length).Sum();
        Console.WriteLine($"The sum of the length of the strings in the array with fixed values is {sumOfLengthOfStrings}");
    }

    private static void PrintSumOfIntegers()
    {
        int sumOfIntegers = integersForSummation.Sum();
        Console.WriteLine($"The sum of the constant integer array is {sumOfIntegers}");
    }
}
