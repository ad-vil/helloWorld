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

using System.IO.Pipes;

namespace hello
{
    class helloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            Console.ReadKey();
        }
    }
}