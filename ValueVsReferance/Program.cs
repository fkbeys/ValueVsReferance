public class Program
{
    public static void Main()
    {
        M:
        Console.ForegroundColor = ConsoleColor.Green;
        var rand = new Random();
        int width, height;
        int[] y;

        width = Console.WindowWidth;
        height = Console.WindowHeight;

        y = new int[width];
        for (int x = 0; x < width; ++x)
            y[x] = rand.Next(height);

        while (true)
        {
            for (int x = 0; x < width; ++x)
            {

                Console.SetCursorPosition(x, y[x]);
                Console.Write((char)('a' + rand.Next(50)));

                if (x < Console.WindowWidth && y[x] < Console.WindowHeight)
                {
                    // Print a random character at the current position
                    Console.SetCursorPosition(x, y[x]);
                    Console.Write((char)('a' + rand.Next(50)));
                }
                y[x] = (y[x] + 1) % height;
                if (width != Console.WindowWidth)
                {
                    goto M;
                }
            }
            Thread.Sleep(50);
        }
    }
}
