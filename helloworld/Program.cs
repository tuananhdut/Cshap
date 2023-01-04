using System;

namespace helloworld{
    internal class Program{
        static void swap(ref int a, ref int b){
            int temp=a; 
            a=b; 
            b=temp;
        } 
        static void Main(){
            int a,b;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}",b);
            swap(ref a, ref b);
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}",b);
            Console.ReadKey();
        }
    }
}