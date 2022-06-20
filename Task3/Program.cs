//Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int min = enter("Enter min of Array => ");
int max = enter("Enter max of Array => ");
int arraylenght = enter("Enter Array Lenght => ");
void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}
int[] CreateAndFillArr(int large)
{
    int[] array = new int[large];
    for (int ifill = 0; ifill < array.Length; ifill++)
    {
        array[ifill] = new Random().Next(min, max + 1);
    }
    return array;
}
int enter(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return int.Parse(number);
}

int[] NewArray = CreateAndFillArr(arraylenght);
printArr(NewArray);