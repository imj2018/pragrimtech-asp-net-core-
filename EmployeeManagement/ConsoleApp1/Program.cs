using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public delegate void SampleDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            //SampleDelegate del = new SampleDelegate(SampleClass.SampleMethodOne); //  pass function to delegate constructor
            //del();

            SampleDelegate del, del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleClass.SampleMethodOne);
            //del2 = new SampleDelegate(SampleClass.SampleMethodTwo);
            //del3 = new SampleDelegate(SampleClass.SampleMethodThree);
            //del4 = del1 + del2 + del3 - del2;

            //del4 -= del2;
            //del4();

            del = new SampleDelegate(SampleClass.SampleMethodOne); 
            del += SampleClass.SampleMethodTwo;
            del += SampleClass.SampleMethodThree;
            del -= SampleClass.SampleMethodTwo;
            del();

        }
    }

        
    public class SampleClass
    {
        //public delegate void SampleDelegate();

        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }

    }

}
