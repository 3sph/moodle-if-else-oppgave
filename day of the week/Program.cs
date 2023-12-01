using System.Runtime.CompilerServices;
using day_of_the_week;

while(true)
{
Console.WriteLine("Lets insert a number between 1 and 7 to see what day of the week it is.");
var input = Console.ReadLine();

var days = new Days();

switch (input)
{
    
case "1": 
    Console.WriteLine($"the number you have selected corresponds to {days.Monday}");
    break;
    case "2":
    Console.WriteLine($"the number you have selected corresponds to {days.Tuesday}");
    break;
    case "3":
    Console.WriteLine($"the number you have selected corresponds to {days.Wednesday}");
    break;
    case "4":
    Console.WriteLine($"the number you have selected corresponds to {days.Thursday}");
    break;
    case "5":
    Console.WriteLine($"the number you have selected corresponds to {days.Friday}");
    break;
    case "6":
    Console.WriteLine($"the number you have selected corresponds to {days.Saturday}");
    break;
    case "7":
    Console.WriteLine($"the number you have selected corresponds to {days.Sunday}");
    break;
        case "0":
            return;

default: Console.WriteLine("the number you have selected does not correspond to a day"); 
    break;

}
}