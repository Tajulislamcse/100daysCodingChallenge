using System;

namespace CSharp2
{
    class Program
    {
        public static int fibo(int num)
        {
            if(num==0)
            {
                return 0;
            }
            else if(num==1||num==2)
            {
                return 1;
            }
            else
            {
                return fibo(num-2)+fibo(num-1);
            }
        }
        static void Main(string[] args)
        {

        //     int Number1,Number2;
        //    Console.Write("Please Enter Your Number1:");
        //      Number1=int.Parse(Console.ReadLine());
        //    Console.Write("Please Enter Your Number2:");
        //      Number2=int.Parse(Console.ReadLine());
        //    Console.Write(Number1+"*"+Number2+"="+Number1*Number2);
        Console.Write("Please Enter Your Number:");
        int i,num,count=0;
        num=int.Parse(Console.ReadLine());
        //Console.Write(num);
        for(i=2;i<=Math.Sqrt(num);i++)
        {
           if(num%i==0)
             count++;
        }
         if(count==0 && num>1)
         {
        Console.Write("\nPrime");

         }
         else
         {
        Console.Write("Not Prime");
             
         }
        // }
        //   int i,num;

        // Console.Write("Please Enter a number:");
        // num=int.Parse(Console.ReadLine());

        //   for(i=0;i<num;i++)
        //   {
              
        //     Console.Write("\t"+fibo(i));

        //   }
    }
}
}