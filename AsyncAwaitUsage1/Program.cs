using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitUsage1
{
    class Program
    {
        private string Method2()
        {
            string s = "Hi,Welcome to Async and Await Concept of C#";
            Thread.Sleep(10000);
            return s;
        }
        private async void Method1()
        {
            Task<string> task = new Task<string>(Method2);
            task.Start();
            //string str = Method2();
            string str = await task;
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Method1();
            Console.ReadKey();
        }
    }
}
