using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите число:");

        // Преобразование строки в число с проверкой
        if (int.TryParse(Console.ReadLine(), out int name))
        {
            if (name < 10)
            {
                Console.WriteLine("Число " + name + " меньше 10");
            }
            else
            {
                Console.WriteLine("Число " + name + " больше 10");
            }
        }
        else
        {
            Console.WriteLine("Введено не число!");
        }
    }
}
