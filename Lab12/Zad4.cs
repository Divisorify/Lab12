using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Program
    {
        static void Main()
        {
            // Zad 2
            var car1 = new Car(Color.White, 2022, 0, "Tesla", "Model s", 120_000.99f);
            var car2 = new Car(Color.Yellow, 2010, 220, "Tesla", "Model e", 500_000.99f);
            var car3 = new Car(Color.Red, 2002, 230000, "Tesla", "Model x", 180_000.99f);
            var car4 = new Car(Color.Black, 1900, 1_000, "Tesla", "Model y", 300_000.99f);
            var car5 = new Car(Color.Yellow, 1999, 390_000, "Fiat", "Panda", 2);


            // Zad 3
            var truck1 = new Truck("Man", "Duża", 1_000_000, 100);
            var truck2 = new Truck("Inny Man", "Duża", 2_000_000, 200);
            var truck3 = new Truck("Tesla", "Mała", 3_000_000, 20);
            var truck4 = new Truck("Volvo","XCV", 1_200_000, 300);
            var truck5 = new Truck("Renault","Kapu", 100_100, 220);


            Product[] products = new Product[] { car1, car2, car3, car4, car5, truck1, truck2, truck3, truck4, truck5 };

            foreach (var product in products)
            {
                product.ShowInfo();
                Console.WriteLine();
            }

            //Zad 6
            List<FiguraGeometryczna> lista = new List<FiguraGeometryczna>();

            var kwadrat2 = new Kwadrat(2);
            FiguraGeometryczna[] figury = new FiguraGeometryczna[] { kwadrat2 };

            foreach (var figura in figury) {
                figura.ToString();
                Console.WriteLine(figura.ToString());
            }

            //lista.Add(new Kwadrat() { Kwadrat.bokA = 2 });
            lista.Add(new Kwadrat(3));
            lista.Add(new Kwadrat(4));
            lista.Add(new Prostokat(4, 2));
            lista.Add(new Trojkat(1, 2));
            //lista.Add(new Trapez(1, 2, 3));
            //lista.add(new Rownoleglobok(1, 2, 3));
            //lista.add(new Romb(1, 2, 3));
            //lista.add(new Kolo(1, 2, 3));
            lista.Add(new Szescian(3));
            lista.Add(new Prostopadloscian(1, 2, 3));

            foreach (var list in lista)
            {
                Console.WriteLine(list.ToString());
            }

        }
    }
}
