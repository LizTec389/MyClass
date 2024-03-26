
class Program
{
    static void Main()
    {

        MyClass.MyClass interger = new(42, "Hello");

        //Calling Methods
        interger.ShowInformation();

        MyClass.MyClass.MethodStatic();

        int value = 5;
        interger.MethodWithStepByReference(ref value);
        Console.WriteLine($"Value after method: {value}");

        interger.MethodWithStepByValue(value);
        Console.WriteLine($"Value after method: {value}");

        string message;
        interger.MethodWithStepByOutput(out message);
        Console.WriteLine(message);
    }
}