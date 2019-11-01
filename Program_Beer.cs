using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        var test = new IHomework();
        // var kuy = new Home();

        var num = new List<int> { 9980998,929555,695994, 990099, 089599,999888,  };
        var result = new List<string>();
        var sut = test.Homework13(num);

        foreach (var item in sut)
        {
            var ss = item.ToString();
            if (ss.Length == 5)
            {
                ss = "0" + ss;
            }
            else if (ss.Length == 4)
            {
                ss = "00" + ss;
            }
            else if (ss.Length == 3)
            {
                ss = "000" + ss;
            }
            else if (ss.Length == 2)
            {
                ss = "0000" + ss;
            }
            else if (ss.Length == 1)
            {
                ss = "00000" + ss;
            }
            result.Add(ss);
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}