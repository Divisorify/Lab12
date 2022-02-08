using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Car : Product
    {
        public Color Color { get; set; }
        public int YearOfProduction { get; set; }
        public int CarMilage { get; set; }

        public Car()
        {

        }

        public Car(Color color, int yearOfProduction, int carMilage, string name, string description, float price) : base(name, description, price)
        {
            Color = color;
            YearOfProduction = yearOfProduction;
            CarMilage = carMilage;
        }

        public override void Buy()
        {
            Console.WriteLine("Kupiłeś auto");
            Console.WriteLine("Wydałeś: " + Price);
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Kolor: " + Color);
            Console.WriteLine("Rok produkcji: " + YearOfProduction);
            Console.WriteLine("Przebieg: " + CarMilage);
        }

        public void Drive()
        {
            Console.WriteLine("Auto jedzie");
        }

        public void Stop()
        {
            Console.WriteLine("Auto hamuje");
        }

    }

    public enum Color
    {
        White,
        Black,
        Red,
        Yellow
    }
}
