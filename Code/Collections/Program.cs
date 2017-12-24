using System;
using System.Collections.Generic;
using System.Linq;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections#BKMK_SimpleCollection
class Program
{
    static void Main(string[] args)
    {
        /* -> First Example:
        // Same as -> List<string> salmos = new List<string>();
        var salmons = new List<string>();
        salmons.Add("chinook");
        salmons.Add("coho");
        salmons.Add("pink");
        salmons.Add("sockeye");

        foreach (var salmon in salmons)
        {
            Console.Write(salmon + " ");
        }
        */

        /* -> Second Example:
        var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

        foreach (var salmon in salmons)
        {
            Console.Write(salmon + " ");
        }
        */

        /* -> Third Example:
        var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

        for (int index = 0; index < salmons.Count; index++)
        {
            Console.Write(salmons[index] + " ");
        }
        */

        /* Fourth Example:
        var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

        salmons.Remove("coho");

        foreach (var salmon in salmons)
        {
            Console.Write(salmon + " ");
        }
        */

        /* -> Fifth Example: 
        List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int index = numbers.Count - 1; index >= 0; index--)
        {
            if (numbers[index] % 2 == 1)
            {
                numbers.RemoveAt(index);
            }
        }

        numbers.ForEach(number => Console.Write(number + " "));
        */

        /* -> Sixth Example:
        IterateThroughList();
        */

        /* -> Seventh Example:
        IterateThruDictionary();
        //FindInDictionary("K");
        FindInDictionary2("Ca");
        */

        /* -> Eighth Example:
        ShowLINQ();
        */

        //* -> Ninth Example:
        ListCars();
        //*/

        Console.Write("Press any key to exit.");
        Console.ReadKey();
    }

    // Sixth Example
    public static void IterateThroughList()
    {
        var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { name = "Tadpole", megaLightYears = 400},
            new Galaxy() { name = "Pinwheel", megaLightYears = 25},
            new Galaxy() { name = "Milky way", megaLightYears = 0},
            new Galaxy() { name = "Andromeda", megaLightYears = 3}
        };

        foreach (Galaxy theGalaxy in theGalaxies)
        {
            Console.WriteLine($"{theGalaxy.name} {theGalaxy.megaLightYears}");
        }
    }
    // ---

    // Seventh Example:
    public static void IterateThruDictionary()
    {
        Dictionary<string, Element> elements = BuildDictionary();

        foreach (KeyValuePair<string, Element> keyValuePair in elements)
        {
            Element theElement = keyValuePair.Value;

            Console.WriteLine($"Key: {keyValuePair.Value}");
            Console.WriteLine($"Values: {theElement.Symbol} {theElement.Name} {theElement.AtomicNumber}");
        }
    }

    public static Dictionary<string, Element> BuildDictionary()
    {
        return new Dictionary<string, Element>
        {
            { "K", new Element {Symbol = "K", Name = "Potassium", AtomicNumber = 19} },
            { "Ca", new Element {Symbol = "Ca", Name = "Calcium", AtomicNumber = 20} },
            { "Sc", new Element {Symbol = "Sc", Name = "Scandium", AtomicNumber = 21} },
            { "Ti", new Element {Symbol = "Ti", Name = "Titanium", AtomicNumber = 22} }
        };
    }

    public static void FindInDictionary(string symbol)
    {
        Console.WriteLine($"Searching for the element: {symbol}.");

        Dictionary<string, Element> elements = BuildDictionary();

        if (!elements.ContainsKey(symbol))
        {
            Console.WriteLine($"{symbol} not found.");
        }
        else
        {
            Element theElement = elements[symbol];
            Console.WriteLine($"found: {theElement.Name}");
        }
    }

    public static void FindInDictionary2(string symbol)
    {
        Console.WriteLine($"Searching for the element: {symbol}.");

        Dictionary<string, Element> elements = BuildDictionary();

        Element theElement;

        if (!elements.TryGetValue(symbol, out theElement))
        {
            Console.WriteLine($"{symbol} not found.");
        }
        else
        {
            Console.WriteLine($"found {theElement.Name}.");
        }
    }
    // ---

    // Eighth Example:
    public static void ShowLINQ()
    {
        List<Element> elements = BuildList();

        // Language-Integrated Query
        var subset = from theElement in elements
                     where theElement.AtomicNumber < 22
                     orderby theElement.Name
                     select theElement;

        foreach (Element theElement in subset)
        {
            Console.WriteLine($"{theElement.Name} {theElement.AtomicNumber}");
        }
    }

    public static List<Element> BuildList()
    {
        return new List<Element>
        {
            { new Element {Symbol = "K", Name = "Potassium", AtomicNumber = 19} },
            { new Element {Symbol = "Ca", Name = "Calcium", AtomicNumber = 20} },
            { new Element {Symbol = "Sc", Name = "Scandium", AtomicNumber = 21} },
            { new Element {Symbol = "Ti", Name = "Titanium", AtomicNumber = 22} }
        };
    }
    // ---

    // Ninth Example:
    public static void ListCars()
    {
        var cars = new List<Car>
        {
            { new Car() { Name = "car1", Color = "Purple", Speed = 19} },
            { new Car() { Name = "car2", Color = "Purple", Speed = 21} },
            { new Car() { Name = "car3", Color = "Back", Speed = 46} },
            { new Car() { Name = "car4", Color = "Yellow", Speed = 32} },
            { new Car() { Name = "car5", Color = "Blue", Speed = 95} },
            { new Car() { Name = "car6", Color = "Red", Speed = 77} },
            { new Car() { Name = "car7", Color = "Red", Speed = 118} }
        };

        // Sort the cars by color alphabetically, and then by speed in descending order.
        cars.Sort();

        foreach (Car thisCar in cars)
        {
            Console.Write($"{thisCar.Color.PadRight(8)} {thisCar.Speed.ToString().PadRight(5)} {thisCar.Name}");
            Console.WriteLine();
        }
    }
    // ---
}