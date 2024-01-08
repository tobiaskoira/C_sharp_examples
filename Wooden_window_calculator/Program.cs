namespace Wooden_window_calculator

{
    internal class Program
    {

        interface Methods
        {
            double SquareOfWood(double a, double b, double c, double framewidth);
            double SquareOfGlass(double a, double b, double c, double framewidth);
        }
        public class Window : Methods
        {
            public double height { get; set; }
            public double length { get; set; }

            private double widthOfWindow = 0.15;

            private double widthOfFrame = 0.05;

            public double width { get { return widthOfWindow; } }

            public double widthFrame { get { return widthOfFrame; } }

            public double SquareOfWood(double a, double b, double c, double framewidth)
            {
                return (a * b - (a - framewidth) * (b - framewidth)) * c;
            }

            public double SquareOfGlass(double a, double b, double c, double framewidth)
            {
                return (a - framewidth) * (b - framewidth) * 3;
            }
        }


        static void Main(string[] args)
        {

            ShowResult();
        }

        private static void ShowResult()
        {
            Console.WriteLine("Give a length of window, m");
            string lengthInput = Console.ReadLine();
            double a;
            bool isParsable = double.TryParse(lengthInput, out a);


            Console.WriteLine("Give a height of window, m");
            string widthInput = Console.ReadLine();
            double b;
            _ = double.TryParse(widthInput, out b);


            Window calc = new Window();
            double c = calc.width;
            double framewidth = calc.widthFrame;
            double _Wood = calc.SquareOfWood(a, b, c, framewidth);
            double Wood = Math.Round(_Wood, 2);
            double _Glass = calc.SquareOfGlass(a, b, c, framewidth);
            double Glass = Math.Round(_Glass, 2);
            Console.WriteLine($"you need {Wood} m(3) of wood and {Glass} m(2) of glass ");
        }
    }
}