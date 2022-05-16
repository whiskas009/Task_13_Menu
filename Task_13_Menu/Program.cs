using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberForEscape = 0;
            string firstName = "...";
            string secondName = "...";
            string userName = "...";
            string age = "...";
            string setPassword = "";
            string enterPassword = "";

            while (numberForEscape != 1)
            {
                
                if (enterPassword == setPassword)
                {
                    while (enterPassword == setPassword)
                    {
                        Console.WriteLine($"\nВаш имя: {firstName} \nВаша фамилия: {secondName} \nВаш псевдоним: {userName} \nВаш возраст: {age}\n");
                        Console.WriteLine("Выберите действие: \n1. Установить имя \n2. Установить фамилию \n3. Установить псевдоним \n4. Указать возраст \n5. Стереть все данные \n6. Установить пароль\n7. Выход\n");
                        
                        int menuNumber = int.Parse(Console.ReadLine());

                        switch (menuNumber)
                        {
                            case 1:
                                Console.WriteLine("\nВведите ваше имя:");
                                firstName = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("\nВведите вашу фамилию:");
                                secondName = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("\nВведите ваш псевоним:");
                                userName = Console.ReadLine();
                                break;

                            case 4:
                                Console.WriteLine("\nВведите ваш возраст:");
                                age = Console.ReadLine();
                                break;

                            case 5:
                                firstName = "...";
                                secondName = "...";
                                userName = "...";
                                age = "...";
                                break;

                            case 6:
                                Console.WriteLine("\nВведите ваш пароль:");
                                setPassword = Console.ReadLine();
                                Console.WriteLine("Готово!\n");
                                break;
                                
                            case 7:
                                numberForEscape = 1;
                                setPassword = " ";
                                break;
                        }

                    }
                }

                if (numberForEscape == 1) break;
                Console.WriteLine("Введите пароль: или введите 0 для выхода");
                enterPassword = Console.ReadLine();
                
                switch (enterPassword)
                {
                    case "0":
                        numberForEscape = 1;
                        break;
                }  
            }

            
            
        }

    }
}
