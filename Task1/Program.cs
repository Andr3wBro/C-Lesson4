// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int enter(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return int.Parse(number);
}

int A = enter("Enter nubmer A => ");
int B = enter("Enter nubmer B => ");
int APow = A;
for (int i =2; i<=B; i++)
{
     APow=APow*A;
}
Console.WriteLine($"Число {A} в степени {B}  =  {APow}");