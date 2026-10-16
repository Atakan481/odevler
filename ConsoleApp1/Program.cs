/* int grade, count = 0, sum = 0;
int highest = int.MinValue; 
int lowest = int.MaxValue;  
while (true)
{
    grade = int.Parse(Console.ReadLine());

    if (grade == -1)
        break;

    sum += grade;
    count++;

    if (grade > highest)
        highest = grade;

    if (grade < lowest)
        lowest = grade;
}

Console.WriteLine("Count: " + count);
Console.WriteLine("Sum: " + sum);

if (count > 0)
{
    Console.WriteLine("Average: " + (double)sum / count);
    Console.WriteLine("Highest: " + highest);
    Console.WriteLine("Lowest: " + lowest);
}
else
{
    Console.WriteLine("Hiç geçerli not girilmedi.");
}
*/



int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(n + " x " + i + " = " + (n * i));
}