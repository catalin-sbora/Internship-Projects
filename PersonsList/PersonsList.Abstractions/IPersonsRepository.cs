using PersonsList.DataModel;

namespace PersonsList.Abstractions
{
    public interface IPersonsRepository
    {
        IEnumerable<Person> GetAll();
        void ConnectToDataSource(string dataSource);
        void Disconnect();
    }
}