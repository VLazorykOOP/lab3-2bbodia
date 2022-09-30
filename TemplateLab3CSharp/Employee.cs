



class Employee : Person
{
    public Employee(string name, string surname, int age, int salary) : base(name, surname, age)
    {
        Salary = salary;
    }
    public int Salary { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", Salary: {Salary}";
    }
}