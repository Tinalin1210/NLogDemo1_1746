using System;
using System.Collections.Generic;
using NLog;

namespace NLogDemo1_1746
{
    internal class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            logger.Info("這是  Info 訊息");

            logger.Error("這是 Error 訊息");

            Console.WriteLine("Log 寫入成功");
            Console.ReadLine();
        }
    }
}
