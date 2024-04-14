// See https://aka.ms/new-console-template for more information
//linq
int[] numbers = { 5, 8, 3, 9 };
var evenNumbers = numbers.Where(num => num % 2 == 0);
Console.WriteLine("Even numbers:");
foreach (int num in evenNumbers)
{
    Console.WriteLine(num);
}

// 

List<int> studentGrades = new List<int> { 87, 90, 57, 62, 35 };
double averageGrade = studentGrades.Average();
Console.WriteLine("The average grade is:" + averageGrade);

//function 

Console.WriteLine("Enter your name:");
string userName = Console.ReadLine();   
GreetUser(userName);
void GreetUser(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}

//

Console.WriteLine("Enter the volume of the box:");
Console.WriteLine("Length: ");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("width:");
double width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("height:");
double heigth = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("volume is: " + heigth + width + length);

