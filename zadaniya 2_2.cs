//Листинг кода первой программы:

double x, y;
Console.WriteLine("Введите количество X и Y: ");
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
double alfa = Math.Atan2(x, y) * 180.0 / Math.PI;
Console.WriteLine(alfa);


//Листинг кода второй программы:

int xn = int.Parse(Console.ReadLine());
int yn = int.Parse(Console.ReadLine());
int xk = int.Parse(Console.ReadLine());
int yk = int.Parse(Console.ReadLine());

if ((xn > 0) && (yn > 0))
{
    Console.WriteLine("1 четверть");
}
if ((xn > 0) && (yn < 0))
{
    Console.WriteLine("4 четверть");
}
if ((xn < 0) && (yn > 0))
{
    Console.WriteLine("2 четверть");
}
if ((xn < 0) && (yn < 0))
{
    Console.WriteLine("3 четверть");
}
if ((xk > 0) && (xk > 0))
{
    Console.WriteLine("1 четверть");
}
if ((xk > 0) && (xk < 0))
{
    Console.WriteLine("4 четверть");
}
if ((xk < 0) && (xk > 0))
{
    Console.WriteLine("2 четверть");
}
if ((xk < 0) && (xk < 0))
{
    Console.WriteLine("3 четверть");
}


//Листинг кода третьей программы:


Random gen = new Random();
Console.WriteLine("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
int sum = 0;
for (int j = 0; j < n; j++)
{
    array[j] = gen.Next(-10, 11);
    Console.WriteLine(array[j]);
}
for (int i = 0; i < n; i++)
{
    if (array[i] != 0)
    {
        if (array[i] % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
}
Console.WriteLine("Сумма: ");
Console.WriteLine(sum);


//Листинг кода четвертой программы:

int s;
int F = 1;
Console.WriteLine("Введите число");
s = int.Parse(Console.ReadLine());
for (int c = s; c > 1; c--)
{
    F = F * c;
}
Console.WriteLine("Факториал  = " + F);
Console.ReadLine();


//Листинг кода пятой программы:

    Console.WriteLine("Введите количество элементов: ");
int k = int.Parse(Console.ReadLine());
int[] fivezad = new int[k];
for (int j = 0; j < k; j++)
{
    fivezad[j] = gen.Next(-10, 11);
    Console.WriteLine(array[j]);
}
int summa = 0;
for (int i = 0; i < k; i++)
{
    if (fivezad[i] == fivezad[i + 1])
        summa = summa + 1;
}
Console.WriteLine(summa);


//Листинг кода шестой программы:

int summa6 = 0;
for (int aaa = 1000; aaa <= 9999; aaa++)
{
    if ((aaa % 133 == 125) && (aaa % 134 == 111))
    {
        summa6 = summa6 + 1;
        Console.WriteLine(aaa);
    }

}
Console.WriteLine("Всего таких чисел:");
Console.WriteLine(summa6);







