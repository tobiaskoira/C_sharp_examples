namespace Timer

{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Set time in seconds");
            string input = Console.ReadLine();
            int numberInput;
            bool isParsable = int.TryParse(input, out numberInput);
            int timeMs = numberInput * 1000;
            //DateTime number;

            //bool isParsable = DateTime.TryParse(input, out number);

            //Console.WriteLine(number);



            Timer t = new Timer(TimerCallback, null, timeMs, timeMs);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("Wake up little bird! " + DateTime.Now);
        }
    }
}