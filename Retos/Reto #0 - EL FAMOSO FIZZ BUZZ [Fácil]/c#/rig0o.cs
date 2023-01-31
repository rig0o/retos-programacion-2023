using System.Text;

for (var i = 1; i <=100; i++)
{
    var sb = new StringBuilder("");
    if (i%3 == 0) sb.Append("fizz");
    if (i%5 == 0) sb.Append("buzz");
    Console.WriteLine($"number{i} : {sb}");
}