using System;

namespace ConsoleApp1
{
    public delegate string HelloFunctionDelegate(string message);
    public delegate int TestFunctionDelegate(int number);

    class Program
    {
        static void Main(string[] args)
        {
            //A delegate is type safe function pointer
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello); 

            //del("Hello from Delegate");
            Console.WriteLine(del("Hello from Delegate"));

            TestClass testClass = new TestClass();
            TestFunctionDelegate test = new TestFunctionDelegate(testClass.Test);
            Console.WriteLine(test(4));
        }

        //public static void Hello(string message) //  type safe, must match signature i.e return void and match number of parameters
        public static string Hello(string message) 
        {
            return message;
        }

    }

    public class TestClass
    {
        public int Test(int number)
        {
            return number;
        }
    }
}
