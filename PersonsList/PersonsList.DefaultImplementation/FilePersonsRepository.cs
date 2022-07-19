using PersonsList.Abstractions;
using PersonsList.DataModel;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsList.DefaultImplementation
{
    public class FilePersonsRepository : IPersonsRepository
    {
        private TextReader? reader;
        public void ConnectToDataSource(string dataSource)
        {
            reader = new StreamReader(dataSource);
        }

        public void Disconnect()
        {
            if (reader != null)
            {
                reader.Close();
                reader.Dispose();
                reader = null;
            }
        }

        public IEnumerable<Person> GetAll()
        {
            if (reader != null)
            {
                string rawData = reader.ReadToEnd();
                var list = JsonSerializer.Deserialize<IEnumerable<Person>>(rawData);
                if (list != null)
                   return list;
            }
            return new List<Person>();
        }
    }
}
