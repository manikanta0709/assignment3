// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to employee wage computation program");
Random random = new Random();
int res = random.Next(0, 2);
Console.WriteLine(res);
const int wageperhour = 20, fulldayhour = 8, parttimehour = 4,workingdaypermonth=20;
switch (res)
{
    case 1:
        Console.WriteLine("present");
        Console.WriteLine("wage of employee :" + ((wageperhour * fulldayhour)* workingdaypermonth));
        Console.WriteLine(parttimehour * wageperhour);
        break;
    default:
        Console.WriteLine("absent");
        break;
}
