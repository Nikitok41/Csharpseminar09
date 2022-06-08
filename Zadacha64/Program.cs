/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number =0;
    while (isInputInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            number = numberInt;
            isInputInt = false;
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

void PrintNumbersBetwenMandN(int numberM, int numberN,int number) // третяя переменная чисто для "расивого вывода"
{
    if ( numberN == numberM ) Console.Write($"'{numberM}, ");
    else 
    {
        PrintNumbersBetwenMandN(numberM,numberN-1,number);
        if (number == numberN) Console.Write($"{numberN}'");
        else Console.Write($"{numberN}, ");
    }
}

Console.Write("Задача 64:"+
"\nЗадайте значения M и N."+
"\nНапишите программу, которая выведет все натуральные числа в промежутке от M до N.\n");

int numberM = NumberInput("число M");
int numberN = NumberInput("число N");
if ( numberM > numberN)// проверка, если M больше N - тогда меняет их местами, иначе будет бесконечный цикл
{
    int temp = numberM;
    numberM=numberN;
    numberN=temp;
    Console.WriteLine("Поменял местами M и N");
}
Console.Write($"M = {numberM}; N = {numberN}. -> ");
PrintNumbersBetwenMandN(numberM,numberN,numberN);