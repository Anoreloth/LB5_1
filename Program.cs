using System;

namespace LB5_1
{
    interface IShape
    {
        string sizeFigure { get; }
        string Type();
        string Square();
    }
    interface IColoredShape : IShape
    {
        string color { set; }
        string ShowColor();
    }
    class Circle : IShape
    {
        protected double r { get; set; }
        public Circle(double r)
        {
            this.r = r;
        }
        public string sizeFigure
        {
            get
            {
                return $"The size of the figure: {r}";
            }
        }
        public string Square()
        {
            double s = Math.PI * (r * r);
            return $"Figure area = {s.ToString("F" + 5)}";
        }
        public string Type()
        {
            return "Type: circle";
        }
    }
    class ColoredCircle : Circle, IColoredShape
    {
        public string color;
        public ColoredCircle(double r, string color) : base(r)
        {
            this.color = color;
        }

        string IColoredShape.color { set => Console.ReadLine(); }

        public string ShowColor()
        {
            return $"Color: {color}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ColoredCircle[] rectangle = { new ColoredCircle(3, "black"), new ColoredCircle(8.5, "green"), new ColoredCircle(11, "red") };
            foreach (ColoredCircle str in rectangle)
            {
                Console.WriteLine($"{str.Type()}\n{str.sizeFigure}\n{str.Square()}\n{str.ShowColor()}\n");
            }
        }
    }
}
