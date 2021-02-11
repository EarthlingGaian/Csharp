// C# program for checking 
// balanced Brackets 
using System; 
using System.Collections.Generic; 
using System.Linq;
  
public class Balanced { 
       
    public static void Main(String[] args) 
    {
        Stack<char> cstack = new Stack<char>();
        Stack<char> cstack2 = new Stack<char>();
        bool isPalindrome = true;
        string input = "A MAN, A PLAN, A CANAL,PANAMAA";
        input = input.ToLower();
        input = input.Replace(" ", "");
        input = input.Replace(",", "");
       

        
        foreach (char c in input)
        {
            cstack.Push(c);
        }

    
        foreach(var j in cstack)
        {
            cstack2.Push(j);

        }
        for(int i = (cstack.Count/2); i < cstack.Count; i++)
        {
            cstack2.Pop();
            cstack.Pop();

        }
         //Console.WriteLine(cstack2.Count);
         //Console.WriteLine(cstack.Count);
           
        if (cstack.Count != cstack2.Count)  
        {  
            
            cstack.Pop();   
        }  
         while (cstack.Count!=0)  
        {  
            if (cstack.Peek() == cstack2.Peek())  
            {  
                cstack.Pop();  
                cstack2.Pop();  
            }  
            else
            {  
                isPalindrome = false;  
                break;  
            }  
        }  

       

        if (isPalindrome)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Non Palindrome");
        }


    }
}
