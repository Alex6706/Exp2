

    
        Console.Write("Введите первое число ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число ");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число ");
        double d = Convert.ToInt32(Console.ReadLine());
        double max = Convert.ToInt32(0);

        if (a > b)
        {
            max = a;
        }

        else
        {
            max = b;
        }

        if (max > d)
        {

        }

        else
        {
            max = d;
        }

        Console.WriteLine($"max = {max}");
    
