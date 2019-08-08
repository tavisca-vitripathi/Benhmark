
using BenchmarkDotNet.Attributes;
using System.Threading;
using System.Threading.Tasks;


namespace BenchMark
{
    [MemoryDiagnoser]
    public class ThreadVsTask
    {
        public void Fun1()
        {
            // delay
            for (int i = 0; i < 1000; i++)
            {
                int j = i + 1;
                j *= 10;
            }
        }


        public async Task Fun2()
        {
            for (int i = 0; i < 1000; i++)
            {
                int j = i + 1;
                j *= 10;
            }
        }


        [Benchmark]
        public void ThreadTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ThreadStart(() => new ThreadVsTask().Fun1()));
                thread.Start();
                thread.Join();
            }
        }


        [Benchmark]
        public void TaskTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(async () =>
                {
                    var t = Fun2();
                    await Task.WhenAll(t);
                }).GetAwaiter().GetResult();
            }
        }
    }
}
















