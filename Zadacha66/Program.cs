/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int PrintNumbersBetwenMandN(int numberM, int numberN)
{
    if ( numberN != numberM ) numberN = PrintNumbersBetwenMandN(numberM,numberN-1)+numberN;
    return  numberN;
}

Console.Write("Задача 66:"+
"\nЗадайте значения M и N."+
"\nНапишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n\n");

int numberM = NumberInput("число M");
int numberN = NumberInput("число N");
if ( numberM > numberN)// проверка, если M больше N - тогда меняет их местами, иначе будет бесконечный цикл
{
    int temp = numberM;
    numberM=numberN;
    numberN=temp;
    Console.WriteLine("Поменял местами M и N");
}
int sum = PrintNumbersBetwenMandN(numberM,numberN);
Console.Write($"\nM = {numberM}; N = {numberN}. -> {sum}");