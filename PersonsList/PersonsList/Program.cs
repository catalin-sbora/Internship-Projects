// See https://aka.ms/new-console-template for more information
using PersonsList.Abstractions;
using PersonsList.DataModel;
using PersonsList.DefaultImplementation;
using PersonsList.MemoryDataSource;

Console.WriteLine("Hello, World!");
IPersonsRepository? personsRepository = new MemoryPersonsRepository();
IDisplayDevice? displayDevice = new ConsoleDisplayDevice();
IConnectionStringFactory connectionStringFactory = new FileConnectionStringFactory();

IEnumerable<Person> LoadPersons(IConnectionStringFactory connectionStringFactory)
{
    if (personsRepository == null)
    { 
        return new List<Person>();
    }
    try
    {
        personsRepository.ConnectToDataSource(connectionStringFactory.CreateConnectionString());
        return personsRepository.GetAll();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Failed to read data {ex.Message}");        
    }
    finally 
    {        
        if (personsRepository != null)
            personsRepository.Disconnect();
    }
    return new List<Person>();
}

void DisplayPersons(IEnumerable<Person> persons)
{
    foreach (var person in persons)
    {        
        displayDevice?.DisplayText($"{person.Name}");
    }
}


var list = LoadPersons(connectionStringFactory);
DisplayPersons(list);