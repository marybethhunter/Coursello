using Coursello;

Exercise exercise = new Exercise();


Console.WriteLine(@$"
------------------------------
| Coursello Coding Challenge |
------------------------------

Press any key to display the mean, median, and standard deviation
of all U.S. States and Territories populations from the 2020 Census...
");

Console.ReadKey();

exercise.ExecuteFirstProblem();

Console.WriteLine(" ");

Console.WriteLine("Enter a U.S. State or Territory to view its population:");
var input = Console.ReadLine();

if (input == null)
{
    Console.WriteLine("Enter a U.S. State or Territory to view its population:");
}
else
{
    Console.WriteLine(" ");
    exercise.ExecuteSecondProblem(input);
}