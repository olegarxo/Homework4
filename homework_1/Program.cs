Console.WriteLine("Введите A");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int parseMassive(int A, int B)
{
      int number = Convert.ToInt32(Math.Pow(A,B));
      return number;
}
int tamp = parseMassive(number,numberSecond);
Console.WriteLine(tamp);