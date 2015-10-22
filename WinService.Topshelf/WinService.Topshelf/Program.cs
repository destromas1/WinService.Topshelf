using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WinService.Topshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<FileWriterService>();
                x.RunAsLocalSystem();
                x.SetDescription("FileWriterService");
                x.SetDisplayName("FileWriterService");
                x.SetServiceName("FileWriterService");
                x.StartAutomatically();
                x.EnableServiceRecovery(rc => rc.RestartService(1));

            });
        }
    }
}
