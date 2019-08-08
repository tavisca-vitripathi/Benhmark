using BenchmarkDotNet.Running;
using System;


namespace BenchMark
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("which Method you wanna test");
            string input = Console.ReadLine();
            switch (input)
            {
                case "ThreadVsTask":
                    BenchmarkRunner.Run<ThreadVsTask>();
                    break;

                case "StringTest":
                    BenchmarkRunner.Run<StringTest>();
                    break;

                case "ClassVsStruct":
                    BenchmarkRunner.Run<ClassVsStruct>();
                    break;

                case "ArrayVsList":
                    BenchmarkRunner.Run<ArrayVsList>();
                    break;


                case "ForeachVsFor":
                    BenchmarkRunner.Run<ForeachVsFor>();
                    break;


                default:
                    Console.WriteLine("Invalid Choice");
                    break;


            } 
            Console.ReadKey(true);
        }
    }
}
















