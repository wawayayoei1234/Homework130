using System;

namespace ConsoleApp1
{
    class Mark1 : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            int a = 0;
            String[] f = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", };
            String n = (" 1  2  3  4  5  6  7  8  9  A");
            int[] h = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
            Console.WriteLine(n);
            Console.WriteLine("Please choose LED to turn On/Off:");



            while (a < 10)
            {
                string input = ledNo;
                int b = 1;

                switch (input)
                {
                    case "1":

                        if (h[0] == b)
                        {
                            f[0] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[0] = 0;
                            break;
                        }
                        else
                        {
                            h[0] = 1;
                            f[0] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "2":

                        if (h[1] == b)
                        {
                            f[1] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[1] = 0;
                            break;
                        }
                        else
                        {
                            h[1] = 1;
                            f[1] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "3":

                        if (h[2] == b)
                        {
                            f[2] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[2] = 0;
                            break;
                        }
                        else
                        {
                            h[2] = 1;
                            f[2] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "4":

                        if (h[3] == b)
                        {
                            f[3] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[3] = 0;
                            break;
                        }
                        else
                        {
                            h[3] = 1;
                            f[3] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "5":

                        if (h[4] == b)
                        {
                            f[4] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[4] = 0;
                            break;
                        }
                        else
                        {
                            h[4] = 1;
                            f[4] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "6":

                        if (h[5] == b)
                        {
                            f[5] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[5] = 0;
                            break;
                        }
                        else
                        {
                            h[5] = 1;
                            f[5] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "7":

                        if (h[6] == b)
                        {
                            f[6] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[6] = 0;
                            break;
                        }
                        else
                        {
                            h[6] = 1;
                            f[6] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "8":

                        if (h[7] == b)
                        {
                            f[7] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[7] = 0;
                            break;
                        }
                        else
                        {
                            h[7] = 1;
                            f[7] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "9":

                        if (h[8] == b)
                        {
                            f[8] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[8] = 0;
                            break;
                        }
                        else
                        {
                            h[9] = 1;
                            f[9] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "A":

                        if (h[9] == b)
                        {
                            f[9] = "[ ]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);
                            h[9] = 0;
                            break;
                        }
                        else
                        {
                            h[9] = 1;
                            f[9] = "[!]";
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                        

                }
            }
            return ledNo;
        }

        void IHomework05.DisplayLEDOnScreen(string ledNO)
        {
            throw new NotImplementedException();
        }
    }
}

            
        

    

