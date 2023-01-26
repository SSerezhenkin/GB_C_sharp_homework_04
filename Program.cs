double Task01(int a, int b)
{
    return Math.Pow(a, b);
}

int Task02(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
void Task03(int len)
{
    int[] arr = new int[len];

    foreach (int i in arr)
    {
        arr[i] = new Random().Next(1, 100);
        System.Console.Write(arr[i] + " ");
    }
}

System.Console.WriteLine("Введите номер задачи, где: \n 1 - возведение в степень \n 2 - сумма цифр в числе \n 3 - вывод массива");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
    case 1:
        System.Console.WriteLine("Введите два числа. Первое будет возведено в степень второго");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Task01(a, b));
        break;
    case 2:
        System.Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Сумма цифр в числе = " + Task02(num));
        break;
    case 3:
        Task03(8);
        break;
    default:
        System.Console.WriteLine("Такой задачи нет");
        break;
}