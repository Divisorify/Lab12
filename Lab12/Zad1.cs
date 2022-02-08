using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12;
public abstract class Product
{
    private float price;

    public string Name { get; set; }
    public string Description { get; set; }
    public float Price
    {
        get => price;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            price = value;
        }
    }

    public Product()
    {

    }

    public Product(string name, string description, float price)
    {
        Name = name;
        Description = description;
        Price = price;
    }


    public abstract void Buy();
    public abstract void ShowInfo();

}