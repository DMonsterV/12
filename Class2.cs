namespace Last
{
    public class victor
    {

        static QWE kaka = new QWE();


        public static QWE fok(int perem)
        {
            switch (perem)
            {
                case 3:

                    kaka.Forma = "Круг - 500; ";
                    return kaka;

                case 4:

                    kaka.Forma = "Квадрат - 500; ";
                    return kaka;
                case 5:

                    kaka.Forma = "Прямоугольник - 500; ";
                    return kaka;
                case 6:

                    kaka.Forma = "Сердце - 700; ";
                    return kaka;
            }
            return kaka;

        }
        public static QWE Sized(int perem)
        {
            switch (perem)
            {
               case 3:
                    kaka.Sized = "Маленький (Деаметр - 16см, 8 порций) - 1000, ";
                    return kaka;
                case 4:
                    kaka.Sized = "Средний (Деаметр - 18см, 1 порций) - 1200, ";
                    return kaka;
                case 5:
                    kaka.Sized = "Большой (Деаметр - 28см, 24 порций) - 2000, ";
                    return kaka;

            }
            return kaka;
        }
        public static QWE Tasted(int perem) 
        {
            switch (perem)
            {
                case 3:
                    kaka.Tasted = "Ванильный - 100, ";
                    return kaka;
                case 4:
                    kaka.Tasted = "Шоколадный - 100, ";
                    return kaka;
                case 5:
                    kaka.Tasted = "Карамельный - 150, ";
                    return kaka;
                case 6:
                    kaka.Tasted = "Ягодный - 200, ";
                    return kaka;
                case 7:
                    kaka.Tasted = "Кокосовый - 250, ";
                    return kaka;

            }
            return kaka;
        }
        public static QWE volnet(int perem)
        {
            switch (perem)
            {
                case 3:
                    kaka.Volumet = "1 корж - 200, ";
                    return kaka;
                case 4:
                    kaka.Volumet = "2 коржа - 400, ";
                    return kaka;
                case 5:
                    kaka.Volumet = "3 коржа - 600, ";
                    return kaka;
                case 6:
                    kaka.Volumet = "4 коржа - 800, ";
                    return kaka;

            }
            return kaka;
        }
        public static QWE Glazured(int perem)
        {
            switch (perem)
            {
                case 3:
                    kaka.Glazured = "Шоколад - 100, ";
                    return kaka;
                case 4:
                    kaka.Glazured = "Крем - 100, ";
                    return kaka;
                case 5:
                    kaka.Glazured = "Бизе - 150, ";
                    return kaka;
                case 6:
                    kaka.Glazured = "Драже - 150, ";
                    return kaka;
                case 7:
                    kaka.Glazured = "Ягоды - 200, ";
                    return kaka;

            }
            return kaka;
        }
        public static QWE Discord(int perem) 
        {
            switch (perem)
            {
                case 3:
                    kaka.Discord = "Ягодная - 150; ";
                    return kaka;
                case 4:
                    kaka.Discord = "Шоколадная - 150; ";
                    return kaka;
                case 5:
                    kaka.Discord = "Кремовая - 150; ";
                    return kaka;

            }
            return kaka;

        }
        public static QWE zero()
        {
            kaka.Forma = null;
            kaka.Sized = null;
            kaka.Tasted = null;
            kaka.Volumet = null;
            kaka.Glazured = null;
            kaka.Discord = null;

            return kaka;
        }
    }
}