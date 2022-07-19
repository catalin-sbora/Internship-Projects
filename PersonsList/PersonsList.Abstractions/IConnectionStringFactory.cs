using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsList.Abstractions
{
    public interface IConnectionStringFactory
    {
        string CreateConnectionString();
    }
}
