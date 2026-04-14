using System;

class Student
{
    private static int nextId = 1;

    public int StudentId { get; }
    public string Name { get; set; }
    public string Faculty { get; set; }

    private double gpa;
    public double GPA
    {
        get { return gpa; }
        set
        {
            if (value < 0.0 || value > 4.0)
                throw new Exception("GPA must be between 0.0 and 4.0");
            gpa = value;
        }
    }

    public Student(string name, double gpa, string faculty)
    {
        StudentId = nextId++;
        Name = name;
        GPA = gpa;
        Faculty = faculty;
    }

    public override string ToString()
    {
        return $"{StudentId} | {Name} | GPA: {GPA:F2} | {Faculty}";
    }
}

class Registry
{
    private Student[] students = new Student[100];
    private int count = 0;

    public void Add(Student s)
    {
        if (count >= 100)
        {
            Console.WriteLine("Registry is full!");
            return;
        }
        students[count++] = s;
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
                return students[i];
        }
        return null;
    }

    public void FindByName(string name)
    {
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (students[i].Name.ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine(students[i]);
                found = true;
            }
        }
        if (!found)
            Console.WriteLine("No students found.");
    }

    public void GetTopStudents(int n)
    {
        if (count == 0)
        {
            Console.WriteLine("No students.");
            return;
        }

        Student[] copy = new Student[count];
        Array.Copy(students, copy, count);

        Array.Sort(copy, (a, b) => b.GPA.CompareTo(a.GPA));

        for (int i = 0; i < n && i < copy.Length; i++)
        {
            Console.WriteLine(copy[i]);
        }
    }

    public void PrintAll()
    {
        if (count == 0)
        {
            Console.WriteLine("No students.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(students[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Registry registry = new Registry();

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Find by ID");
            Console.WriteLine("3. Find by Name");
            Console.WriteLine("4. Top students");
            Console.WriteLine("5. Print all");
            Console.WriteLine("6. Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("GPA: ");
                        double gpa = double.Parse(Console.ReadLine());

                        Console.Write("Faculty: ");
                        string faculty = Console.ReadLine();

                        registry.Add(new Student(name, gpa, faculty));
                        Console.WriteLine("Added!");
                        break;

                    case "2":
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        var s = registry.FindById(id);
                        Console.WriteLine(s != null ? s.ToString() : "Not found");
                        break;

                    case "3":
                        Console.Write("Enter name: ");
                        string search = Console.ReadLine();
                        registry.FindByName(search);
                        break;

                    case "4":
                        Console.Write("How many top students: ");
                        int n = int.Parse(Console.ReadLine());
                        registry.GetTopStudents(n);
                        break;

                    case "5":
                        registry.PrintAll();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}