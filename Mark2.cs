
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;


namespace Program
{
    class Program1 //:IHomework13
    {
        //public IEnumerable<int> Homework13(IEnumerable<int> numbers)
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {

                int numbers = int.Parse(Console.ReadLine());
                string total = null;

                int[] c = numbers.ToString().Select(o => int.Parse(o.ToString())).ToArray();

                if (c[0] + c[1]  == 18)
                {
                    if (c[2] != 9)

                    {   
                            foreach (var item in c)
                                total += item;
                            Console.WriteLine();
                    }
                }
                
                else if (c[1] + c[2]   == 18)
                {
                    if (c[0]  != 9)
                    {
                        if (c[3] != 9)
                        {
                            foreach (var item in c)
                                total += item;
                            Console.WriteLine(total);
                        }
                    }
                }
                else if (c[2] + c[3]  == 18)
                {
                    if (c[1]  != 9)
                    {
                        if (c[4] != 9)
                        {
                            foreach (var item in c)
                                total += item;
                            Console.WriteLine(total);
                        }
                    }
                }
                else if (c[3] + c[4] == 18)
                {
                    if (c[2] != 9)
                    {
                        if (c[5] != 9)
                        {
                            foreach (var item in c)
                                total += item;
                            Console.WriteLine(total);
                        }
                    }
                }
                else if (c[4] + c[5] == 18)
                {
                    if (c[3] != 9)
                    {
                        
                            foreach (var item in c)
                                total += item;
                            Console.WriteLine(total);
                        
                    }
                }

                else
                {
                    Console.WriteLine("+++");
                }
                
            }
            //yield return 10;

        }


    }

    //public interface IHomework13
    // {
    //  IEnumerable<int> Homework13(IEnumerable<int> numbers);
}

//}

