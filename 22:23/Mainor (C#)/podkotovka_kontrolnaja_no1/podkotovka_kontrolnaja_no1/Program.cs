﻿using System;

class Program
{

    static void Main(string[] args)
    {

        // Задание 1
        // Объявить переменные, необходимые для вычисления площади прямоугольника.

        //float a, b, s; // стороны и площадь

        // Задание 2
        // Объявить переменные, необходимые для пересчета веса из фунтов в килограммы.

        float f, kg; // фунты, килограммы

        // Задание 3
        // Определить исходные данные и объявить переменные, необходимые для вычисления дохода по вкладу.

        //float v, d, p; // размер вклада, размер дохода, процент

        // Задание 4
        /* Объявить переменные, необходимые для вычисления стоимости покупки, состоящей из
           нескольких тетрадей, карандашей и линейки */

        //int t, k, l;
        //float ct, ck, cl, c;

        // Задание 5
        // Записать инструкцию, которая присваивает переменной x значение 1,5.

        //double h = 1.5; // переменной x  ПРИСВАЕВАЕМ значение 1.5

        //Console.WriteLine(h);

        // Задание 6
        // Написать инструкцию, которая присваивает переменной summa нулевое значение.

        int sum = 0; // сумма равна нулю

        // Задание 7
        // Записать инструкцию, которая увеличивает на единицу значение переменной n.

        //double n = 0;

        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(n + i);
        //}

        // Задание 8
        // Записать инструкцию, которая уменьшает на два значение переменной counter.

        //int counter = 10;

        //for (int i = 2; i <= 10; i++)
        //{
        //    Console.WriteLine(counter - i);
        //}

        // Задание 12
        // Написать программу вычисления стоимости покупки, состоящей из нескольких тетрадей
        // и карандашей. Рекомендуемый вид экрана программы:

        //double b = 2.75;
        //double d = 0.85;
        //int a, c;

        //Console.Write("Количество тетрадей: ");
        //a = Convert.ToInt32(Console.ReadLine());
        ////Console.Write("стоимость одной тетрадки: ");
        ////b = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Количество карандашей: ");
        //c = Convert.ToInt32(Console.ReadLine());
        ////Console.Write("стоимость одного карандаша: ");
        ////d = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Стоимость покупки: {a * b + c * d} euro");

        // Задание 13
        // Написать программу вычисления стоимости поездки на автомобиле.Исходные данные:
        // расстояние(км); количество бензина(в литрах), которое потребляет автомобиль на 100 км
        // пробега; цена одного литра бензина


        //Console.Write("Расстояние(км): ");
        //double z = Convert.ToSingle(Console.ReadLine());
        //Console.Write("Расход бензина(литров на 100 км пробега): ");
        //double x = Convert.ToSingle(Console.ReadLine());
        //Console.Write("Цена литра бензина (euro): ");
        //double o = Convert.ToSingle(Console.ReadLine());

        //Console.WriteLine("Поездка обойдется в " + Math.Round(z * x / 100 * o, 2) + " евро");
        //Console.ReadLine();

        // Задание 14
        // Написать программу, которая вычисляет скорость, с которой
        // спортсмен пробежал дистанцию

        //int sec;
        //int min;
        //int time;

        ////sec = (time - (time) * 100);


        //Console.Write("Введите длину дистанции (метров): ");
        //double s = Convert.ToSingle(Console.ReadLine());
        //Console.Write("Введите время (минут.секунд): ");
        //double t = Convert.ToSingle(Console.ReadLine());

        //Console.WriteLine("Дистанция:" + (s) + "\n{1:d2} ч. {2:d2} мин.");


        // Дополнительное задание
        // Определить, является ли числовое значение положительным или
        // отрицательным.

        int i;

        for (i = -5; i <= 5; i++)
        {
            Console.Write("Проверка " + i );

            if (i < 0) Console.WriteLine(" отрицательное число");
            else Console.WriteLine(" положительное число");
        }

    }

}