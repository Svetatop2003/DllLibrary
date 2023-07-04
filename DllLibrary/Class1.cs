using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products = new List<Product>();

        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void ShowAll()
        {
            Console.WriteLine("Инфо о складе:\n" +
                $"\tНазвание: {Name}\n" +
                $"\t:Адрес {Address}\n\n" + "Список товаров:");

            Products.Sort();
            foreach (Product product in Products)
            {
                product.Show();
            }
        }
    }
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Product(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public void Show()
        {
            Console.WriteLine("Информация о складе:\n" + $"\tНазвание: {Name}" + $"Количество\t: {Number}");
        }
        public int CompareTo(Product other)
        {
            return (this.Name + this.Number).CompareTo(other.Name + other.Number);
        }
    }
}

    

    









