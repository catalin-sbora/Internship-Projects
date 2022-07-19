using PersonsList.Abstractions;
using PersonsList.DataModel;

namespace PersonsList.MemoryDataSource
{
    public class MemoryPersonsRepository : IPersonsRepository
    {
        private List<Person>? persons;
        public void ConnectToDataSource(string dataSource)
        {
            persons = new List<Person>
            {
                new Person{ Id = 1, Name = "FirstPerson From Memory"},
                new Person{ Id = 2, Name = "SecondPerson From Memory"},
                new Person{ Id = 3, Name = "ThirdPerson From Memory"},
                new Person{ Id = 4, Name = "FourthPerson From Memory"}
            };
        }

        public void Disconnect()
        {
            persons = null;
        }

        public IEnumerable<Person> GetAll()
        {
            if (persons == null)
                return new List<Person>();

            return persons.AsEnumerable();
        }
    }
}