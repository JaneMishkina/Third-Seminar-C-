/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int getCorrectNumber()
{
    int result = 0;
    while (true)
    {
        Console.WriteLine("Введите пятизначное положительное число: ");
        if (int.TryParse(Console.ReadLine(), out result) && result>=10000)
        {
                break;
        }        
        else
        {
            Console.WriteLine("Введено некорректное число");
        }
    }
    return result;
}

int result = getCorrectNumber();
string number = Convert.ToString(result);
if(number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
