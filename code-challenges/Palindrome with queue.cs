// C# program for checking 
// palindrome with queue
using System; 
using System.Collections;
using System.Collections.Generic; 
using System.Linq;
  
public class Balanced { 
       
    public static void Main(String[] args) 
    {
        
       
        Queue<char> cstack = new Queue<char>();
        Queue<char> cstack2 = new Queue<char>();
        
        
        bool isPalindrome = true;
        string input = "12331";
        char[] chars = input.ToCharArray(); 
        char[] chars3 = input.ToCharArray(); 
        Array.Reverse( chars3 );
        string chars2 = new string( chars3 );

        
        foreach (char value in chars)
        {
            cstack.Enqueue(value);
        }
        
       
    
        foreach(char j in chars3)
        {
            cstack2.Enqueue(j);

        }
        
        
        int number = cstack.Count;
        int num2 = number/2;
       
    
        for(int i = num2; i < number ; i++)
        {
            cstack2.Dequeue();
            cstack.Dequeue();

        }
        

         Console.WriteLine(cstack2.Count);
         Console.WriteLine(cstack.Count);
           
        if (cstack.Count != cstack2.Count)  
        {  
            
            cstack.Dequeue();   
        }  
         while (cstack.Count!=0)  
        {  
            if (cstack.Peek() == cstack2.Peek())  
            {  
                cstack.Dequeue();  
                cstack2.Dequeue();  
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
