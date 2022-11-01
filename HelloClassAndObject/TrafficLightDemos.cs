namespace HelloClassAndObject
{
    internal class TrafficLightDemos
    {
        public static void Demo1()
        {
            // Trafikklys - v1 uten objekt
            var isRedOn = true;
            var isYellowOn = false;
            var isGreenOn = false;

            // Trafikklys - v2 med objekt
            var trafficLight = new TrafficLight
            {
                isRedOn = true,
                isYellowOn = false,
                isGreenOn = true,
            };

            // Trafikklys - vise v1 
            Console.BackgroundColor = trafficLight.isRedOn ? ConsoleColor.Red : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = trafficLight.isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = trafficLight.isGreenOn ? ConsoleColor.Green : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;

            // Trafikklys - vise v2 
            trafficLight.Show();
            
        }

        public static void Demo2()
        {
            var trafficLight = new TrafficLight
            {
                isRedOn = true,
                isYellowOn = false,
                isGreenOn = true,
            };
            trafficLight.isGreenOn = true;

            var trafficLight2 = new TrafficLightV2();
            trafficLight2.Show();
            trafficLight2.Next();
            trafficLight2.Show();
            trafficLight2.Next();
            trafficLight2.Show();
            trafficLight2.Next();
            trafficLight2.Show();
            trafficLight2.Next();
            trafficLight2.Show();

            //Console.WriteLine(trafficLight2.IsRedOn);
            //trafficLight2.IsRedOn = false;

            //if (trafficLight2.isRedOn)
            //if (trafficLight2.IsRedOn())
            {
                //trafficLight2.isRedOn = true;
                //trafficLight2.IsRedOn() = true;
            }

        }
    }
}
