using System;
using NLog;  //引用 NLog 函式庫，讓我們能夠使用其日誌功能。

namespace NLogDemo1_1746
{
    internal class Program
    {
        //LogManager.GetCurrentClassLogger()：取當前類別的日誌記錄器（logger）。
        //Logger 是 NLog 提供的物件，負責記錄日誌。
        // logger 是靜態變數，用來記錄所有的日誌訊息。
        //readonly：只能在初始化時設置一次，並且後續不能再更改它的值。
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
