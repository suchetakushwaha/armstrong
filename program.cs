using System;
namespace Pelingdrome 
{
    class Program {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem,sum = 0;
           // int temp =n;
        while (n>0)
        {
           rem = n %10;
            sum = sum + (rem*rem*rem);
            n = n/10;
        }
        if(n == sum)
        {
          System.Console.WriteLine("armstrong");
        }
       else
       {
           System.Console.WriteLine("not armstrong");
       }
           
        }
    }

} 