// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void NewArray(int A)
{ 
    int[] array=new int[A];
    for (int i = 0; i < A; i++)
    {
       array[i]=new Random().Next(100);
    }
    for (int i = 0; i < A; i++)
    {
    //    Console.Write(array[i]+","); 
    }
    Console.WriteLine(string.Join(",",array));
    
}
Console.WriteLine("Введите количество элементов в массиве: ");
int number=Convert.ToInt32(Console.ReadLine());
NewArray(number);
