using System;

namespace test2{
    internal class Program{
        static void swap(ref int a, ref int b){
            int temp=a; 
            a=b; 
            b=temp;
        } 
        static void Main(){
            Console.WriteLine("hello");
            Console.ReadKey();
        }
    }
}