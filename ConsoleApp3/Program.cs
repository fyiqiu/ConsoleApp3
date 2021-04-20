using NetConf.NetConfReadShell;
using System;

namespace ConsoleApp3
{
    class Program : GetSwitchMessageForInterface
    {
        static void Main(string[] args)
        {
            string pwd = "123";
         
            Console.WriteLine("*********");
            string v = GetSwitchMessage(pwd);
            //Console.WriteLine(GetSwitchMessage(pwd));
            Console.WriteLine(v);
            Console.WriteLine("*********");
        }
    }
}
