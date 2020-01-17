using System;

namespace CommandPattern.Models
{
    public class Product
    {
        public string Name;
        public int Price;

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"O preço para o {Name} foi aumentado em ${amount}");
        }

        public bool DecreasePrice(int amount)
        {
            if(amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"O preço para o {Name} foi diminuído em ${amount}");
                return true;
            }
            return false;
        }

        public override string ToString() => $"O preço atual para o produto {Name} é ${Price}";
        
    }
}
