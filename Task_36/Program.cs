Console.Write("Введите размер массива :");
int size = int.Parse(Console.ReadLine());

int[] num = new int [size];
int sum = 0;

var  newRnd = new Random();
for(int i = 0; i < size; i++)
{
    num[i] = newRnd.Next(1, 100);
    Console.Write(num[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if (i % 2 != 0) 
    {
        sum += num[i];
    }
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");