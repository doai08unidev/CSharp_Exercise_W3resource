// 2. Write a C# Sharp program to print the sum of two numbers.
using System;
namespace CSharpExerciseW3resource{
    namespace Basic{
        public class Ex2{
            public static void Main(string[] args){
                Ex2 ex2 = new Ex2();
                System.Console.WriteLine(ex2.SumToNum(5,8));
            }
            public int SumToNum(int a, int b){
                return a+b;
            }
        }
    }

}