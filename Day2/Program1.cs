using System;

namespace Day2
{
    class Program1
    {
        public static void Main()
        {
            System.Console.WriteLine("1"); //1

            System.Console.Write("2");
            System.Console.Write("3");
            System.Console.WriteLine("4"); //234

            Console.WriteLine("5" + "6" + "7"); //567

            Console.WriteLine(5 + 6 + 7); //18

            int a = 5;
            Console.WriteLine(a); //5

            Console.WriteLine("a"); //a

            int b = 10;
            Console.WriteLine(a + b); //15
            Console.WriteLine("a" + "b"); //ab
            Console.WriteLine("a" + b); //a10 = "a" + "10"
            Console.WriteLine(a + "b"); //5b  = "5" + "b"

            Console.WriteLine("She says \"Hello\"");  //She says "Hello"

            //BREAK

            Console.WriteLine("Three double quotes \"\"\"");  //Three double quotes """
            Console.WriteLine("In C# to write \" in a string you must use \\\"");  
            //In C# to write " in a string you must use \"

            //*
            //**
            //***
            Console.WriteLine("*\n**\n***");

            //Name              Age
            //John Smith        21
            //Jane Spencer      22
            //Jimbo Shade       23
            Console.WriteLine("Name \t\t Age");
            Console.WriteLine("John Smith \t 21");
            Console.WriteLine("Jane Spencer \t 22");
            Console.WriteLine("Jimbo Shade \t 23");

            string doubleQuote = "\"";
            Console.WriteLine(doubleQuote + doubleQuote + doubleQuote);

            //remember a=5 and b=10 declared previously
            //5 + 10 = 15 
            Console.WriteLine(a + " + " + b + " = " + a + b); //5 + 10 = 510
            Console.WriteLine(a + " + " + b + " = " + (a + b)); //5 + 10 = 15
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b); //5 + 10 = 15
            Console.WriteLine("{2} = {1} + {0}", a, b, a + b); //15 = 10 + 5 
        }
    }
}
