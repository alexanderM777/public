Console.WriteLine($"maximum of 3,4 and 5 is: {maximum(3,4,5)} ");
Console.WriteLine($"maximum of 3.3,4.4 and 5.5 is: {maximum(3.3,4.4,5.5)} ");
Console.WriteLine($"maximum of pear,apple and orange is: " +
    $"{maximum("pear","apple","orange")} ");


// generic function determines the largest of the Icomparable<T> Objects
T maximum<T>(T x,T y, T z) where T:IComparable<T>
{
    var max = x;
    //asumir es el mayor 

    //comparar y con x
    if(y.CompareTo(max) >0)
    {
        max = y;
    }
    if(z.CompareTo(max) >0)
    {
        max = z;
    }
    return max;


   

}