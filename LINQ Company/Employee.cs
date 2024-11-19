namespace LINQ_Company
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string PhoneNumber {get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public Employee(string name,string position,string phoneNumber,string email,int salary) {
            Name = name;
            Position = position;
            PhoneNumber = phoneNumber;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name:{Name}\nPosition:{Position}\nPhone Number:{PhoneNumber}\nEmail:{Email}\nSalary:{Salary}\n\n";
        }

    }
}
