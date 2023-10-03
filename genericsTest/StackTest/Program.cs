// crear arreglos de double y enteros 

double[] doubleElement =
{
    1.1,2.2,3.3,4.4,5.5,6.6
};
int[] intElement =
{
    1,2,3,4,5,6,7,8,9,10,11
};

Stack<int> Stack = new Stack<int>(5);
StackTest.Stack<double>doubleStack = new();
StackTest.Stack<int>intStack = new(10);

testPushDouble(); // empuja double e el doubleStack

//test push method whit doubleStack 
void testPushDouble()
{
    try
    {
        Console.WriteLine("\n ´pushing elements onto the doubleStack ");
        foreach (var elements in doubleElement)
        {
            Console.WriteLine($"{elements:F1}");
            doubleStack.Push(elements);
        }
    }
    catch (FallStackException exception)
    {
        Console.Error.WriteLine($"{elemnts}")
    }
}