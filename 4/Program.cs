int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;    
   return result;
}
Console.WriteLine("Введите первое число");
int arg1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int arg2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int arg3 = Convert.ToInt32(Console.ReadLine());
int max = Max(arg1, arg2, arg3);
Console.WriteLine("Максимальное из трех чисел " + max);

//Либо подставляя каждый раз числа
/*int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;    
   return result;
}*/

/*int a = 2;
int b = 3;
int c = 7;
int max = Max(a, b, c);
Console.WriteLine("Максимальное из трех чисел " + max);*/


/*int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;    
   return result;
}

int a = 44;
int b = 5;
int c = 78;
int max = Max(a, b, c);
Console.WriteLine("Максимальное из трех чисел " + max);*/


/*int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;    
   return result;
}

int a = 22;
int b = 3;
int c = 9;
int max = Max(a, b, c);
Console.WriteLine("Максимальное из трех чисел " + max);*/
