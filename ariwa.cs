using System;
using System.Collections.Generic;
using System.Linq;
using rename;

namespace rename
{  
 class homework2 : IHomework13    
    {
             
    public IEnumerable<int> Homework13 (IEnumerable<int> numbers)
    {
        
       List<int> wawa = new List<int>();
        foreach (var item in numbers)
        {
        
            int u = check1(item);
            if(u!=0)
            {
                wawa.Add(u);

            }
            //Console.WriteLine(u);
        }
        
             return wawa;  
    }

      public static int  check1(int item)
    {         
         string t = null;
            string r = null;
            r=item.ToString();
            char[] ca = r.ToCharArray();

            if(ca[5] == '9')
             {      
                 if(ca[4] == '9')
                 {                           
                     if(ca[3] != '9')
                     {
                       
                        foreach (var it in ca)
                        {
                            t+= it;   
                        }
                        int stot = int.Parse(t);
                        int y = stot;
                        return y;
                         
                     }
                 }                 
             }
             else if(ca[4]=='9'&& ca[3]=='9')
             {
                 if(ca[5]!='9'&& ca[2]!='9')
                 {
                     
                    foreach (var it in ca)
                        {
                            t+= it;   
                        }
                        int stot = int.Parse(t);
                        int y = stot;
                        return y;
                     
                 }
             }
             else if(ca[3]=='9'&& ca[2]=='9')
             {
                 if(ca[4]!='9'&& ca[1]!='9')
                 {
                     foreach (var it in ca)
                        {
                            t+= it;   
                        }
                        int stot = int.Parse(t);
                        int y = stot;
                        return y;
                 }
             }
              else if(ca[2]=='9'&& ca[1]=='9')
             {
                 if(ca[3]!='9'&& ca[0]!='9')
                 {
                     foreach (var it in ca)
                        {
                            t+= it;   
                        }
                        int stot = int.Parse(t);
                        int y = stot;
                        return y;

                 }
             }
             else if(ca[1]=='9'&& ca[0]=='9')
             {
                 if(ca[2]!='9')
                 {
                     foreach (var it in ca)
                        {
                            t+= it;   
                        }
                        int stot = int.Parse(t);
                        int y = stot;
                        return y;
                 }
             }
    return 0;
    }
    }
}
public interface IHomework13
{
    IEnumerable<int> Homework13(IEnumerable<int> numbers);
}
