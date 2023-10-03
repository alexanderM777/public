// crear arrays/listas de neteros double y caracter it,double,strimg

using genericsTest;

int[] IntArrays = { 1,2,3,4,5,6 };
char[] charArrays = { 'H', 'E','L','L','o' };
double[] dubleArrays = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };

Console.WriteLine("Array IntArray contains");
/*overloadmethods.*/DisplayArray(IntArrays);

Console.WriteLine("Array DoubleArray contains");
/*overloadmethods.*/DisplayArray(dubleArrays);

Console.WriteLine("Array CharArray contains");
/*overloadmethods.*/DisplayArray(charArrays);

void DisplayArray<T>(T[] inputArray)
{
    foreach (var item in inputArray)
    {
        Console.WriteLine($"{item}");
    }
    Console.WriteLine();
}