// Task 2: Selection statements
// use IF-ELSE, reads user age and determines whether they are a child, teen or adult
// display result to console
// Ensures that the program handles invalid input 

Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 0 && age <= 110)
{
    if (age < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age < 20)
    {
        Console.WriteLine("You are a teen");
    }
    else
    {
        Console.WriteLine("You are an adult");
    }
}
else
{
    Console.WriteLine("Invalid age entered. Try again");

}