using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9177
{
    public class AppHost : AppSelfHostBase
    {
        public AppHost() : base("JiwaAPI", typeof(ServiceInterface.DummyClasss).Assembly)
        {
            // Give service stack our licence so we aren't limited
            ServiceStack.Licensing.RegisterLicense("18303-e1JlZjoxODMwMyxOYW1lOkppd2EgRmluYW5jaWFscyxUeXBlOkluZGllLE1ldGE6MCxIYXNoOndmcjFLT0NIZDczN0s1alZoSytnZGV0VkI5ZkxoNEVEK1drYU1tVHh2QlZKdDlrVy9vZVJHeWNqL2hPZSs5WUp6WFY2SHpOYnhyMWJZWE84ZHk3K2dmQWRKOG1jbTRRQkx6RGQraWtSa1lsa2ZRb2JrZTZkM2svaXo4SVpFZEU5LzlMZkZFMFlJU2RydGhwMzZKc2R6amYycVh4bndqU0wzRHVUV2NYdDZBaz0sRXhwaXJ5OjIwMjItMTEtMTF9");
        }

        public override void Configure(Funq.Container container)
        {
        }
    }
}
