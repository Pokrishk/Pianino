namespace пианино
{
    internal class Program
    {
            static int[] PervOkt = new int[12] {3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174};
            static int[] VtryOkt = new int[12] {6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 1038, 1100, 1165, 1235};
            static int[] DestOkt = new int[12];
        static void Main(string[] args)
        {
            Console.WriteLine("F1 и F2 - переключение между октавами.");
            Console.WriteLine("С D по L - белые клавиши, а с R по I - чёрные.");
            Console.WriteLine("Первая октава.");
            DestOkt = PervOkt;
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2)
                {
                    Oktavi(key);
                }
                Zvuk(key);
            }
            while (true);
        }
        static int[] Oktavi(System.ConsoleKeyInfo key)
        {
            string okt = key.Key == ConsoleKey.F1 ? "Первая октава" : "Вторая октава";
            Console.WriteLine(okt);
            DestOkt = key.Key == ConsoleKey.F1? PervOkt: VtryOkt;
            return DestOkt;
        }
        static void Zvuk(System.ConsoleKeyInfo key)
        {
            switch(key.Key)
            {
                case ConsoleKey.D:
                    Console.Beep(DestOkt[0],300);
                break;
                case ConsoleKey.F:
                    Console.Beep(DestOkt[2], 300);
                break;
                case ConsoleKey.G:
                    Console.Beep(DestOkt[4], 300);
                break;
                case ConsoleKey.H:
                    Console.Beep(DestOkt[5], 300);
                break;
                case ConsoleKey.J:
                    Console.Beep(DestOkt[7], 300);
                break;
                case ConsoleKey.K:
                    Console.Beep(DestOkt[9], 300);
                break;
                case ConsoleKey.L:
                    Console.Beep(DestOkt[11], 300);
                break;
                case ConsoleKey.R:
                    Console.Beep(DestOkt[1], 300);
                break;
                case ConsoleKey.T:
                    Console.Beep(DestOkt[3], 300);
                break;
                case ConsoleKey.Y:
                    Console.Beep(DestOkt[6], 300);
                break;
                case ConsoleKey.U:
                    Console.Beep(DestOkt[8], 300);
                break;
                case ConsoleKey.I:
                    Console.Beep(DestOkt[10], 300);
                break;
            }
        }
    }
}