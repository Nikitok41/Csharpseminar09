/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
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
            if (numberInt < 0) Console.WriteLine("Введите положительное число");
            else
            {
                number = numberInt;
                isInputInt = false;
            }
            
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

int A(int n, int m)//Эталон слизанный с интернета
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}

long Akerman(long m , long n) // переписал что бы ручками понять что да как - в итоге - не вытяжигвает даже (4,1) =) 
{
    if ( m == 0 ) return n+1;
    if ( (m != 0) && (n == 0) ) return Akerman(m-1,1);
    else return Akerman(m-1,Akerman(m,n-1));
}
//это пока что максимум что я могу сделать =) там дальше формулы меняются и я не могу понять чего и сколько раз нужно возводить в степень. 
ulong AkermanVersionTwo(ulong numM , ulong numN)
{
    ulong stepeni = 2;
    if ( numM == 0 ) return numN+1;
    if ( numM == 1 ) return numN+2;
    if ( numM == 2 ) return 2*numN+3;
    if ( numM == 3 ) return (ulong)Math.Pow(2,numN+3)-3;
    if ( numM == 4 )
    {
        for (int i = 2; i < (int)numN+3 ; i++)
        {
            stepeni = stepeni*stepeni;
        }
        return (ulong)Math.Pow(2,stepeni)-3;
    }
    if ( numM == 5 )
    {
        for ( int j = 0 ; j <= (int)numN ;j++)
            for (int i = 2; i <= (int)numN+3 ; i++)
            {
                stepeni = stepeni*stepeni;
            }
        return (ulong)Math.Pow(2,stepeni)-3;
    }
    else return 0;
}

Console.Write("Задача 68:"+
"\nНапишите программу вычисления функции Аккермана с помощью рекурсии."+
"\nДаны два неотрицательных числа m и n. \n\n");

int numberM = NumberInput("число m");
int numberN = NumberInput("число n");

//long acerman = A(numberN,numberM);
//Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {acerman}");
//long acerman = Akerman(numberM,numberN);
//Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {acerman}");
ulong acerman = AkermanVersionTwo((ulong)numberM,(ulong)numberN);
Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {acerman}");