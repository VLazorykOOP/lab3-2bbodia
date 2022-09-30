



class Officer : Employee
{
    public Officer(string name, string surname, int age, int salary, Guid signNumber)
        : base(name, surname, age, salary)
    {
        SignNumber = signNumber;
    }

    public Guid SignNumber { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", SignNumber: {SignNumber}";
    }


}