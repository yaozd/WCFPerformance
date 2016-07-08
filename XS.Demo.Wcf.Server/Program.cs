using System;
using XS.WCF.WCFHelper;

namespace XS.Demo.Wcf.Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string filename = AppDomain.CurrentDomain.BaseDirectory + "config\\catclient.xml";
            //Cat.Initialize(filename);

            var server = WcfServer.GetInstance();
            server.WcfFaultedEvent += server_WcfFaultedEvent;
            server.WcfClosedEvent += server_WcfClosedEvent;
            server.WcfBeforeCallEvent += server_WcfBeforeCallEvent;
            server.WcfAfterCallEvent += server_WcfAfterCallEvent;
            server.Start();
            Console.WriteLine("服务启动...");

            Console.ReadKey();

            server.Stop();
        }

        private static void server_WcfAfterCallEvent(string operationName, object[] outputs, object returnValue,
            object correlationState, string AbsolutePath)
        {
            //Console.WriteLine("返回操作结束：" + AbsolutePath + "/" + operationName);
            //TODO 暂时不输出
            //Console.WriteLine("返回操作结束：" + correlationState);
        }

        private static void server_WcfBeforeCallEvent(string operationName, object[] inputs, string AbsolutePath,
            object correlationState)
        {
            //Console.WriteLine("返回操作开始：" + AbsolutePath + "/" + operationName);
            //TODO 暂时不输出
            //Console.WriteLine("返回操作开始：" + correlationState);
        }

        private static void server_WcfClosedEvent(object sender, EventArgs e)
        {
            //Console.WriteLine(e.ToString());
        }

        private static void server_WcfFaultedEvent(object sender, EventArgs e)
        {
            //Console.WriteLine(e.ToString());
        }
    }
}