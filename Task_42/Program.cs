// Ввод числа и преобразование десятичного числа в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

 
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = string.Empty;
            while (number > 0)
            {
                int remain = number % 2;
                number = number/2;
                result = remain.ToString() + result;
            }
            Console.WriteLine($"Двоичное число: {result}");
               
    
