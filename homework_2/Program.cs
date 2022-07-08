Console.WriteLine("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int sumnumber(int number)
{
    int sum = 0;
    while(number > 0)
        {
            sum += number % 10;
            number /=10;
        }
    return sum;
}
sum = sumnumber(number);
Console.WriteLine(sum);