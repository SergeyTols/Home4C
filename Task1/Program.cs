    // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
    // в натуральную степень B

    Console.Write("Введите A: ");
    double A = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите B: ");
    uint B = Convert.ToUInt32(Console.ReadLine());

    // double x = Math.Pow(A, B);   //-  Мне так больше нравится.

    double x = 1;

    for(int i=1; i <= B; i++)
    {
        x = x * A;
    }
        
    Console.Write("Ответ: " + x);






