using LINQ_Company;

Company[] companies = new Company[]
{
    new Company("Tech Innovators", "IT", new DateOnly(2023, 1, 1), "John White", 1200, "London"),
    new Company("Green Energy Solutions", "Renewable Energy", new DateOnly(2024, 1, 1), "Alice Smith", 500, "New York"),
    new Company("HealthFood Plus", "Healthcare Services", new DateOnly(2000, 1, 1), "Michael Johnson", 3000, "Kyiv"),
    new Company("Creative Studios", "Design and Marketing", new DateOnly(2015, 1, 1), "Emma Davis", 200, "Texas"),
    new Company("BlackTech Corp", "Educational Technology", new DateOnly(2018, 1, 1), "Robert White", 150, "London")
};

// Получить информацию обо всех фирмах

var allInfo = companies.Select(item => item);

foreach(var item in allInfo)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы, у которых в названии есть слово Food
var foodContains = companies.Where(item => item.Name.Contains("Food"));

foreach (var item in foodContains)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы, которые работают в области маркетинга
var marketingCompanies = companies.Where(item => item.Profile.Contains("Marketing"));

foreach (var item in marketingCompanies)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();


// Получить фирмы, которые работают в области маркетинга или IT
var marketingOrIT = companies.Where(item => item.Profile.Contains("Marketing") || item.Profile.Contains("IT"));
foreach (var item in marketingOrIT)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы с количеством сотрудников, большем 100
var biggerThan = companies.Where(item => item.Employee > 450);

foreach (var item in biggerThan)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы с количеством сотрудников в диапазоне от 100 до 300
var inRange = companies.Where(item => item.Employee > 450 && item.Employee <= 2500);

foreach (var item in inRange)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы, которые находятся в Лондоне
var londonCompanies = companies.Where(item => item.Address == "London");

foreach (var item in londonCompanies)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы, у которых фамилия директора White
var CEOWhite = companies.Where(item => item.CEO_Name.Contains("White"));
foreach (var item in CEOWhite)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();


// Получить фирмы, которые основаны больше двух лет назад
var longerThanTwoYears = companies.Where(item => DateTime.Now.Year - item.Foundation.Year > 2);
foreach (var item in longerThanTwoYears)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы со дня основания, которых прошло 123 дня
var longerThan123Days = companies.Where(item => (DateOnly.FromDateTime(DateTime.Now).DayNumber - item.Foundation.DayNumber) > 123);
foreach (var item in longerThan123Days)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить фирмы, у которых фамилия директора Black и название фирмы содержит слово White
var blackAndWhite = companies.Where(item => item.CEO_Name.Contains("White") && item.Name.Contains("Black"));
foreach (var item in blackAndWhite)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


List<Employee> employees = new List <Employee>
{
        new Employee("John White", "Software Engineer", "234-567-8901", "john.white@example.com", 70000),
        new Employee("Alice Smith", "Project Manager", "+634-567-8902", "alice.smith@example.com", 85000),
        new Employee("Michael Johnson", "HR Specialist", "534-567-8903", "michael.johnson@example.com", 50000),
        new Employee("Emma Davis", "Marketing Director", "434-567-8904", "emma.davis@example.com", 95000),
        new Employee("Robert White", "CTO", "+134-567-8905", "robert.white@example.com", 120000),
        new Employee("Linda Brown", "Software Tester", "234-567-8906", "linda.brown@example.com", 60000),
        new Employee("James Wilson", "Sales Manager", "234-567-8907", "james.wilson@example.com", 70000),
        new Employee("Jessica Taylor", "Data Analyst", "334-567-8908", "jessica.taylor@example.com", 75000),
        new Employee("David Lee", "Customer Support", "734-567-8909", "david.lee@example.com", 45000),
        new Employee("Olivia Martinez", "Finance Officer", "834-567-8910", "olivia.martinez@example.com", 80000)
};

var myCompany = companies[0];
myCompany.EmployeesList = employees;

// Получить всех сотрудников конкретной фирмы
var allEmployees = myCompany.EmployeesList.Select(item => item);

foreach (var item in allEmployees)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить всех сотрудников конкретной фирмы, у которых заработные платы больше заданной
int mySalary = 70000;
var biggerSalary = myCompany.EmployeesList.Where(item => item.Salary > mySalary);

foreach (var item in biggerSalary)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить сотрудников всех фирм, у которых должность менеджер
var managers = myCompany.EmployeesList.Where(item => item.Position.Contains("Manager"));

foreach (var item in managers)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить сотрудников, у которых телефон начинается с 23
var phone23 = myCompany.EmployeesList.Where(item => item.PhoneNumber.StartsWith("23"));

foreach (var item in phone23)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить сотрудников, у которых Email начинается с di
var emailDi = myCompany.EmployeesList.Where(item => item.Email.StartsWith("di"));


foreach (var item in emailDi)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

// Получить сотрудников, у которых имя Lionel
var lionels = myCompany.EmployeesList.Where(item => item.Name.Contains("John "));

foreach (var item in lionels)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine();

