namespace LINQ_Company
{
    public class Company
    {
        public string Name { get; set; }
        public string Profile { get; set; }
        public DateOnly Foundation { get; set; }
        public string CEO_Name {get;set;}

        public int Employee { get; set;}
        public string Address { get; set;}
        public List<Employee> EmployeesList { get; set;}

        public Company(string name, string profile, DateOnly foundation, string cEO_Name, int employers, string address)
        {
            Name = name;
            Profile = profile;
            Foundation = foundation;
            CEO_Name = cEO_Name;
            Employee = employers;
            Address = address;
        }

        public Company(string name, string profile, DateOnly foundation, string cEO_Name, int employers, string address,List<Employee> list) : this(name, profile, foundation, cEO_Name, employers, address)
        {
            EmployeesList = list;
        }

        public override string ToString()
        {
            return $"Name:{Name}\nProfile:{Profile}\nFoundationYear:{Foundation}\nCEO Name:{CEO_Name}\nEmployers:{Employee}\nAddress:{Address}\n\n";
        }
    }
}
