using System.Globalization;

namespace Last
{
    public class Program
    {
        static List<QWE> menu = new List<QWE>(); 
        static int price;
        static void Main()



        {
            victor kaka = new victor();


            DateTime aDateTime = DateTime.Now;
            string DATA = Convert.ToString(aDateTime);

            Console.Clear();
            Console.WriteLine("Заказ тортов в Глазурька, торты на ваш выбор!");
            Console.WriteLine("Выберите параметр торта");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Общая стоимость:" + price);



            Console.WriteLine("Ваш торт:");
            foreach (QWE pos in menu)
            {
                Console.Write(pos.Forma);
                Console.Write(pos.Sized);
                Console.Write(pos.Tasted);
                Console.Write(pos.Volumet);
                Console.Write(pos.Glazured);
                Console.Write(pos.Discord);
            }
            



            int position = 3;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;


                }
                if (position > 9)
                {
                    position = 9;
                    Console.SetCursorPosition(0, position);
                }
                if (position < 4)
                {
                    position = 3;
                    Console.SetCursorPosition(0, position);
                }
                Console.Clear();
                Console.WriteLine("Заказ тортов в Глазурька, торты на ваш выбор!");
                Console.WriteLine("Выберите параметр торта");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("  Форма торта");
                Console.WriteLine("  Размер торта");
                Console.WriteLine("  Вкус коржей");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Общая стоимость:" + price);

                Console.WriteLine("Ваш торт:");
                foreach (QWE pos in menu)
                {
                    Console.Write(pos.Forma);
                    Console.Write(pos.Sized);
                    Console.Write(pos.Tasted);
                    Console.Write(pos.Volumet);
                    Console.Write(pos.Glazured);
                    Console.Write(pos.Discord);
                }
                


                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();


            }

            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("--------------------------------------");

            string[] S1 = new string[] { "  Круг - 500", "  Квадрат - 500", "  Прямоугльник - 500","  Сердечко - 700" };
            string[] S2 = new string[] { "  Маленький (Деаметр - 16см, 8 порций) - 1000", "  Средний (Деаметр - 18см, 1 порций) - 1200", "  Большой (Деаметр - 28см, 24 порций) - 2000" };
            string[] S3 = new string[] { "  Ванильный - 100", "  Шоколадный - 100", "  Карамельный - 150", "  Ягодный - 200", "  Кокосовый - 250" };
            string[] S4 = new string[] { "  1 корж - 200", "  2 коржа - 400", "  3 коржа - 600", "  4 коржа - 800" };
            string[] S5 = new string[] { "  Шоколад - 100", "  Крем - 100", "  Бизе - 150", "  Драже - 150", "  Ягоды - 200" };
            string[] S6 = new string[] { "  Ягодная - 150", "  Шоколадная - 150", "  Кремовая - 150" };

            switch (position) 
            {
                case 3:

                    foreach (string item in S1)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 4:

                    foreach (string item in S2)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 5:

                    foreach (string item in S3)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case 6:

                    foreach (string item in S4)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case 7:

                    foreach (string item in S5)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 8:

                    foreach (string item in S6)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case 9:

                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один, нажмите на клавишу TAB");
                    ConsoleKeyInfo ked = Console.ReadKey();
                    if (ked.Key == ConsoleKey.Tab)
                    {

                        foreach (QWE ass in menu)
                        {
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "Дата: " + DATA + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "Ваш заказ:" + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Forma);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Sized);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Tasted);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Volumet);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Glazured);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Discord + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "Общая стоимость:" + price + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "\n");

                        }
                        Program.menu.Clear();
                        victor.zero();
                        price = 0;
                        Main();
                    }
                    else
                    {
                        foreach (QWE ass in menu)
                        {
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "Дата: " + DATA + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "Ваш заказ:" + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Forma);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Sized);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Tasted);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Volumet);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Glazured);
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", ass.Discord + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "Общая стоимость:" + price + "\n");
                            File.AppendAllText("C:\\Users\\foxso\\OneDrive\\Рабочий стол\\Заказ.txt", "\n");

                        }
                        Environment.Exit(0);
                    }

                    break;
            }

            int position2 = 3;
            Console.SetCursorPosition(0, position2);
            Console.WriteLine("->");
            ConsoleKeyInfo key2 = Console.ReadKey();
            if (key2.Key == ConsoleKey.Escape)
            {
                Main();

            }
            else
            {
                while (key2.Key != ConsoleKey.Enter)
                {
                    if (key2.Key == ConsoleKey.UpArrow)
                    {
                        position2--;
                    }
                    if (key2.Key == ConsoleKey.DownArrow)
                    {
                        position2++;

                    }
                    if (position2 > 7)
                    {
                        position2 = 7;
                        Console.SetCursorPosition(0, position2);
                    }
                    if (position2 < 3)
                    {
                        position2 = 3;
                        Console.SetCursorPosition(0, position2);
                    }

                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню");
                    Console.WriteLine("--------------------------------------");

                    switch (position) 
                    {
                        case 3:

                            foreach (string item in S1)
                            {
                                Console.WriteLine(item);

                            }

                            break;
                        case 4:

                            foreach (string item in S2)
                            {
                                Console.WriteLine(item);
                            }

                            break;
                        case 5:

                            foreach (string item in S3)
                            {
                                Console.WriteLine(item);
                            }

                            break;

                        case 6:

                            foreach (string item in S4)
                            {
                                Console.WriteLine(item);
                            }

                            break;

                        case 7:

                            foreach (string item in S5)
                            {
                                Console.WriteLine(item);
                            }

                            break;
                        case 8:

                            foreach (string item in S6)
                            {
                                Console.WriteLine(item);
                            }

                            break;




                    }
                    Console.SetCursorPosition(0, position2);
                    Console.WriteLine("->");
                    key2 = Console.ReadKey();
                    if (key2.Key == ConsoleKey.Escape)
                    {
                        Main();
                    }

                }
                Program.menu.Clear();
                                     
                switch (position)
                {
                    case 3:

                        if (position2 == 3)
                        {
                            Program.menu.Add(victor.fok(position2));
                            price = price + 500;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(victor.fok(position2));
                            price = price + 500;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(victor.fok(position2));
                            price = price + 500;
                        }
                        if (position2 == 6)
                        {
                            Program.menu.Add(victor.fok(position2));
                            price = price + 700;
                        }
                        break;

                    case 4:

                        if (position2 == 3)
                        {

                            Program.menu.Add(victor.Sized(position2));
                            price = price + 1000;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(victor.Sized(position2));
                            price = price + 1200;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(victor.Sized(position2));
                            price = price + 2000;
                        }
                        break;

                    case 5:

                        if (position2 == 3)
                        {
                            Program.menu.Add(victor.Tasted(position2));
                            price = price + 100;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(victor.Tasted(position2));
                            price = price + 100;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(victor.Tasted(position2));
                            price = price + 150;
                        }
                        if (position2 == 6)
                        {
                            Program.menu.Add(victor.Tasted(position2));
                            price = price + 200;
                        }
                        if (position2 == 7)
                        {
                            Program.menu.Add(victor.Tasted(position2));
                            price = price + 250;
                        }
                        break;

                    case 6:

                        if (position2 == 3)
                        {
                            Program.menu.Add(victor.volnet(position2));
                            price = price + 200;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(victor.volnet(position2));
                            price = price + 400;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(victor.volnet(position2));
                            price = price + 600;
                        }
                        if (position2 == 6)
                        {
                            Program.menu.Add(victor.volnet(position2));
                            price = price + 800;
                        }
                        break;

                    case 7:

                        if (position2 == 3)
                        {
                            Program.menu.Add(victor.Glazured(position2));
                            price = price + 100;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(victor.Glazured(position2));
                            price = price + 100;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(victor.Glazured(position2));
                            price = price + 150;
                        }
                        if (position2 == 6)
                        {
                            Program.menu.Add(victor.Glazured(position2));
                            price = price + 150;
                        }
                        if (position2 == 7)
                        {
                            Program.menu.Add(victor.Glazured(position2));
                            price = price + 200;
                        }
                        break;

                    case 8:

                        if (position2 == 3)
                        {
                            Program.menu.Add(victor.Discord(position2));
                            price = price + 150;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(victor.Discord(position2));
                            price = price + 150;

                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(victor.Discord(position2));
                            price = price + 150;
                        }
                        break;





                }
                Main();
            }
        }
    }
}