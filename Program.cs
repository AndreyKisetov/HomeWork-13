namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            {
            Console.Clear();
            Console.WriteLine("Введите положительное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string x = Convert.ToString(number);
                if (x.Length > 2)
                {
                    Console.WriteLine($"-> {x[2]}");
                }
                else
                {
                    Console.WriteLine($"-> Третьей цифры нет");
                }
            }
        }
    }
}
