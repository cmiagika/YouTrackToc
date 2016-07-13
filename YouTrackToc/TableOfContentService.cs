using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTrackToc
{
    class TableOfContentService
    {

        public bool Start()
        {
            Console.WriteLine("Started");

            return true;
        }

        public TableOfContentService()
        {
            Console.WriteLine("Je ne comprend pas :'(");
        }

        public bool Stop()
        {
            Console.WriteLine("Stoped");
            return true;
        }

    }
}
