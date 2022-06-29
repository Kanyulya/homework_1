Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int thirdNum = num % 10;
Console.WriteLine("Последней цифрой числа " + num + " является "+ thirdNum);
