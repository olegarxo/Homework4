void enternumber(int[] number)
{
    int index = 0;
    int length = number.Length;
    while(index < length)
    {
        number[index] = new Random().Next(-10,10);
        index++;
    }
}
void printNumber(int[] number)
{
    int index = 0;
    int length = number.Length;
    while(index<length)
    {
        if(index<length-1)
        {
            Console.Write($"{number[index]},");
            index++;
        }
        else
        {
           Console.Write($"{number[index]},");
            index++;  
        }
    }
}
void sortMassive(int[] number)
{
    int length = number.Length;
    int tamp = 0;
    for(int i = length - 1;i > 0; i--)
    {
        for(int j =0; j < length - 1;j++)
        {
            if(Math.Abs(number[j]) > Math.Abs(number[j+1]))
            {
                tamp = number[j+1];
                number[j+1] = number[j];
                number[j] = tamp;

            }
        }
    }
}
int[] number = new int[8];
enternumber(number);
printNumber(number);
Console.WriteLine();
sortMassive(number);
printNumber(number);
