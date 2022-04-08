using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public delegate void SampleDelegate(out int number);

    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleClass.SampleMethodOne);
            del += SampleClass.SampleMethodTwo;
            //del += SampleClass.SampleMethodThree;
            //del += SampleClass.SampleMethodFour;

            int DelegateOutputParameter = -1;
            del(out DelegateOutputParameter);

            Console.WriteLine(DelegateOutputParameter); //  return thing in the method invocation list
        }
    }

    public class SampleClass
    {
        public static void SampleMethodOne(out int number)
        {
            number = 1;
        }

        public static void SampleMethodTwo(out int number)
        {
            number = 2;
        }

        //public static void SampleMethodThree(out int number)
        //{
        //    number = 3;
        //}

        //public static void SampleMethodFour(out int number)
        //{
        //    number = 4;
        //}

    }

}
