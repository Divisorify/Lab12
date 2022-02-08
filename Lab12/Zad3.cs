using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class CarPassenger
    {
        public int NumberOfSeats { get; set; }

        public CarPassenger() { }

        public CarPassenger(int numberOfSeats)
        {
            NumberOfSeats = numberOfSeats;
        }
    }

    public class Truck : Product
    {
        private int capacity;

        public int Capacity
        {
            get => capacity;
            set
            {
                if (capacity < 0)
                    throw new ArgumentOutOfRangeException(nameof(capacity));
                capacity = value;
            }
        }

        public Truck() { }

        public Truck(string name, string description, float price, int capacity) : base(name, description, price)
        {
            Capacity = capacity;
        }

        public override void Buy()
        {
            Console.WriteLine("Kupiłeś ciężarówkę");
            Console.WriteLine("Wydałeś: " + Price);
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Pojemność: " + Capacity);
        }
    }
}

