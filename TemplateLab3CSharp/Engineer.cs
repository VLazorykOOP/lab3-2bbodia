



class Engineer : Employee
{
    public Engineer(string name, string surname, int age, int salary, int experience) :
        base(name, surname, age, salary)
    {
        Experience = experience;
    }
    public int Experience { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", Experience: {Experience}";
    }
}