
using OperatorExercises2;

Console.WriteLine("What is the radius of your circle?");
var radius = double.Parse(Console.ReadLine());

var answer = AreaOfCircle.AreaOfCircles(radius);
Console.WriteLine($"The area of a circle with radius of {radius} is {answer}");