using System;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {

            // //Задание 1.1.
            // string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
            // Console.WriteLine("Дни недели в обратном порядке:");
            // for (int i = days.Length - 1; i >= 0; i--)
            // {
            //     Console.WriteLine($"{i}: {days[i]}");
            // }


            // // Задание 1.2.
            // double[] temps = { -3.5, 0.2, 4.5, 7.1, -1.0, -5.2, 2.0 };
            // Console.WriteLine("Температуры за неделю:");
            // foreach (double t in temps)
            // {
            //     Console.Write(t + " ");
            // }
            // Console.WriteLine();




            // // Задание 2.
            // int[] prices = { 120, 45, 300, 80, 15, 210 };
            // int sum = 0;
            // int countMoreThan100 = 0;

            // foreach (int price in prices)
            // {
            //     sum += price;
            //     if (price > 100)
            //     {
            //         countMoreThan100++;
            //     }
            // }

            // double average = (double)sum / prices.Length;

            // Console.WriteLine($"Общая сумма цен: {sum}"); 
            // Console.WriteLine($"Средняя цена: {average:F2}");
            // Console.WriteLine($"Количество товаров дороже 100: {countMoreThan100}");




            // // Задание 3.
            // int[] prices = { 120, 45, 300, 80, 15, 210 };
            // int minPrice = prices[0];
            // int maxIndex = 0;

            // for (int i = 1; i < prices.Length; i++)
            // {
            //     if (prices[i] < minPrice)
            //     {
            //         minPrice = prices[i];
            //     }

            //     if (prices[i] > prices[maxIndex])
            //     {
            //         maxIndex = i;
            //     }
            // }

            // Console.WriteLine($"Минимальная цена: {minPrice}"); 
            // Console.WriteLine($"Индекс самого дорогого товара: {maxIndex}"); 




            // // Задание 4.
            // int[] balance = { 100, -50, 20, -5, 0, 75 };

            // for (int i = 0; i < balance.Length; i++)
            // {
            //     if (balance[i] < 0)
            //     {
            //         balance[i] = 0;
            //     }
            // }

            // Console.WriteLine("Массив после замены отрицательных элементов на 0:");
            // foreach (int val in balance)
            // {
            //     Console.Write(val + " ");
            // }
            // Console.WriteLine();




            // // Задание 5. Ввод с клавиатуры
            // int[] userNumbers = new int[5];
            // Console.WriteLine("Введите 5 целых чисел:");
            // for (int i = 0; i < userNumbers.Length; i++)
            // {
            //     Console.Write($"Элемент {i}: ");
            //     userNumbers[i] = int.Parse(Console.ReadLine());
            // }

            // int evenCount = 0;
            // Console.WriteLine("Массив в обратном порядке:");
            // for (int i = userNumbers.Length - 1; i >= 0; i--)
            // {
            //     Console.Write(userNumbers[i] + " ");
            //     if (userNumbers[i] % 2 == 0)
            //     {
            //         evenCount++;
            //     }
            // }
            // Console.WriteLine($"\nКоличество чётных чисел: {evenCount}");


            // // Задание 6. Поиск по имени
            // string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
            // Console.Write("Введите имя для поиска: ");
            // string searchName = Console.ReadLine();
            // int position = -1;

            // for (int i = 0; i < names.Length; i++)
            // {
            //     if (names[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            //     {
            //         position = i;
            //         break;
            //     }
            // }

            // if (position != -1)
            // {
            //     Console.WriteLine($"Имя найдено на позиции: {position}");
            // }
            // else
            // {
            //     Console.WriteLine("Не найдено");
            // }



            // Журнал Оценок

            // int[] grades = { 5, 4, 3, 2, 5, 4, 5, 3 }; 

            // Console.Write("Все оценки: ");
            // foreach (int grade in grades)
            // {
            //     Console.Write(grade + " ");
            // }
            // Console.WriteLine();

            // int totalSum = 0;
            // int minGrade = grades[0];
            // int maxGrade = grades[0];
            // int countTwos = 0;
            // int countFives = 0;

            // foreach (int grade in grades)
            // {
            //     totalSum += grade;

            //     if (grade < minGrade) minGrade = grade;
            //     if (grade > maxGrade) maxGrade = grade;

            //     if (grade == 2) countTwos++;
            //     if (grade == 5) countFives++;
            // }

            // double avgGrade = (double)totalSum / grades.Length;

            // Console.WriteLine($"Средняя оценка: {avgGrade:F2}");
            // Console.WriteLine($"Наибольшая оценка: {maxGrade}");
            // Console.WriteLine($"Наименьшая оценка: {minGrade}");
            // Console.WriteLine($"Количество двоек: {countTwos}");
            // Console.WriteLine($"Количество пятерок: {countFives}");

            // if (avgGrade >= 4.5)
            //     Console.WriteLine("Статус: Отличник");
            // else if (avgGrade >= 3.5)
            //     Console.WriteLine("Статус: Хорошист");
            // else
            //     Console.WriteLine("Статус: Есть над чем поработать");



            //Дополнительное задание 


            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.Write("Исходный массив: ");
            foreach (int n in arr) Console.Write(n + " ");
            Console.WriteLine();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.Write("Развернутый на месте: ");
            foreach (int n in arr) Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
