//Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

int x = Convert.ToInt32(Console.ReadLine());
int h = x;
if (x>=100)
{ int i=0;
while (x>0)
{
    x=x/10;
    i=i+1;
}
int stepen1 = i-2;
int stepen2 = i-3;
int c = h%10;
double d= (Math.Pow(c, stepen1))/(Math.Pow(10, stepen2));
Console.WriteLine(d);
}
else if (x<100)
Console.WriteLine("нет третьей цифры");