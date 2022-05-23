double ArrayMax(double[] num)
{
    double resMin = 100;
    double resMax = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if(num[i] < resMin) resMin = num[i];
        if (num[i] > resMax) resMax = num[i];
    }
    double delta = resMax - resMin;
    return delta;
}
Console.Write("Введите размер массива :");
int size = int.Parse(Console.ReadLine());

double[] num = new double [size];
var  newRnd = new Random();
for(int i = 0; i < size; i++)
{
    num[i] = newRnd.Next(1, 100);
    Console.Write(num[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Разница между Макс и Мин = {ArrayMax(num)}");

