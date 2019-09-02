using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Олег Сергеевич, честно говоря не понял задания, там сказано что в методе нужно обрабатывать исключения
            //если в делитель попадает 0 то отлавливаем с этим все понятно, вторая часть задания отловить если в методе не заданы агрументы, 
            //но как... ведь если их не указать то ВС итак не скомпилирует.
            //int Division(int leftNumber, int rightNumber)
            //{
            //    try
            //    {
            //        return leftNumber / rightNumber;
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Ошибка, делитель не может быть 0");
            //    }
            //    return 0;
            //}
            //Console.WriteLine("Введите число №1");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число №2");
            //int secondNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(Division(firstNumber, secondNumber));
            //Console.ReadKey();

            //задание 2
            Console.WriteLine("Введите размер массива");
            int size = int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            for(int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("Введите значение элемента " + i);
                mas[i] = int.Parse(Console.ReadLine());
            }
            try
            {
                for (int i = 0; i < mas.Length + 1; i++) //тут выход за границы  массива
                {
                    Console.Write(mas[i] + "   ");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nВыход за границы массива!");
            }
            finally
            {
                Console.WriteLine("Завершение обработки!");
            }
            Console.ReadKey();
        }
    }
    
}