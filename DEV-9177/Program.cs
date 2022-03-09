using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9177
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new AppHost().Init().Start("http://*:80/");
            "ServiceStack Self Host with Razor listening at http://127.0.0.1".Print();
            Process.Start("http://127.0.0.1");

            Console.ReadLine();
        }
    }
}
