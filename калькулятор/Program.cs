Console.WriteLine("Меню:\r\n" +
"1. Сложить 2 числа\r\n" +
"2.Вычесть первое из второго\r\n" +
"3.Перемножить два числа\r\n" +
"4.Разделить первое на второе\r\n" +
"5.Возвести в степень N первое число\r\n" +
"6.Найти квадратный корень из числа\r\n" +
"7.Найти 1 процент от числа\r\n" +
"8.Найти факториал из числа\r\n" +
"9.Выйти из программы\r\n");
bool UserMPT = true;

do
{
    Console.WriteLine(" Номер математической операции: ");
    int LocalMPT = Convert.ToInt32(Console.ReadLine());
    if (LocalMPT == 9)
    {
        UserMPT = false;
    }
    else if (LocalMPT == 1)
    {
        Console.WriteLine("Введи первое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введи второе число: ");
        int P = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(P + A);
    }
    else if(LocalMPT == 2)
    {
        Console.WriteLine("Введи первое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введи второе число: ");
        int P = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(P - A);
    }
    else if(LocalMPT == 3)
    {
        Console.WriteLine("Введи первое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введи второе число: ");
        int P = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(A * P);
    }
    else if(LocalMPT == 4)
    {
        Console.WriteLine("Введи первое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введи второе число: ");
        int P = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(A / P);
    }
    else if(LocalMPT == 5)
    {
        Console.WriteLine("Введи число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введи степень числа:");
        int P = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(A, P));
    }
    else if(LocalMPT == 6)
    {
        Console.WriteLine("Введи число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(A));
    }
    else if(LocalMPT == 7)
    {
        Console.WriteLine("Введи число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((A / 100) * 1);
    }
    else if(LocalMPT == 8)
    {
        Console.Write("Введи число: ");
        int A = int.Parse(Console.ReadLine());
        int pofacty = 1;
        for (int i = 1; i <= A; i++)
        {
            pofacty *= i;
        }
        Console.WriteLine(pofacty);
    }
}
while (UserMPT == true);
{
    Console.WriteLine("sucsessfull exit");
}