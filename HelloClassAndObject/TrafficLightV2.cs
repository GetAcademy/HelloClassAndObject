namespace HelloClassAndObject
{
    internal class TrafficLightV2
    {
        //public bool IsRedOn { get; private set; }
        //public bool IsYellowOn { get; private set; }
        //public bool IsGreenOn { get; private set; }

        //private bool _isRedOn;
        //private bool _isYellowOn;
        //private bool _isGreenOn;
        private int _phase;

        public TrafficLightV2()
        {
            //_isRedOn = true;
            _phase = 1;
        }

        //public bool IsRedOn()
        //{
        //    return isRedOn;
        //}

        public void Show()
        {
            //Console.WriteLine("vvv");
            //Console.BackgroundColor = _isRedOn ? ConsoleColor.Red : ConsoleColor.Black;
            //Console.WriteLine(" ");
            //Console.BackgroundColor = _isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Black;
            //Console.WriteLine(" ");
            //Console.BackgroundColor = _isGreenOn ? ConsoleColor.Green : ConsoleColor.Black;
            //Console.WriteLine(" ");
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.WriteLine("^^^");

            Console.WriteLine("vvv");
            Console.BackgroundColor = _phase < 3 ? ConsoleColor.Red : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = _phase is 2 or 4 ? ConsoleColor.Yellow : ConsoleColor.Black;
            //Console.BackgroundColor = _phase % 2 == 0 ? ConsoleColor.Yellow : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = _phase == 3 ? ConsoleColor.Green : ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("^^^");
        }

        public void Next()
        {
            //_phase++;
            //if (_phase == 5) _phase = 1;

            _phase = _phase == 4 ? 1 : _phase + 1;

            //if (_isRedOn && !_isYellowOn)
            //{
            //    _isYellowOn = true;
            //}
            //else if (_isRedOn && _isYellowOn)
            //{
            //    _isRedOn = false;
            //    _isYellowOn = false;
            //    _isGreenOn = true;
            //}
            //else if (_isGreenOn)
            //{
            //    _isYellowOn = true;
            //    _isGreenOn = false;
            //}
            //else if (_isYellowOn)
            //{
            //    _isRedOn = true;
            //    _isYellowOn = false;
            //}
        }
    }
}
