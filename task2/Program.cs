// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.


int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int Ackerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}

int functionAkkerman = Ackerman(m, n);

Console.Write($"Результат функции Аккермана = {functionAkkerman} ");



