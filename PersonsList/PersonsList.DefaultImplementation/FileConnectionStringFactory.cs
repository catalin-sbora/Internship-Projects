using PersonsList.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsList.DefaultImplementation
{
    public class FileConnectionStringFactory : IConnectionStringFactory
    {
        public string CreateConnectionString()
        {
            return "FileDS.txt";
        }
    }
}
