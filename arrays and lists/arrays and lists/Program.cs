using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);



        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        stringList.Remove("World");

        Console.WriteLine(stringList[0]);

        Console.ReadLine();




        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 20;
        numArray[4] = 5000;



        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        Console.WriteLine(numArray1[3]);

        int[] numArray2 = { 1, 2, 3, 4, 5, 5, 6, };
        Console.WriteLine(numArray2[5]);

        Console.WriteLine(numArray[3]);

        numArray2[5] = 650;
        Console.ReadLine();

    }
    }

