Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
while(-num <= i & i <= num)
{
    if(i%1==0)
    {
        Console.WriteLine(i);
    }
    i++;
}