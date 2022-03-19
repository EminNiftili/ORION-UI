using OrionScreenOne.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAPP
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            while (true)
            {
                var msg = Console.ReadLine();
                CheckMsg.Check(msg.ToLower().Replace(" ",""));
            }
        }
    }
    class CheckMsg
    {
        internal static void Check(string msg)
        {
            if (msg == "startscreen1")
            {
                OrionScreenOne.Program.Main();
            }
            else if(msg =="startgame")
            {
                ThreeDObjects.Run();
            }
            else if(msg == "downloadpackorion")
            {
                Random randomFor = new Random();
                for (var i = 0; i < randomFor.Next(10,30); i++)
                {
                    Random random = new Random();
                    int delayTime = random.Next(1, 2000);
                    string response = "Downlading ORION Pack ===============> Time: " + DateTime.Now.AddSeconds(Convert.ToDouble(random.Next(1, 10))).ToString();
                    Console.WriteLine(response);
                    Thread.Sleep(delayTime);
                }
                Console.WriteLine("Download Complete..//");
            }
            else if (msg == "speeddownloadpackorion")
            {
                Random randomFor = new Random();
                for (var i = 0; i < randomFor.Next(50, 100); i++)
                {
                    Random random = new Random();
                    int delayTime = random.Next(1, 500);
                    string response = "Downlading speed ORION Pack ===============> Time: " + DateTime.Now.AddSeconds(Convert.ToDouble(random.Next(1, 10))).ToString();
                    Console.WriteLine(response);
                    Thread.Sleep(delayTime);
                }
                Console.WriteLine("Download All Pack Complete..//");
            }
            else if (msg == "cls")
            {
                Console.Clear();
            }
            else if (msg.Contains("backgroundcolor"))
            {
                string tr = msg.Substring(15);
                try
                {
                    int colorHex = Convert.ToInt32(tr);
                    ConsoleColor color = (ConsoleColor)colorHex;
                    Console.Clear();
                    Console.BackgroundColor = color;
                }
                catch
                {
                    Console.WriteLine("Invalid Color Number => " + tr);
                }
            }
            else if (msg.Contains("foregroundcolor"))
            {
                string tr = msg.Substring(15);
                try
                {
                    int colorHex = Convert.ToInt32(tr);
                    ConsoleColor color = (ConsoleColor)colorHex;
                    Console.Clear();
                    Console.ForegroundColor = color;
                }
                catch
                {
                    Console.WriteLine("Invalid Color Number => " + tr);
                }
            }
            else
            {
                Console.WriteLine("Invalid Command => " + msg);
            }
        }
    }
}
