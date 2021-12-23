using System;

namespace System
{
    class Rain {


        public string Weather = "Дождь";
        public string region = "Київ";
        public int Vise = 754;
        public int Wind = 1;

        public void Print()
        {
            Console.WriteLine("Погода:"+ Weather);
            Console.WriteLine("Регiон:"+ region);
            Console.WriteLine("Тиск:"+ Vise + "мм рт. ст.");
            Console.WriteLine("Вiтер:"+ Wind + "м/c");
        }
        
    }
    class Snowfall
    {


        public string Weather = "Cнiгопад";
        public string region = "Харкiв";
        public int Vise = 749;
        public int Wind = 8;

        public void Print()
        {
            Console.WriteLine("\nПогода:" + Weather);
            Console.WriteLine("Регiон:" + region);
            Console.WriteLine("Тиск:" + Vise + "мм рт. ст.");
            Console.WriteLine("Вiтер:" + Wind + "м/c");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rain KYIV = new Rain();
            KYIV.Print();

            Snowfall Kharkiv = new Snowfall();
            Kharkiv.Print();
        }
    }
}
