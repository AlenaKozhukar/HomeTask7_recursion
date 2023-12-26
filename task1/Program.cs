// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int InputNumber()
{
    Console.WriteLine("Введите число ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numM = InputNumber();
int numN = InputNumber();

int firstNum = numM;
int secondNum = numN;

void PrintNumbers(int startNum, int endNum) 
{
    System.Console.WriteLine(startNum);
    if(startNum >= endNum)
    {
        return;
    }
    PrintNumbers(startNum+1, endNum);  
}

if (numM < numN)
{
    PrintNumbers(firstNum, secondNum);
}
else
{
    PrintNumbers(secondNum, firstNum);
}
