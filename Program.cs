// // See https://aka.ms/new-console-template for more information

// // initial setup

// Console.WriteLine("Hello, World!");

// // basic strings

// string fName = "fname";
// string lName = "lname";
// // fName = fName.Trim();

// string name = $"First name: {fName} Last name: {lName}";

// Console.WriteLine(name);

// Console.WriteLine(name.Contains("fname"));

// Console.WriteLine(name.Length);

// // conditionals and loops

// decimal a = 89.23M;
// decimal b = 12.21M;

// decimal c = a + b;

// bool check = c > 100;

// Console.WriteLine($"The sum of a and b is {c}");

// if (check && a == b)
// {
//     Console.WriteLine("the answer is greater than 100");
//     Console.WriteLine("the values for a and b are equal");
// } 
// else if (!check && a == b){
//     Console.WriteLine("The answer is not greater than 100");
//     Console.WriteLine("the values for a and b are equal");
// }
// else {
//     Console.WriteLine("The value is not greater than 100");
//     Console.WriteLine("the values of a and b are not equal");
// }

// int counter = 0;

// counter++;
// counter += 2; // counter = 3

// Console.WriteLine($"value of counter is {counter}");

// counter--; // counter == 2

// Console.WriteLine($"curent value of counter is {counter}");

// do{
//     counter++;
//     Console.WriteLine($"value of counter is {counter}");
// } while (counter < 7);

//         // arrays and forloops

// int[] array = {1,3,4,5,6};

// foreach (int i in array)
// {
//     Console.WriteLine(i);
// }

// // can also use standard for loops
// for(int i = 0; i < array.Length; i++){
//     Console.WriteLine($"current value of i is {i}");
// }

//         // working with List<T>

// var names  = new List<String> {"<name>", "John", "Bob"};

// foreach (var name in names){
//     Console.WriteLine($"Name: {name.ToUpper()}");
// }

// // basic class syntax

// using System.IO.Pipes;

// namespace hello
// {
//     class helloWorld
//     {
//         static void Main(string[] args) // svm
//         {
//             // Console.WriteLine("hello world");

//             // Console.ReadKey(); // prevents screen from closing fast

//             var names = new List<String> { "name 1", "name 2", "name 3" };

//             foreach (var name in names)
//             {
//                 Console.WriteLine($"name: {name}");
//             }

//             // names.Add("name 4");
//             names = {..names, "name 4"}
//             bool boolean = names.Contains("name 3");
//             Console.WriteLine(boolean);

//             foreach (var name in names)
//             {
//                 Console.WriteLine($"name {name.ToUpper()}");
//             }
//         }
//     }
// }

// // SEARCHING AND SORTING LISTS

// using System.IO.Pipes;

// class main
// {
//     static void Main(string[] args)
//     {
//         var names = new List<String> { "john", "bill", "bob", "zane", "adil" };

//         names.Sort(); // can do the same for numbers

//         foreach (var name in names)
//         {
//             Console.WriteLine(name);
//         }

//         Console.WriteLine($"adil is in slot {names.IndexOf("adil")}");
//     }
// }

// // LANGAUGE INTEGRATED QUERIES and METHODS (LINQ)

// using System.Runtime.CompilerServices;

// class Example
// {
//     static void Main(string[] args)
//     {
//         int[] testScores = { 100, 92, 83, 50, 66, 93, 95, 75 };

//         // can use forloop for this
//         // foreach (int score in testScores)
//         // {
//         //     if(score > 80){
//         //         Console.WriteLine($"{score} score is over 80");
//         //     }
//         // }

//         // IEnumerable<int> scoreQuery =
//         //     from score in testScores
//         //     where score > 80
//         //     orderby score ascending // similar to SQL
//         //     select score;

//         // foreach (int i in scoreQuery)
//         // {
//         //     Console.Write(i + " ");
//         // }

//         var scoreQueryLambda = testScores.Where(s => s > 80).
//                         OrderByDescending(s => s); // s such that s > 80

//         // the above 2 are the same but lambda is less readable

//         List<int> myScores = scoreQueryLambda.ToList();

//         foreach (var score in myScores)
//         {
//             Console.WriteLine($"score is {score}");
//         }
//     }
// }


// OBJECT ORIENTED PROGRAMMING ._.

// Basic OOP in C#

// Defining a class
class Person
{
    protected string firstName;
    protected string lastName;
    protected int age;

    // ctor
    public Person(string fName, string lName, int age)
    {
        this.firstName = fName;
        this.lastName = lName;
        this.age = age;
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
        }
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"hello my name is {firstName} {lastName} and I am {age} years old.");
    }
}

// inheritance
class Student : Person
{
    public int StudentID { get; set; }

    public Student(string fName, string lName, int age, int studentID)
        : base(fName, lName, age)
    {
        this.StudentID = studentID;
    }

    // overriding
    public new void Introduce()
    {
        Console.WriteLine($"hello I am {StudentID}, a student named {firstName} {lastName}, and I am {Age} years old.");
        // above line is prevented from working due to inaccessibility if var is private
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("john", "dylan", 25);
        Student student1 = new Student("bill", "bob", 20, 12345);

        person1.Introduce();
        student1.Introduce();

        student1.Age = 21;
        Console.WriteLine($"new age: {student1.Age}");
    }
}
