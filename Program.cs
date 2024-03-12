// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var names = new List<string>
{
    "<name>",
    "Ana",
    "Felipe",
    "Jerry"
};
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
