Console.Write("Введите размер массива :");
int size = int.Parse(Console.ReadLine());

int[] num = new int [size];
int count = 0;

var  newRnd = new Random();
for(int i = 0; i < size; i++)
{
    num[i] = newRnd.Next(100, 1000);
    Console.Write(num[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if (num[i]%2 == 0) 
    {
        count+=1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");