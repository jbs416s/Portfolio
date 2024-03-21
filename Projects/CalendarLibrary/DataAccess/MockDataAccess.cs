using CalendarLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLibrary.DataAccess;

public class MockDataAccess : IDataAccess
{
    private List<CalendarWeek> weeksData { get; set; } = new List<CalendarWeek>();

    public MockDataAccess()
    {
        weeksData = InitializeMockData();
    }

    private List<CalendarWeek> InitializeMockData()
    {
        var data = new List<CalendarWeek>();
        return data;
    }

    public void SaveData<T>(T dataModel, string command, string connectionString) { }

    public List<T> LoadData<T, U>(T dataModel, U parameters, string command, string connectionString)
    {
        var data = new List<T>();
        return data;
    }
}
