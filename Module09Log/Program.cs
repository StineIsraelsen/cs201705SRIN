using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09Log
{
    class Program
    {
        static void Main(string[] args)
        {
            logger.Trace("Enter");
            logger.Trace("Calling test1");
            test1(5, 5);
            logger.Trace("Calling test2");
            test2();
            logger.Trace("Exit");
        }

        static void test1(int i, int x)
        {
            // mangler log
            logger.Trace("Enter test 1");
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            logger.Trace("Exit test 1");
        }

        static void test2()
        {
            logger.Trace("Enter test 2");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
                logger.Error(ex);
            }
            logger.Trace("Exit test 2");
        }

        private static Logger logger = LogManager.GetCurrentClassLogger();
    }
}
