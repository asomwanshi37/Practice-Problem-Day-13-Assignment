using System;
using System.Collections.Generic;

namespace Generic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC 1 to find max int
            Console.WriteLine("Maximum values for integer");
            TC1Integer.TC1int();
            TC1Integer.TC2int();
            TC1Integer.TC3int();
            Console.WriteLine("--------------------------------------------");

            //UC 2 
            Console.WriteLine("Maximum values for floats");
            TC2Float.TC1Flt();
            TC2Float.TC2Flt();
            TC2Float.TC3Flt();
            Console.WriteLine("--------------------------------------------");

            //UC3
            Console.WriteLine("Maximum values for strings");
            TC3String.TC1String();
            TC3String.TC2String();
            TC3String.testCase3String();
            Console.WriteLine("--------------------------------------------");


            //Refactor 1 : For multiple inputs
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Maximum Values : ");

            //For Int
            int[] arrInt = { 12, 10, 15, 28, 32, 45 };
            int MaxInt = UC4ExtentMaxNum.MaxInt(arrInt);
            Console.WriteLine(MaxInt);

            //For Float
            double[] arrFlt = { 1.25, 3.22, 1.98, 3.30, 5.25 };
            double MaxFlt = UC4ExtentMaxNum.MaxFloat(arrFlt);
            Console.WriteLine(MaxFlt);

            //For String
            List<string> arrStr = new List<string> { "Apple", "Mango", "Banana", "Pineapple", "Orange" };
            string MaxStr = UC4ExtentMaxNum.MaxString(arrStr);
            Console.WriteLine(MaxStr);


            //Refactor 2 : To create Generic class to take 3 variables of generic type
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Maximum Values : ");

            //For int
            int[] arrayInt = { 200, 100, 300, 150, 320 };
            UC5MaxUsingGenerics<int> genericInt = new UC5MaxUsingGenerics<int>(arrayInt);
            genericInt.PrintMaxValue();

            //For float
            double[] arrayFlt = { 4.5, 5.2, 8.6, 1.2, 7.3 };
            UC5MaxUsingGenerics<double> genericFlt = new UC5MaxUsingGenerics<double>(arrayFlt);
            genericFlt.PrintMaxValue();

            //For string
            string[] arrayStr = { "Apple", "Mango", "Banana", "Pineapple", "Orange" };
            UC5MaxUsingGenerics<string> genericStr = new UC5MaxUsingGenerics<string>(arrayStr);
            genericStr.PrintMaxValue();

        }
    }
}
