using NetLinkWelcomeProject;
using NetLinkWelcomeProject.Models;
using System.Diagnostics.CodeAnalysis;

List<string> departures = ["Moscow", "St Peterburg", "Vladivostok", "Voroneg", "Omsk"];
List<string> arrivals = ["Ekaterinburg", "Moscow", "Kaliningrad", "St Peterburg", "Kazan", "Irkutsk"];

var intersect = departures.Intersect(arrivals);

foreach(var item in intersect)
    Console.WriteLine(item);
Console.WriteLine();


var union = departures.Union(arrivals);

foreach (var item in union)
    Console.WriteLine(item);
Console.WriteLine();


//var except = departures.Except(arrivals);
var except = arrivals.Except(departures);
foreach (var item in except)
    Console.WriteLine(item);
Console.WriteLine();

var employees = ModelInit.Employees;

var names = employees.Distinct(new EmployeeCompanyEqual())
                     .ToList();

foreach (var item in names)
    Console.WriteLine(item);


class EmployeeNameEqual : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
        return x?.Name == y?.Name; // && x?.Company?.Title == y?.Company?.Title;
    }

    public int GetHashCode([DisallowNull] Employee obj)
    {
        return obj.Name.GetHashCode();
    }
}

class EmployeeCompanyEqual : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
        return x?.Company?.Title == y?.Company?.Title;
    }

    public int GetHashCode([DisallowNull] Employee obj)
    {
        return obj.Company!.Title.GetHashCode();
    }
}