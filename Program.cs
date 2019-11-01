using System;

    public interface IHomework05
{
    string DisplayLEDOnScreen(string ledNo);
}

    public class Homework05 : IHomework05
    {
       public string DisplayLEDOnScreen(string ledNo)
        {
           
              int x = 0;
            string[] d = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            int[] num = {0,0,0,0,0,0,0,0,0,0};
            string e = (" 1  2  3  4  5  6  7  8  9  A");
           
             Console.WriteLine  ("Please choose LED to turn On/Off");
            Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
            Console.WriteLine(e);
            Console.WriteLine("LED OFF");


            while(x<10){
             Console.WriteLine  ("Please choose LED to turn On/Off");
           int input = int.Parse(Console.ReadLine());
            var ww = "[!]";
            var dd = "[ ]";
            int b = 1;
            b = input - b;
            int Ledpi = 0; 
             Ledpi = b + 1;


            
            
            if (input <=10)
            {

             if(1 == num[b] )
                {
                
                    d[b] = dd;
                    Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                    Console.WriteLine(e);
                   
                    num[b] = 0;    
                     Console.WriteLine("LED "+Ledpi+" OFF");                                           
                  
                 }
              else     
                 {           
                 
                 
                    d[b] = ww;
                    Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                    Console.WriteLine(e);
                     
                    num[b] = 1;   
                    Console.WriteLine("LED "+Ledpi+" ON");           
                  }
            
            }   
            else  
            {
                Console.WriteLine("LED Error ");
            }
            
      
        }
           return ledNo;
        }
       

            
               

           
        
    }
    class Program 
    {
        static void Main(string[] args)
        {
         
          Homework05 test = new Homework05();
          test.DisplayLEDOnScreen("");

         }

        
}        
       
            
        
            
        
          
        

    

