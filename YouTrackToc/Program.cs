using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace YouTrackToc
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(serviceConfig =>
            {
                serviceConfig.Service<TableOfContentService>(serviceInstance =>
                {
                    serviceInstance.ConstructUsing(() => new TableOfContentService());
                    serviceInstance.WhenStarted(execute => execute.Start());
                    serviceInstance.WhenStopped(execute => execute.Stop());
                });
                serviceConfig.SetServiceName("YouTrackTocService");
                serviceConfig.SetDisplayName("YouTrackToc Service");
                serviceConfig.SetDescription("YouTrackToc Service to create table of content in YouTrack automatically.");
                serviceConfig.RunAsLocalSystem();

                serviceConfig.StartAutomatically();
            });
        }
    }
}
