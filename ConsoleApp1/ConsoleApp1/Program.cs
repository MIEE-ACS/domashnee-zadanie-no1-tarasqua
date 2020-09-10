using System;

namespace ConsoleApp1
{
    class functionCalculator
    {
        static void Main(string[] args)
        {
            do //цикл с постусловием
            {

                double x, y; //объявляем переменные

                try //проверка на ошибку 
                {
                    Console.WriteLine("Введите значение x:"); //поясняем, что нужно ввести пользователю
                    x = double.Parse(Console.ReadLine()); //вводим значение x

                    y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7; //вычисления 

                    Console.WriteLine($"Значение функции y = {Math.Round(y, 3)}"); //вывод данных

                }
                catch
                {
                    Console.WriteLine("Внимание! Неправильный ввод данных!"); //оповещение при ошибке 
                }

                Console.WriteLine("Для завершения программы введите 'exit'. Чтобы продолжить, нажмите любую клавишу."); //диалоговое окно для выхода из программы
                //(сделал так, чтобы можно было увидеть результат и/или, при желании, продолжить вычисления) 

            }
            while (Console.ReadLine() != "exit"); //условие
        }
    }
}
