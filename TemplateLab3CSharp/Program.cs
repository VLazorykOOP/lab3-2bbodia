TestTask1();
Console.ReadKey();
TestTask2();



void TestTask1()
{
    Triangle[] triangles = new[]
   {
    new Triangle(3, 4, 5,1),
    new Triangle(5, 12, 13,2),
    new Triangle(8, 15, 17,3),
    new Triangle(7, 24, 25,4),
    new Triangle(20, 21, 29,5)
};

    Triangle.ShowTriangles(triangles);
    Console.WriteLine("Changing some parameters of the triangles...");
    triangles[0].A = 4;
    triangles[1].B = 10;
    triangles[2].C = 10;
    try
    {
        triangles[3].A = -2;
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
    }
    Triangle.ShowTriangles(triangles);

}
void TestTask2()
{
    var persons = GetPersons(10).OrderBy(f => f.GetType().Name);
    foreach (var person in persons)
    {
        Console.WriteLine($"Type:{person.GetType().Name}");
        Console.WriteLine($"{person.ShowInfo()}");
        Console.WriteLine();
    }
    static IEnumerable<Person> GetPersons(int count)
    {
        var CountOfTypes = 4;

        Random random = new();
        List<Person> persons = new();
        for (int i = 0; i < count; i++)
        {
            var initials = GetRandomInitials();
            switch (random.Next(CountOfTypes))
            {
                case 0:
                    int age = random.Next(100);
                    persons.Add(new Person(initials.firstName, initials.surName, age));
                    break;
                case 1:
                    age = random.Next(18, 65);
                    int salary = random.Next(6500, 100000);
                    persons.Add(new Employee(initials.firstName, initials.surName, age, salary));
                    break;
                case 2:
                    age = random.Next(22, 60);
                    salary = random.Next(10000, 100000);
                    int experience = random.Next(0, 40);
                    persons.Add(new Engineer(initials.firstName, initials.surName, age, salary, experience));
                    break;
                case 3:
                    age = random.Next(22, 50);
                    salary = random.Next(6500, 20000);
                    persons.Add(new Officer(initials.firstName, initials.surName, age, salary,  Guid.NewGuid()));
                    break;

            }
        }
        return persons;
        static (string firstName, string surName) GetRandomInitials()
        {
            List<string> firstNames = new()
    {
        "Bohdan",
        "Ivan",
        "Petro",
        "Dmytro",
        "Oleg",
        "Yuriy",
        "Vasyl"
    };
            List<string> surNames = new()
    {
        "Ivanov",
        "Petrov",
        "Bandura",
        "Koval",
        "Kovalenko",
        "Kovalchuk",
        "Kovalsky"
    };
            Random random = new Random();
            return (firstNames[random.Next(firstNames.Count)], surNames[random.Next(surNames.Count)]);
        }
    }

}