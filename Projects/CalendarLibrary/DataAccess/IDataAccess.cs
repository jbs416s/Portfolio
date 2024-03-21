
namespace CalendarLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(T dataModel, U parameters, string command, string connectionString);
        void SaveData<T>(T dataModel, string command, string connectionString);
    }
}