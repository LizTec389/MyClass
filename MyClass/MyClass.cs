using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyClass
{
    public class MyClass
    {
        private int miInteger;
        private string myString;

        public MyClass()
        {
            miInteger = 0;
            myString = "Worthless";
        }

       // Parameter Builder
    public MyClass(int  egerInitial, string stringInitial)
        {
            miInteger = egerInitial;
            myString = stringInitial;
        }

        //Method That Displays Information
    public void ShowInformation()
        {
            Console.WriteLine($"Integer: {miInteger}, String: {myString}");
        }

       // Destroyer(Finisher)
    ~MyClass()
        {
            Console.WriteLine("Destroyed Object.");
        }
        public static void MethodStatic()
        {
            Console.WriteLine("This is a static method.");
        }
      //  Method with arguments
        public void MethodWithArguments(int number, string text)
        {
            Console.WriteLine($"Number: {number}, Text: {text}");
        }
       // Parameter Pass-Through Method by Reference
        public void MethodWithStepByReference(ref int value)
        {
            value *= 2;
        }

        //Parameter Pass-by-Value Method
        public void MethodWithStepByValue(int value)
        {
            value += 10;
        }
       // Parameter Pass-Through Method Per Output
    public void MethodWithStepByOutput(out string result)
        {
            result = "Hello from the method!";
        }

    }
}
