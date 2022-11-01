namespace HelloClassAndObject
{
    internal class TrafficLight
    {
        public bool isRedOn;
        public bool isYellowOn;
        public bool isGreenOn;

        public void Show()
        {
            Console.BackgroundColor = isRedOn ? ConsoleColor.Red : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = isGreenOn ? ConsoleColor.Green : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
