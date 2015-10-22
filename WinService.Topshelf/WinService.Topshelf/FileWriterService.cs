using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WinService.Topshelf
{
    class FileWriterService : ServiceControl
    {
        public bool Start(HostControl hostControl)
        {
            File.WriteAllText("info.txt", "Start");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            File.WriteAllText("info.txt", "Stop");
            return true;
        }
    }
}
