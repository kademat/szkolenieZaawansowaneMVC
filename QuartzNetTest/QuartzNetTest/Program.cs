using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

            scheduler.Start();

            IJobDetail job = JobBuilder.Create<PrintJob>().Build();

            ITrigger trigger = TriggerBuilder.Create().StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(1).RepeatForever()).Build();

            scheduler.ScheduleJob(job, trigger);

            Console.ReadLine();

            scheduler.Shutdown();


        }
    }
}
