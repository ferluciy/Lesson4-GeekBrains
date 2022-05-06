using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using GBcool;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Classes.LogoLesson("4");
                Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.Green);
                Classes.PrintCenter("█                       ГЛАВНОЕ МЕНЮ                       █", ConsoleColor.Green);
                Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.Green);
                Console.WriteLine("");
                Classes.PrintLeft("Задача 1: Найти количество пар элементов массива, в которых только одно число делится на 3", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 2 (ДЗ 2-а): Реализация первой задачи с помощью статического класса", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 3 (ДЗ 2-б,в): Загрузка массива из файла TextFile1.txt, обработка отсутсвия файла", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 4 (ДЗ 3-а,б и в): Демонстрация класса для работы с одномерным массивом", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 5 (ДЗ 4): Загрузка логинов и паролей из файла, проверка соответствия", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 6 (ДЗ 5): Демонстрация работы с двумерным массивом", false, ConsoleColor.White);
                Console.WriteLine("");
                Classes.PrintLeft("Задача 7: Выход", false, ConsoleColor.White);
                Console.WriteLine("");
                Classes.PrintLeft("Какую задачу ты хочешь выполнить: ", true, ConsoleColor.Yellow);
                Classes.PrintLeft("", true, ConsoleColor.Green);

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Task1();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 2:
                        Task2();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 3:
                        Task3();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 4:
                        Task4();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 5:
                        Task5();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 6:
                        Task6();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 7:
                        return;
                }
            }
        }
        static void Task1()
        {
            Classes.LogoLesson("4");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█          Найти количество пар элементов массива,         █", ConsoleColor.White);
            Classes.PrintCenter("█         в которых только одно число делится на 3         █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            MyArray myArray = new MyArray(20, -10000, 10000, true);
            myArray.PrintArray();
            Console.WriteLine("");
            int number = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (Classes.DelNaChislo(myArray[i], myArray[i + 1], 3))
                { 
                    number++;
                    Classes.PrintLeft(String.Format($"Найденная пара: {myArray[i]} : {myArray[i+1]}"), false, ConsoleColor.Yellow);
                }
               
            }
            Console.WriteLine("");
            Classes.PrintLeft(String.Format($"Количество пар в массиве: {number}"), false, ConsoleColor.Green);
        }

        static void Task2()
        {
            Classes.LogoLesson("4");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█          Найти количество пар элементов массива,         █", ConsoleColor.White);
            Classes.PrintCenter("█         в которых только одно число делится на 3!        █", ConsoleColor.White);
            Classes.PrintCenter("█    Реализация в виде статического класса StaticClass     █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            MyArray myArray = new MyArray(20, -10000, 10000, true);
            myArray.PrintArray();
            Console.WriteLine("");
            MyArray.SearchPara(myArray, 3);
        }

        static void Task3()
        {
            Classes.LogoLesson("4");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█          Загрузка массива из файла TextFile1.txt         █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("Попытка загрузки файла TextFile1.txt", false, ConsoleColor.Yellow);
            MyArray myArray = new MyArray(AppDomain.CurrentDomain.BaseDirectory + "TextFile1.txt");
            myArray.PrintArray();
            Console.WriteLine("");

            //пример проверки отсуствия файла в майн. Также есть пример обработки ошибки в самом классе MyArray
            Classes.PrintLeft("Попытка загрузки несуществующего файла Randol.txt", false, ConsoleColor.Yellow);
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Randol.txt"))
            {
                Classes.PrintLeft("ERROR: Файл Randol.txt не найден", false, ConsoleColor.Red);
                Classes.PrintLeft("Проверьте наличие файла в директории: ", false, ConsoleColor.Red);
                Classes.PrintLeft(AppDomain.CurrentDomain.BaseDirectory, false, ConsoleColor.Red);
            }
            else
            {
                MyArray myArray1 = new MyArray(AppDomain.CurrentDomain.BaseDirectory + "Randol.txt");
                myArray1.PrintArray();
            }
        }

        static void Task4()
        {
            Classes.LogoLesson("4");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█   Демонстрация класса для работы с одномерным массивом   █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            Console.WriteLine("");
            Classes.PrintCenter("**************** МАССИВ 1 ******************", ConsoleColor.White);
            Console.WriteLine("");

            MyArray myArray = new MyArray(10, 0, 3);

            Classes.PrintLeft("Массив от 0 с заданным шагом в 3:", false, ConsoleColor.Yellow);
            myArray.PrintArray();
            Console.WriteLine("");

            Classes.PrintLeft("Всего элементов в массиве: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray.Length, true, ConsoleColor.Green);
            Console.WriteLine("");

            Classes.PrintLeft("Сумма всех элементов массива: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray.Sum, true, ConsoleColor.Green);
            Console.WriteLine("");

            Classes.PrintLeft("Количество максимальных элементов в массиве: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray.MaxCount, false, ConsoleColor.Green);
            Console.WriteLine("");

            Classes.PrintLeft("Новый массив с измененными знаками: ", false, ConsoleColor.Yellow);
            myArray.Inverse().PrintArray();
            Console.WriteLine("");

            Classes.PrintLeft("Умножим каждый элемент исходного массива на 2:", false, ConsoleColor.Yellow);
            myArray.Multi(2);
            myArray.PrintArray();
            Console.WriteLine("");
            Classes.PrintCenter("**************** МАССИВ 2 ******************", ConsoleColor.White);
            Console.WriteLine("");

            MyArray myArray1 = new MyArray(20, 1, 7, true); //создаем новый массив из случайных чисел, т.к. в предыддущем массиве каждый элемент входит всегда только один раз
            Classes.PrintLeft("Создаем новый массив для наглядного подсчета количества вхождений:", false, ConsoleColor.Yellow);           
            myArray1.PrintArray();
            Classes.PrintLeft("Количество максимальных элементов в массиве: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray1.MaxCount, false, ConsoleColor.Green);
            Console.WriteLine("");
            var numbers = new Dictionary<int, int>(); //создаем коллекцию Dictionary
            int counter;
            for (int i = 0; i < myArray1.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < myArray1.Length; j++)
                {
                   if (myArray1[i] == myArray1[j]) counter++;
                }
               
                if (!numbers.ContainsKey(myArray1[i])) numbers.Add(myArray1[i], counter);
            }
            foreach (int i in numbers.Keys)
            {
                Classes.PrintLeft(String.Format($"Количество вхождений числа {i} в массиве: "), true, ConsoleColor.Yellow);
                Classes.PrintLeft(String.Format($"{numbers[i]}"), false, ConsoleColor.Green);
            }
        }

        static void Task5()
        {
            Classes.LogoLesson("4");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█           Загрузка логина и пароля из файла              █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            string user_login = "root", user_password = "GeekBrains";
            string s;
            int counter = 0;
            int count_enter=0;
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "Logins.txt";
            Classes.PrintLeft("Считываем логины и пароли из файла Logins.txt:", false, ConsoleColor.Yellow);

            StreamReader streamReader = new StreamReader(fileName);
            Account[] users = new Account[System.IO.File.ReadAllLines(fileName).Length];
            Classes.PrintLeft("Всего паролей в файле: "+ System.IO.File.ReadAllLines(fileName).Length, false, ConsoleColor.Yellow);
            while (!streamReader.EndOfStream)
            {
                s = streamReader.ReadLine();
                users[counter].Login = s.Split(';')[0];
                users[counter].Password = s.Split(';')[1];
                counter++;
            }
            for (int i = 0; i < users.GetLength(0); i++)
            {
                Classes.PrintLeft(String.Format($"Элемент {i+1}: Логин/пароль {users[i].Login} : {users[i].Password}"), false, ConsoleColor.White);
            }
            Console.WriteLine("");
            

            int a;
            bool flag;
            do
            {
                flag = false; //меняем на false перед каждым циклом
                Classes.PrintLeft("С какой строки ты хочешь начать брут: ", true, ConsoleColor.Yellow);
                flag = int.TryParse(Console.ReadLine(), out a);
                if (!flag)
                {
                    a = -1;
                    Classes.PrintLeft("ERROR: Нужно указать целое положительное число. Попробуйте еще раз! ", false, ConsoleColor.Red);
                }
                else
                {
                    if (a <= 0) Classes.PrintLeft("ERROR: Нужно указать целое положительное число. Попробуйте еще раз! ", false, ConsoleColor.Red);
                    else if (a > users.Length) Classes.PrintLeft("ERROR: В файле нет столько паролей. Укажите меньшее число! ", false, ConsoleColor.Red);
                    else break;
                }

            } while (true);


            Console.WriteLine("");
            for (int i = a-1; i < users.Length; i++)
            {
                if (users[i].Login == user_login && users[i].Password == user_password)
                {
                    Classes.PrintLeft(String.Format($"Вход выполнен. Верная пара логин/пароль в строке {i+1}: {users[i].Login} - {users[i].Password}"), false, ConsoleColor.Green);
                    break;
                }
                else
                {
                    count_enter++;
                    if (count_enter>=3)
                    {
                        Classes.PrintCenter("Было три неудачных попытки авторизации...", ConsoleColor.Red);
                        Console.WriteLine("");
                        Classes.PrintCenter("!!! ВХОД ЗАБЛОКИРОВАН НАВСЕГДА !!!", ConsoleColor.Red);
                        break;
                    }
                }
            }
        }

        static void Task6()
        {
            Classes.LogoLesson("4");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█        Демонстрация работы с двумерным массивом          █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            MyDoubleArray myArray = new MyDoubleArray(4, 3, -5,15);
            Classes.PrintLeft("Создан массив:", false, ConsoleColor.Yellow);
            myArray.PrintArray();
            Classes.PrintLeft("Сумма всех чисел: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray.AllSum(), false, ConsoleColor.Green);
            Classes.PrintLeft("Сумма всех чисел, которые больше 10: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray.AllSum(10), false, ConsoleColor.Green);
            Classes.PrintLeft("Минимальное число в массиве: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray.Min, false, ConsoleColor.Green);
            Classes.PrintLeft("Максимальное число в массиве: ", true, ConsoleColor.Yellow);
            Classes.PrintLeft("" + myArray.Max, false, ConsoleColor.Green);
            int a, b;
            myArray.IndexMaxVal(out a, out b);
            Classes.PrintLeft(String.Format($"Номер максимального числа <{a}:{b}>"), false, ConsoleColor.Yellow);
            Console.WriteLine("");
            Classes.PrintLeft("Введите название файла для загрузки в массив (пример: double.txt): ", true, ConsoleColor.Yellow);
            Classes.PrintLeft(" ", true, ConsoleColor.Green);
            bool activated = false;
            string fileName = AppDomain.CurrentDomain.BaseDirectory + Console.ReadLine();
            do
            {
                if (!File.Exists(fileName))
                {
                    Classes.PrintLeft("ERROR:", false, ConsoleColor.Red);
                    Classes.PrintLeft(String.Format($"Файл {fileName} не найден"), false, ConsoleColor.Red);
                    Classes.PrintLeft("Введите корректное название файла: ", true, ConsoleColor.Yellow);
                    Classes.PrintLeft("", true, ConsoleColor.Green);
                    fileName = AppDomain.CurrentDomain.BaseDirectory + Console.ReadLine();
                }
                else
                {
                    if (fileName.Contains(".txt"))
                    {

                            Classes.PrintLeft("Создаем массив из файла <", true, ConsoleColor.Yellow);
                            Classes.PrintLeft(fileName, true, ConsoleColor.Green);
                            Classes.PrintLeft(">", false, ConsoleColor.Yellow);
                            MyDoubleArray myArray1 = new MyDoubleArray(fileName, ';');
                            myArray1.PrintArray();
                        do
                        {
                            Classes.PrintLeft("Введите название файла для сохранения (пример: result): ", true, ConsoleColor.Yellow);
                            Classes.PrintLeft(" ", true, ConsoleColor.Green);
                            string fileName2 = Console.ReadLine() + ".txt";
                            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + fileName2))
                            {
                                Classes.PrintLeft("Файл <" + fileName2 + "> уже существует", false, ConsoleColor.Red);
                                Classes.PrintLeft("Перезаписать? y/n: ", true, ConsoleColor.Green);
                                var input = Console.ReadKey();

                                switch (input.Key)
                                {
                                    case ConsoleKey.Y:
                                        Console.WriteLine("");
                                        activated = true;
                                        myArray1.SaveArrayInFile(fileName2, ';');
                                        break;

                                    case ConsoleKey.N:
                                        Console.WriteLine("");
                                        Classes.PrintLeft("Файл не был сохранен, попробуйте заново", false, ConsoleColor.Yellow);
                                        break;

                                }
                            }
                            else
                            {
                                activated = true;
                                myArray1.SaveArrayInFile(fileName2, ';');
                                break;
                            }
                        } while (!activated);
                    }
                    else
                    {
                        Classes.PrintLeft("Я умею работать только с txt-файлами. Укажи другое название: ", true, ConsoleColor.Yellow);
                        Classes.PrintLeft("", true, ConsoleColor.Green);
                        fileName = AppDomain.CurrentDomain.BaseDirectory + Console.ReadLine();
                    }
                    
                }
            } while (!activated);
            
        }
    }
}
