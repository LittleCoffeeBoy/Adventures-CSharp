using System;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections#BKMK_SimpleCollection
public class Car : IComparable<Car>
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    public int CompareTo(Car other)
    {
        int compare;
        // The value returned is less than zero if the current object is less than the other object, greater than zero if the current object is greater than the other object, and zero if they are equal.
        compare = String.Compare(this.Color, other.Color, true);

        if (compare == 0)
        {
            compare = this.Speed.CompareTo(other.Speed);
            compare = -compare;
        }

        return compare;
    }
}