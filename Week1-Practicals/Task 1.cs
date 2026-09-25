/*
 * Week 1 Practicals
 * Complete 5 tasks using C# programming language
*/


// Task 1: Processing user input
// asks user for their name and age, displays name and age after 5 years

Console.WriteLine("Enter your name");
string name = Console.ReadLine();

Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());

if (0 <= age && age <= 110)
{
    Console.WriteLine($"Hello {name}, you will be {age + 5} in 5 years.");
}
else
{
    Console.WriteLine("Invalid age entered. Try again");
}