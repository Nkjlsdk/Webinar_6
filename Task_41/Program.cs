// Ввод с клавиатуры М чисел и вывысти сколько чисел больше 0 ввёл пользователь.

int [] arrayM = new int [5];
int count = 0;
Console.WriteLine("Введите 5 положельных или отрицательных чисел");

for (int i = 0; i < arrayM.Length; i++)
{
        arrayM[i]=Convert.ToInt32(Console.ReadLine());
        if (arrayM[i] > 0) count++;
    
}
Console.WriteLine($"количество положительных чисел: {count}");
