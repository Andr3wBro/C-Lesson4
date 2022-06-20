// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int enter(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return int.Parse(number);
}

int Number = enter("Enter nubmer => ");
int answer = 0, NumberCopy = Number;
for (int i = 0; Number > 0; i++)
    {
        answer = answer + (Number % 10);
        Number = Number / 10;
    }
Console.WriteLine($"The sum of the digits in a number {NumberCopy}  =  {answer}");