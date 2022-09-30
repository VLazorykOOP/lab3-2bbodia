



class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public virtual string ShowInfo()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
    }
}
