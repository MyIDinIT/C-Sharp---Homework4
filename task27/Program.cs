// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
int sum=0;
int B=0;

if (A<0) A=-A;

while (A>0)
{
    B=A%10;
    sum +=B;
    A=A/10;
}
Console.WriteLine("Сумма всех цифр числа: "+sum);
