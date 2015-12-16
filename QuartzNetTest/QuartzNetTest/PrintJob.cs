using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNetTest
{
    public class PrintJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Test: {0}", DateTime.Now);



            //int a = 10;
            //var value = string.Format("Test: {0}", a);
            ////ta jest lepsza - nie ma 2 razy rzutowania
            //var value2 = string.Format("Test: {0}", a.ToString());
        }
    }
}
